using System;
using System.Windows.Forms;

namespace Lab01
{
    public partial class Lab01_Bai05 : Form
    {
        public Lab01_Bai05()
        {
            InitializeComponent();

            btnCalculate.Click -= btnCalculate_Click;
            btnCalculate.Click += btnCalculate_Click;

            btnClear.Click -= btnClear_Click;
            btnClear.Click += btnClear_Click;

            btnExit.Click -= btnExit_Click;
            btnExit.Click += btnExit_Click;

            cboChoice.SelectedIndex = -1;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            rtbResult.Clear();

            if (!int.TryParse(txtA.Text.Trim(), out int a) || !int.TryParse(txtB.Text.Trim(), out int b))
            {
                MessageBox.Show("Vui lòng nhập hai số nguyên A và B hợp lệ!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cboChoice.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn chức năng thực hiện (Bảng cửu chương hoặc Tính toán giá trị)!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboChoice.Focus();
                return;
            }

            if (cboChoice.SelectedIndex == 0)
            {
                int diff = b - a;
                rtbResult.AppendText(string.Format("BẢNG CỬU CHƯƠNG (B - A = {0}):\r\n\r\n", diff));
                for (int i = 1; i <= 10; i++)
                {
                    rtbResult.AppendText(string.Format("{0} x {1} = {2}\r\n", diff, i, diff * i));
                }
            }
            else if (cboChoice.SelectedIndex == 1)
            {
                rtbResult.AppendText("KẾT QUẢ TÍNH TOÁN GIÁ TRỊ:\r\n\r\n");

                int sub = a - b;
                if (sub < 0)
                {
                    rtbResult.AppendText(string.Format("1. (A - B)!: Không xác định (do A - B = {0} < 0)\r\n\r\n", sub));
                }
                else
                {
                    long fact = 1;
                    for (int i = 2; i <= sub; i++)
                    {
                        fact *= i;
                    }
                    rtbResult.AppendText(string.Format("1. (A - B)! = ({0})! = {1}\r\n\r\n", sub, fact));
                }

                if (b < 1)
                {
                    rtbResult.AppendText(string.Format("2. Tổng S: Không hợp lệ vì B phải >= 1 (hiện tại B = {0})\r\n", b));
                }
                else
                {
                    long sum = 0;
                    long power = 1;
                    for (int i = 1; i <= b; i++)
                    {
                        power *= a;
                        sum += power;
                    }
                    rtbResult.AppendText(string.Format("2. S = {0}^1 + {0}^2 + ... + {0}^{1} = {2}\r\n", a, b, sum));
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            rtbResult.Clear();
            cboChoice.SelectedIndex = -1;
            txtA.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}