namespace Lab01
{
    partial class Lab01_Bai06
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
            lblTitle = new Label();
            lblBirthDate = new Label();
            dtpBirthDate = new DateTimePicker();
            btnCheck = new Button();
            btnClear = new Button();
            btnExit = new Button();
            lblResult = new Label();
            rtbResult = new RichTextBox();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.DarkSlateBlue;
            lblTitle.Location = new Point(181, 31);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(407, 38);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "TRA CỨU CUNG HOÀNG ĐẠO";
            // 
            // lblBirthDate
            // 
            lblBirthDate.AutoSize = true;
            lblBirthDate.Font = new Font("Segoe UI", 10F);
            lblBirthDate.Location = new Point(62, 117);
            lblBirthDate.Margin = new Padding(4, 0, 4, 0);
            lblBirthDate.Name = "lblBirthDate";
            lblBirthDate.Size = new Size(209, 28);
            lblBirthDate.TabIndex = 1;
            lblBirthDate.Text = "Chọn ngày tháng năm:";
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.CustomFormat = "dd/MM/yyyy";
            dtpBirthDate.Font = new Font("Segoe UI", 10F);
            dtpBirthDate.Format = DateTimePickerFormat.Custom;
            dtpBirthDate.Location = new Point(306, 111);
            dtpBirthDate.Margin = new Padding(4, 5, 4, 5);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(224, 34);
            dtpBirthDate.TabIndex = 2;
            // 
            // btnCheck
            // 
            btnCheck.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCheck.Location = new Point(62, 188);
            btnCheck.Margin = new Padding(4, 5, 4, 5);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(200, 59);
            btnCheck.TabIndex = 3;
            btnCheck.Text = "Xem kết quả";
            btnCheck.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnClear.Location = new Point(306, 188);
            btnClear.Margin = new Padding(4, 5, 4, 5);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(175, 59);
            btnClear.TabIndex = 4;
            btnClear.Text = "Làm mới";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnExit.Location = new Point(525, 188);
            btnExit.Margin = new Padding(4, 5, 4, 5);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(212, 59);
            btnExit.TabIndex = 5;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblResult.Location = new Point(62, 273);
            lblResult.Margin = new Padding(4, 0, 4, 0);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(183, 28);
            lblResult.TabIndex = 6;
            lblResult.Text = "KẾT QUẢ CHI TIẾT";
            // 
            // rtbResult
            // 
            rtbResult.BackColor = Color.White;
            rtbResult.Font = new Font("Consolas", 10F);
            rtbResult.Location = new Point(62, 320);
            rtbResult.Margin = new Padding(4, 5, 4, 5);
            rtbResult.Name = "rtbResult";
            rtbResult.ReadOnly = true;
            rtbResult.Size = new Size(674, 373);
            rtbResult.TabIndex = 7;
            rtbResult.Text = "";
            // 
            // Lab01_Bai06
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 750);
            Controls.Add(rtbResult);
            Controls.Add(lblResult);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnCheck);
            Controls.Add(dtpBirthDate);
            Controls.Add(lblBirthDate);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "Lab01_Bai06";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bài 06 - Tra cứu Cung hoàng đạo & Tính cách";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.RichTextBox rtbResult;
    }
}