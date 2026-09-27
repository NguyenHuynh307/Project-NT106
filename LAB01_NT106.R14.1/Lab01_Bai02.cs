using System;
using System.Windows.Forms;

namespace Lab01
{
    public partial class Lab01_Bai02 : Form
    {
        public Lab01_Bai02()
        {
            InitializeComponent();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            double num1, num2, num3;

            if (!double.TryParse(txtSo1.Text.Trim(), out num1))
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ ở ô thứ nhất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSo1.Focus();
                txtSo1.SelectAll();
                return;
            }

            if (!double.TryParse(txtSo2.Text.Trim(), out num2))
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ ở ô thứ hai!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSo2.Focus();
                txtSo2.SelectAll();
                return;
            }

            if (!double.TryParse(txtSo3.Text.Trim(), out num3))
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ ở ô thứ ba!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSo3.Focus();
                txtSo3.SelectAll();
                return;
            }
            double max = Math.Max(num1, Math.Max(num2, num3));
            double min = Math.Min(num1, Math.Min(num2, num3));

            txtMax.Text = max.ToString();
            txtMin.Text = min.ToString();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtSo1.Clear();
            txtSo2.Clear();
            txtSo3.Clear();
            txtMax.Clear();
            txtMin.Clear();
            txtSo1.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}