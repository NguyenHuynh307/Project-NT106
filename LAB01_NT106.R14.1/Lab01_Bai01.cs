using System;
using System.Windows.Forms;

namespace Lab01
{
    public partial class Lab01_Bai01 : Form
    {
        public Lab01_Bai01()
        {
            InitializeComponent();
        }
        private void btnTinh_Click(object sender, EventArgs e)
        {
            int num1, num2;
            if (!int.TryParse(txtSo1.Text.Trim(), out num1))
            {
                MessageBox.Show("Vui lòng nhập số nguyên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSo1.Focus();
                txtSo1.SelectAll();
                return;
            }
            if (!int.TryParse(txtSo2.Text.Trim(), out num2))
            {
                MessageBox.Show("Vui lòng nhập số nguyên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSo2.Focus();
                txtSo2.SelectAll();
                return;
            }
            long tong = (long)num1 + num2;
            txtKetQua.Text = tong.ToString();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtSo1.Clear();
            txtSo2.Clear();
            txtKetQua.Clear();
            txtSo1.Focus();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}