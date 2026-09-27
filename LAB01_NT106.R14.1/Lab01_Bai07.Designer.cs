namespace Lab01
{
    partial class Lab01_Bai07
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
            lblInput = new Label();
            txtInput = new TextBox();
            btnProcess = new Button();
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
            lblTitle.Location = new Point(156, 31);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(596, 38);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "QUẢN LÝ VÀ XỬ LÝ MẢNG ĐIỂM SINH VIÊN";
            // 
            // lblInput
            // 
            lblInput.AutoSize = true;
            lblInput.Font = new Font("Segoe UI", 10F);
            lblInput.Location = new Point(56, 117);
            lblInput.Margin = new Padding(4, 0, 4, 0);
            lblInput.Name = "lblInput";
            lblInput.Size = new Size(475, 28);
            lblInput.TabIndex = 1;
            lblInput.Text = "Nhập thông tin (Họ tên, điểm môn 1, điểm môn 2, ...):";
            // 
            // txtInput
            // 
            txtInput.Font = new Font("Segoe UI", 10F);
            txtInput.Location = new Point(56, 164);
            txtInput.Margin = new Padding(4, 5, 4, 5);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(786, 34);
            txtInput.TabIndex = 2;
            txtInput.Text = "Nguyễn Thị A, 7.5, 5, 8, 10, 9, 10, 8.5, 9, 10, 3.5, 5.5, 2";
            // 
            // btnProcess
            // 
            btnProcess.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnProcess.Location = new Point(56, 234);
            btnProcess.Margin = new Padding(4, 5, 4, 5);
            btnProcess.Name = "btnProcess";
            btnProcess.Size = new Size(262, 59);
            btnProcess.TabIndex = 3;
            btnProcess.Text = "Xử lý & Xuất kết quả";
            btnProcess.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnClear.Location = new Point(369, 234);
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
            btnExit.Location = new Point(594, 234);
            btnExit.Margin = new Padding(4, 5, 4, 5);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(250, 59);
            btnExit.TabIndex = 5;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblResult.Location = new Point(56, 320);
            lblResult.Margin = new Padding(4, 0, 4, 0);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(296, 28);
            lblResult.TabIndex = 6;
            lblResult.Text = "KẾT QUẢ THỐNG KÊ CHI TIẾT:";
            // 
            // rtbResult
            // 
            rtbResult.BackColor = Color.White;
            rtbResult.Font = new Font("Consolas", 10F);
            rtbResult.Location = new Point(56, 367);
            rtbResult.Margin = new Padding(4, 5, 4, 5);
            rtbResult.Name = "rtbResult";
            rtbResult.ReadOnly = true;
            rtbResult.Size = new Size(786, 404);
            rtbResult.TabIndex = 7;
            rtbResult.Text = "";
            // 
            // Lab01_Bai07
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 844);
            Controls.Add(rtbResult);
            Controls.Add(lblResult);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnProcess);
            Controls.Add(txtInput);
            Controls.Add(lblInput);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "Lab01_Bai07";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bài 07 - Xử lý mảng điểm sinh viên";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.RichTextBox rtbResult;
    }
}