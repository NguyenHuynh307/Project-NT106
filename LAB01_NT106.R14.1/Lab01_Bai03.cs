using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Lab01
{
    public partial class Lab01_Bai03 : Form
    {
        private bool isAdvancedMode = false;

        public Lab01_Bai03()
        {
            InitializeComponent();
        }
        private void btnChuyenCheDo_Click(object sender, EventArgs e)
        {
            isAdvancedMode = !isAdvancedMode;

            txtSo.Clear();
            txtKetQua.Clear();

            if (isAdvancedMode)
            {
                this.Text = "Bài 03 - Đọc số nâng cao (12 chữ số)";
                label1.Text = "ĐỌC SỐ NGUYÊN NÂNG CAO";
                label2.Text = "Nhập số nguyên (tối đa 12 chữ số):";

                btnChuyenCheDo.Text = "🔄 Về chế độ cơ bản (0 - 9)";
                btnChuyenCheDo.BackColor = Color.FromArgb(254, 243, 199); 
                btnChuyenCheDo.ForeColor = Color.FromArgb(180, 83, 9);   
                btnChuyenCheDo.FlatAppearance.BorderColor = Color.FromArgb(252, 211, 77);
            }
            else
            {
                this.Text = "Bài 03 - Đọc số nguyên (0 - 9)";
                label1.Text = "ĐỌC SỐ NGUYÊN (0 - 9)";
                label2.Text = "Nhập vào số nguyên (0 - 9):";

                btnChuyenCheDo.Text = "⚡ Chuyển sang Nâng cao (12 số)";
                btnChuyenCheDo.BackColor = Color.FromArgb(204, 251, 241);
                btnChuyenCheDo.ForeColor = Color.FromArgb(15, 118, 110); 
                btnChuyenCheDo.FlatAppearance.BorderColor = Color.FromArgb(153, 246, 228);
            }
            txtSo.Focus();
        }
        private void btnDoc_Click(object sender, EventArgs e)
        {
            string input = txtSo.Text.Trim();

            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Vui lòng nhập số cần đọc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSo.Focus();
                return;
            }
            if (!isAdvancedMode)
            {
                if (!int.TryParse(input, out int so) || so < 0 || so > 9)
                {
                    MessageBox.Show("Vui lòng chỉ nhập số nguyên từ 0 đến 9!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSo.Focus();
                    txtSo.SelectAll();
                    return;
                }

                string chu = "";
                switch (so)
                {
                    case 0: chu = "Không"; break;
                    case 1: chu = "Một"; break;
                    case 2: chu = "Hai"; break;
                    case 3: chu = "Ba"; break;
                    case 4: chu = "Bốn"; break;
                    case 5: chu = "Năm"; break;
                    case 6: chu = "Sáu"; break;
                    case 7: chu = "Bảy"; break;
                    case 8: chu = "Tám"; break;
                    case 9: chu = "Chín"; break;
                }
                txtKetQua.Text = chu;
            }
            else
            {
                if (!long.TryParse(input, out long so) || so < 0)
                {
                    MessageBox.Show("Vui lòng chỉ nhập số nguyên không âm hợp lệ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSo.Focus();
                    txtSo.SelectAll();
                    return;
                }

                if (input.Length > 12)
                {
                    MessageBox.Show("Số nhập vào tối đa 12 chữ số!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSo.Focus();
                    txtSo.SelectAll();
                    return;
                }

                txtKetQua.Text = DocSo12ChuSo(so);
            }
        }
        private string DocCum3So(long so, bool dayDu)
        {
            string[] chuSo = { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
            long tram = so / 100;
            long chuc = (so % 100) / 10;
            long donvi = so % 10;
            List<string> kq = new List<string>();
            if (dayDu || tram > 0)
            {
                kq.Add(chuSo[tram] + " trăm");
                if (chuc == 0 && donvi != 0) kq.Add("lẻ");
            }
            if (chuc == 1)
            {
                kq.Add("mười");
            }
            else if (chuc > 1)
            {
                kq.Add(chuSo[chuc] + " mươi");
            }

            if (chuc == 0)
            {
                if (donvi > 0) kq.Add(chuSo[donvi]);
            }
            else if (chuc == 1)
            {
                if (donvi == 1) kq.Add("một");
                else if (donvi == 5) kq.Add("lăm");
                else if (donvi > 0) kq.Add(chuSo[donvi]);
            }
            else
            {
                if (donvi == 1) kq.Add("mốt");
                else if (donvi == 5) kq.Add("lăm");
                else if (donvi > 0) kq.Add(chuSo[donvi]);
            }

            return string.Join(" ", kq);
        }

        private string DocSo12ChuSo(long n)
        {
            if (n == 0) return "Không";

            long ty = (n / 1000000000) % 1000;
            long trieu = (n / 1000000) % 1000;
            long ngan = (n / 1000) % 1000;
            long donvi = n % 1000;

            List<string> parts = new List<string>();
            bool hasPrev = false;

            if (ty > 0) { parts.Add(DocCum3So(ty, false) + " tỷ"); hasPrev = true; }
            if (trieu > 0) { parts.Add(DocCum3So(trieu, hasPrev) + " triệu"); hasPrev = true; }
            if (ngan > 0) { parts.Add(DocCum3So(ngan, hasPrev) + " ngàn"); hasPrev = true; }
            if (donvi > 0) { parts.Add(DocCum3So(donvi, hasPrev)); }

            string res = string.Join(", ", parts);
            return char.ToUpper(res[0]) + res.Substring(1);
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtSo.Clear();
            txtKetQua.Clear();
            txtSo.Focus();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}