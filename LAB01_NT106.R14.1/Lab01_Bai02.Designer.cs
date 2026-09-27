namespace Lab01
{
    partial class Lab01_Bai02
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
            btnTim = new Button();
            label2 = new Label();
            label3 = new Label();
            btnXoa = new Button();
            label4 = new Label();
            btnThoat = new Button();
            txtSo1 = new TextBox();
            txtSo2 = new TextBox();
            txtSo3 = new TextBox();
            label5 = new Label();
            txtMax = new TextBox();
            txtMin = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(15, 23, 42);
            label1.Location = new Point(163, 32);
            label1.Name = "label1";
            label1.Size = new Size(593, 45);
            label1.TabIndex = 0;
            label1.Text = "TÌM SỐ LỚN NHẤT VÀ SỐ NHỎ NHẤT";
            // 
            // btnTim
            // 
            btnTim.BackColor = Color.FromArgb(13, 110, 253);
            btnTim.Cursor = Cursors.Hand;
            btnTim.FlatAppearance.BorderSize = 0;
            btnTim.FlatStyle = FlatStyle.Flat;
            btnTim.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTim.ForeColor = Color.White;
            btnTim.Location = new Point(73, 247);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(130, 38);
            btnTim.TabIndex = 1;
            btnTim.Text = "Tìm";
            btnTim.UseVisualStyleBackColor = false;
            btnTim.Click += btnTim_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(18, 115);
            label2.Name = "label2";
            label2.Size = new Size(128, 28);
            label2.TabIndex = 2;
            label2.Text = "Số thứ nhất:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(371, 115);
            label3.Name = "label3";
            label3.Size = new Size(114, 28);
            label3.TabIndex = 4;
            label3.Text = "Số thứ hai:";
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(254, 242, 242);
            btnXoa.Cursor = Cursors.Hand;
            btnXoa.FlatAppearance.BorderColor = Color.FromArgb(254, 202, 202);
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoa.ForeColor = Color.FromArgb(220, 38, 38);
            btnXoa.Location = new Point(400, 251);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(110, 38);
            btnXoa.TabIndex = 3;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(709, 115);
            label4.Name = "label4";
            label4.Size = new Size(108, 28);
            label4.TabIndex = 6;
            label4.Text = "Số thứ ba:";
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.FromArgb(241, 245, 249);
            btnThoat.Cursor = Cursors.Hand;
            btnThoat.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.ForeColor = Color.FromArgb(51, 65, 85);
            btnThoat.Location = new Point(667, 253);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(110, 38);
            btnThoat.TabIndex = 5;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // txtSo1
            // 
            txtSo1.Location = new Point(150, 109);
            txtSo1.Name = "txtSo1";
            txtSo1.Size = new Size(180, 34);
            txtSo1.TabIndex = 7;
            // 
            // txtSo2
            // 
            txtSo2.Location = new Point(489, 112);
            txtSo2.Name = "txtSo2";
            txtSo2.Size = new Size(180, 34);
            txtSo2.TabIndex = 8;
            // 
            // txtSo3
            // 
            txtSo3.Location = new Point(823, 112);
            txtSo3.Name = "txtSo3";
            txtSo3.Size = new Size(180, 34);
            txtSo3.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(4, 120, 87);
            label5.Location = new Point(54, 378);
            label5.Name = "label5";
            label5.Size = new Size(149, 28);
            label5.TabIndex = 10;
            label5.Text = "SỐ LỚN NHẤT";
            // 
            // txtMax
            // 
            txtMax.BackColor = Color.FromArgb(236, 253, 245);
            txtMax.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtMax.ForeColor = Color.FromArgb(4, 120, 87);
            txtMax.Location = new Point(220, 367);
            txtMax.Name = "txtMax";
            txtMax.ReadOnly = true;
            txtMax.Size = new Size(240, 39);
            txtMax.TabIndex = 11;
            txtMax.TextAlign = HorizontalAlignment.Center;
            // 
            // txtMin
            // 
            txtMin.BackColor = Color.FromArgb(254, 242, 242);
            txtMin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtMin.ForeColor = Color.FromArgb(185, 28, 28);
            txtMin.Location = new Point(783, 367);
            txtMin.Name = "txtMin";
            txtMin.ReadOnly = true;
            txtMin.Size = new Size(240, 39);
            txtMin.TabIndex = 13;
            txtMin.TextAlign = HorizontalAlignment.Center;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(185, 28, 28);
            label6.Location = new Point(624, 378);
            label6.Name = "label6";
            label6.Size = new Size(153, 28);
            label6.TabIndex = 12;
            label6.Text = "SỐ NHỎ NHẤT";
            // 
            // Lab01_Bai02
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 244, 249);
            ClientSize = new Size(1042, 504);
            Controls.Add(txtMin);
            Controls.Add(label6);
            Controls.Add(txtMax);
            Controls.Add(label5);
            Controls.Add(txtSo3);
            Controls.Add(txtSo2);
            Controls.Add(txtSo1);
            Controls.Add(label4);
            Controls.Add(btnThoat);
            Controls.Add(label3);
            Controls.Add(btnXoa);
            Controls.Add(label2);
            Controls.Add(btnTim);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Lab01_Bai02";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bài 02 - Tìm số lớn nhất, số nhỏ nhất";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnTim;
        private Label label2;
        private Label label3;
        private Button btnXoa;
        private Label label4;
        private Button btnThoat;
        private TextBox txtSo1;
        private TextBox txtSo2;
        private TextBox txtSo3;
        private Label label5;
        private TextBox txtMax;
        private TextBox txtMin;
        private Label label6;
    }
}