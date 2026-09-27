namespace Lab01
{
    partial class Lab01_Bai01
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtSo1 = new TextBox();
            label2 = new Label();
            txtSo2 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtKetQua = new TextBox();
            btnTinh = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.ForeColor = Color.FromArgb(15, 23, 42);
            label1.Location = new Point(258, 34);
            label1.Name = "label1";
            label1.Size = new Size(418, 45);
            label1.TabIndex = 0;
            label1.Text = "TÍNH TỔNG 2 SỐ NGUYÊN";
            // 
            // txtSo1
            // 
            txtSo1.BackColor = Color.White;
            txtSo1.BorderStyle = BorderStyle.FixedSingle;
            txtSo1.Font = new Font("Segoe UI", 11F);
            txtSo1.Location = new Point(258, 158);
            txtSo1.Name = "txtSo1";
            txtSo1.Size = new Size(165, 37);
            txtSo1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(71, 85, 105);
            label2.Location = new Point(258, 115);
            label2.Name = "label2";
            label2.Size = new Size(92, 28);
            label2.TabIndex = 2;
            label2.Text = "Số thứ 1";
            // 
            // txtSo2
            // 
            txtSo2.BackColor = Color.White;
            txtSo2.BorderStyle = BorderStyle.FixedSingle;
            txtSo2.Font = new Font("Segoe UI", 11F);
            txtSo2.Location = new Point(548, 158);
            txtSo2.Name = "txtSo2";
            txtSo2.Size = new Size(165, 37);
            txtSo2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(71, 85, 105);
            label3.Location = new Point(548, 115);
            label3.Name = "label3";
            label3.Size = new Size(92, 28);
            label3.TabIndex = 4;
            label3.Text = "Số thứ 2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(258, 334);
            label4.Name = "label4";
            label4.Size = new Size(85, 28);
            label4.TabIndex = 5;
            label4.Text = "Kết quả";
            // 
            // txtKetQua
            // 
            txtKetQua.BackColor = Color.FromArgb(236, 253, 245);
            txtKetQua.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtKetQua.ForeColor = Color.FromArgb(5, 150, 105);
            txtKetQua.Location = new Point(258, 384);
            txtKetQua.Name = "txtKetQua";
            txtKetQua.ReadOnly = true;
            txtKetQua.Size = new Size(455, 45);
            txtKetQua.TabIndex = 6;
            txtKetQua.TextAlign = HorizontalAlignment.Center;
            // 
            // btnTinh
            // 
            btnTinh.BackColor = Color.FromArgb(13, 110, 253);
            btnTinh.FlatAppearance.BorderSize = 0;
            btnTinh.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTinh.ForeColor = Color.White;
            btnTinh.Location = new Point(422, 245);
            btnTinh.Name = "btnTinh";
            btnTinh.Size = new Size(123, 60);
            btnTinh.TabIndex = 7;
            btnTinh.Text = "Tính";
            btnTinh.UseVisualStyleBackColor = false;
            btnTinh.Click += btnTinh_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(254, 242, 242);
            btnXoa.FlatAppearance.BorderColor = Color.FromArgb(254, 202, 202);
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoa.ForeColor = Color.FromArgb(220, 38, 38);
            btnXoa.Location = new Point(258, 454);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(130, 51);
            btnXoa.TabIndex = 8;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.FromArgb(254, 242, 242);
            btnThoat.Cursor = Cursors.Hand;
            btnThoat.FlatAppearance.BorderColor = Color.FromArgb(254, 202, 202);
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThoat.ForeColor = Color.FromArgb(220, 38, 38);
            btnThoat.Location = new Point(548, 454);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(128, 51);
            btnThoat.TabIndex = 9;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // Lab01_Bai01
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 244, 249);
            ClientSize = new Size(875, 620);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(btnTinh);
            Controls.Add(txtKetQua);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtSo2);
            Controls.Add(label2);
            Controls.Add(txtSo1);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 10F);
            ForeColor = Color.FromArgb(15, 23, 42);
            Name = "Lab01_Bai01";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bài 01 - Tính tổng 2 số nguyên";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSo1;
        private Label label2;
        private TextBox txtSo2;
        private Label label3;
        private Label label4;
        private TextBox txtKetQua;
        private Button btnTinh;
        private Button btnXoa;
        private Button btnThoat;
    }
}