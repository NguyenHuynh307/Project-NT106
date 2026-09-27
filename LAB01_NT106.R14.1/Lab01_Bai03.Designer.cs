namespace Lab01
{
    partial class Lab01_Bai03
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
            btnDoc = new Button();
            label1 = new Label();
            txtSo = new TextBox();
            btnXoa = new Button();
            btnThoat = new Button();
            label2 = new Label();
            txtKetQua = new TextBox();
            label3 = new Label();
            btnChuyenCheDo = new Button();
            SuspendLayout();
            // 
            // btnDoc
            // 
            btnDoc.BackColor = Color.FromArgb(13, 110, 253);
            btnDoc.Cursor = Cursors.Hand;
            btnDoc.FlatAppearance.BorderSize = 0;
            btnDoc.FlatStyle = FlatStyle.Flat;
            btnDoc.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDoc.ForeColor = Color.White;
            btnDoc.Location = new Point(708, 94);
            btnDoc.Name = "btnDoc";
            btnDoc.Size = new Size(140, 71);
            btnDoc.TabIndex = 0;
            btnDoc.Text = "Đọc";
            btnDoc.UseVisualStyleBackColor = false;
            btnDoc.Click += btnDoc_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(71, 85, 105);
            label1.Location = new Point(12, 103);
            label1.Name = "label1";
            label1.Size = new Size(275, 28);
            label1.TabIndex = 1;
            label1.Text = "Nhập vào số nguyên (0 - 9):";
            // 
            // txtSo
            // 
            txtSo.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSo.Location = new Point(293, 94);
            txtSo.Name = "txtSo";
            txtSo.Size = new Size(220, 37);
            txtSo.TabIndex = 2;
            txtSo.TextAlign = HorizontalAlignment.Center;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(254, 242, 242);
            btnXoa.Cursor = Cursors.Hand;
            btnXoa.FlatAppearance.BorderColor = Color.FromArgb(254, 202, 202);
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoa.ForeColor = Color.FromArgb(220, 38, 38);
            btnXoa.Location = new Point(708, 248);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(140, 71);
            btnXoa.TabIndex = 3;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.FromArgb(243, 232, 255);
            btnThoat.Cursor = Cursors.Hand;
            btnThoat.FlatAppearance.BorderColor = Color.FromArgb(216, 180, 254);
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.ForeColor = Color.FromArgb(126, 34, 206);
            btnThoat.Location = new Point(910, 248);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(140, 71);
            btnThoat.TabIndex = 4;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(13, 110, 253);
            label2.Location = new Point(12, 218);
            label2.Name = "label2";
            label2.Size = new Size(182, 28);
            label2.TabIndex = 5;
            label2.Text = "KẾT QUẢ ĐỌC SỐ:";
            // 
            // txtKetQua
            // 
            txtKetQua.BackColor = Color.FromArgb(239, 246, 255);
            txtKetQua.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtKetQua.ForeColor = Color.FromArgb(29, 78, 216);
            txtKetQua.Location = new Point(12, 249);
            txtKetQua.Multiline = true;
            txtKetQua.Name = "txtKetQua";
            txtKetQua.ReadOnly = true;
            txtKetQua.Size = new Size(500, 84);
            txtKetQua.TabIndex = 6;
            txtKetQua.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(15, 23, 42);
            label3.Location = new Point(412, 18);
            label3.Name = "label3";
            label3.Size = new Size(380, 45);
            label3.TabIndex = 7;
            label3.Text = "ĐỌC SỐ NGUYÊN (0 - 9)";
            // 
            // btnChuyenCheDo
            // 
            btnChuyenCheDo.BackColor = Color.FromArgb(204, 251, 241);
            btnChuyenCheDo.Cursor = Cursors.Hand;
            btnChuyenCheDo.FlatAppearance.BorderColor = Color.FromArgb(153, 246, 228);
            btnChuyenCheDo.FlatStyle = FlatStyle.Flat;
            btnChuyenCheDo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnChuyenCheDo.ForeColor = Color.FromArgb(15, 118, 110);
            btnChuyenCheDo.Location = new Point(910, 94);
            btnChuyenCheDo.Name = "btnChuyenCheDo";
            btnChuyenCheDo.Size = new Size(140, 71);
            btnChuyenCheDo.TabIndex = 8;
            btnChuyenCheDo.Text = "⚡Nâng cao (12 số)";
            btnChuyenCheDo.UseVisualStyleBackColor = false;
            btnChuyenCheDo.Click += btnChuyenCheDo_Click;
            // 
            // Lab01_Bai03
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 244, 249);
            ClientSize = new Size(1148, 415);
            Controls.Add(btnChuyenCheDo);
            Controls.Add(label3);
            Controls.Add(txtKetQua);
            Controls.Add(label2);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(txtSo);
            Controls.Add(label1);
            Controls.Add(btnDoc);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Lab01_Bai03";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bài 03 - Đọc số nguyên";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDoc;
        private Label label1;
        private TextBox txtSo;
        private Button btnXoa;
        private Button btnThoat;
        private Label label2;
        private TextBox txtKetQua;
        private Label label3;
        private Button btnChuyenCheDo;
    }
}