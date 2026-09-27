using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace Lab01
{
    public partial class Lab01_Bai07 : Form
    {
        public Lab01_Bai07()
        {
            InitializeComponent();

            btnProcess.Click -= btnProcess_Click;
            btnProcess.Click += btnProcess_Click;

            btnClear.Click -= btnClear_Click;
            btnClear.Click += btnClear_Click;

            btnExit.Click -= btnExit_Click;
            btnExit.Click += btnExit_Click;
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            rtbResult.Clear();
            string rawInput = txtInput.Text.Trim();

            if (string.IsNullOrEmpty(rawInput))
            {
                MessageBox.Show("Vui lòng nhập danh sách họ tên và điểm của sinh viên!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtInput.Focus();
                return;
            }

            string[] elements = rawInput.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            if (elements.Length < 2)
            {
                MessageBox.Show("Đã nhập sai format!\r\nChuỗi phải gồm họ tên sinh viên ở đầu và ít nhất 1 môn điểm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string studentName = elements[0].Trim();
            if (string.IsNullOrEmpty(studentName) || double.TryParse(studentName, out _))
            {
                MessageBox.Show("Đã nhập sai format!\r\nPhần tử đầu tiên phải là họ và tên sinh viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<double> scores = new List<double>();
            for (int i = 1; i < elements.Length; i++)
            {
                string token = elements[i].Trim();
                if (!double.TryParse(token, NumberStyles.Any, CultureInfo.InvariantCulture, out double score))
                {
                    MessageBox.Show(string.Format("Đã nhập sai format!\r\nPhần tử thứ {0} ('{1}') không phải là số hợp lệ.", i + 1, token), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (score < 0 || score > 10)
                {
                    MessageBox.Show(string.Format("Đã nhập sai format!\r\nĐiểm môn học ('{0}') phải nằm trong khoảng từ 0 đến 10.", token), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                scores.Add(score);
            }

            double sum = 0;
            double maxScore = scores[0];
            double minScore = scores[0];
            int passCount = 0;
            int failCount = 0;

            for (int i = 0; i < scores.Count; i++)
            {
                double s = scores[i];
                sum += s;

                if (s > maxScore) maxScore = s;
                if (s < minScore) minScore = s;

                if (s >= 5.0)
                    passCount++;
                else
                    failCount++;
            }

            double dtb = sum / scores.Count;

            string ranking = "";
            if (dtb >= 8.0 && minScore >= 6.5)
            {
                ranking = "Giỏi";
            }
            else if (dtb >= 6.5 && minScore >= 5.0)
            {
                ranking = "Khá";
            }
            else if (dtb >= 5.0 && minScore >= 3.5)
            {
                ranking = "Trung bình";
            }
            else if (dtb >= 3.5 && minScore >= 2.0)
            {
                ranking = "Yếu";
            }
            else
            {
                ranking = "Kém";
            }

            StringBuilder sbScores = new StringBuilder();
            for (int i = 0; i < scores.Count; i++)
            {
                sbScores.Append(string.Format("Môn {0}: {1}", i + 1, scores[i].ToString("0.##", CultureInfo.InvariantCulture)));
                if (i < scores.Count - 1)
                {
                    sbScores.Append("   ");
                }
            }

            List<string> maxSubjects = new List<string>();
            List<string> minSubjects = new List<string>();
            for (int i = 0; i < scores.Count; i++)
            {
                if (scores[i] == maxScore)
                    maxSubjects.Add(string.Format("Môn {0}", i + 1));
                if (scores[i] == minScore)
                    minSubjects.Add(string.Format("Môn {0}", i + 1));
            }

            rtbResult.AppendText("┌─────────────────────────────────────────────────────────────┐\r\n");
            rtbResult.AppendText("│                THÔNG TIN KẾT QUẢ SINH VIÊN                  │\r\n");
            rtbResult.AppendText("├─────────────────────────────────────────────────────────────┤\r\n");
            rtbResult.AppendText(string.Format("  Trạng thái:            Đã nhập đúng format!\r\n"));
            rtbResult.AppendText(string.Format("  Họ và tên:             {0}\r\n", studentName));
            rtbResult.AppendText(string.Format("  Danh sách điểm:        {0}\r\n", sbScores.ToString()));
            rtbResult.AppendText("├─────────────────────────────────────────────────────────────┤\r\n");
            rtbResult.AppendText(string.Format("  Điểm trung bình (ĐTB): {0:F2}\r\n", dtb));
            rtbResult.AppendText(string.Format("  Môn điểm cao nhất:     {0} ({1})\r\n", maxScore.ToString("0.##", CultureInfo.InvariantCulture), string.Join(", ", maxSubjects)));
            rtbResult.AppendText(string.Format("  Môn điểm thấp nhất:    {0} ({1})\r\n", minScore.ToString("0.##", CultureInfo.InvariantCulture), string.Join(", ", minSubjects)));
            rtbResult.AppendText(string.Format("  Số môn đậu:            {0} môn\r\n", passCount));
            rtbResult.AppendText(string.Format("  Số môn không đậu:      {0} môn\r\n", failCount));
            rtbResult.AppendText(string.Format("  Xếp loại sinh viên:    {0}\r\n", ranking));
            rtbResult.AppendText("└─────────────────────────────────────────────────────────────┘\r\n");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInput.Clear();
            rtbResult.Clear();
            txtInput.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}