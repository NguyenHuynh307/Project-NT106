using System;
using System.Windows.Forms;

namespace Lab01
{
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
        }

        private void btnBai01_Click(object sender, EventArgs e)
        {
            Lab01_Bai01 bai1 = new Lab01_Bai01();
            bai1.Show();
        }


        private void btnBai02_Click(object sender, EventArgs e)
        {
            Lab01_Bai02 bai2 = new Lab01_Bai02();
            bai2.Show();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBai03_Click(object sender, EventArgs e)
        {
            Lab01_Bai03 bai3 = new Lab01_Bai03();
            bai3.Show();
        }

        private void btnBai04_Click(object sender, EventArgs e)
        {
            Lab01_Bai04 formBai4 = new Lab01_Bai04();
            formBai4.ShowDialog();
        }

        private void btnBai05_Click(object sender, EventArgs e)
        {
            Lab01_Bai05 formBai05 = new Lab01_Bai05();
            formBai05.Show();
        }

        private void btnBai06_Click(object sender, EventArgs e)
        {
            Lab01_Bai06 formBai06 = new Lab01_Bai06();
            formBai06.Show();
        }

        private void btnBai07_Click(object sender, EventArgs e)
        {
            Lab01_Bai07 formBai07 = new Lab01_Bai07();
            formBai07.Show();
        }

        private void btnBai08_Click(object sender, EventArgs e)
        {
            Lab01_Bai08 formBai08 = new Lab01_Bai08();
            formBai08.Show();
        }
    }
}