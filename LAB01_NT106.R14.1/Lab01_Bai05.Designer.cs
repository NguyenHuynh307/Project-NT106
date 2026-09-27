namespace Lab01
{
    partial class Lab01_Bai05
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
            lblA = new Label();
            txtA = new TextBox();
            lblB = new Label();
            txtB = new TextBox();
            cboChoice = new ComboBox();
            btnCalculate = new Button();
            btnClear = new Button();
            btnExit = new Button();
            lblResult = new Label();
            rtbResult = new RichTextBox();
            SuspendLayout();
            // 
            // lblA
            // 
            lblA.AutoSize = true;
            lblA.Font = new Font("Segoe UI", 10F);
            lblA.Location = new Point(75, 55);
            lblA.Margin = new Padding(4, 0, 4, 0);
            lblA.Name = "lblA";
            lblA.Size = new Size(78, 28);
            lblA.TabIndex = 0;
            lblA.Text = "Nhập A";
            // 
            // txtA
            // 
            txtA.Font = new Font("Segoe UI", 10F);
            txtA.Location = new Point(175, 50);
            txtA.Margin = new Padding(4, 5, 4, 5);
            txtA.Name = "txtA";
            txtA.Size = new Size(186, 34);
            txtA.TabIndex = 1;
            // 
            // lblB
            // 
            lblB.AutoSize = true;
            lblB.Font = new Font("Segoe UI", 10F);
            lblB.Location = new Point(450, 55);
            lblB.Margin = new Padding(4, 0, 4, 0);
            lblB.Name = "lblB";
            lblB.Size = new Size(76, 28);
            lblB.TabIndex = 2;
            lblB.Text = "Nhập B";
            // 
            // txtB
            // 
            txtB.Font = new Font("Segoe UI", 10F);
            txtB.Location = new Point(550, 50);
            txtB.Margin = new Padding(4, 5, 4, 5);
            txtB.Name = "txtB";
            txtB.Size = new Size(186, 34);
            txtB.TabIndex = 3;
            // 
            // cboChoice
            // 
            cboChoice.DropDownStyle = ComboBoxStyle.DropDownList;
            cboChoice.Font = new Font("Segoe UI", 10F);
            cboChoice.FormattingEnabled = true;
            cboChoice.Items.AddRange(new object[] { "Bảng cửu chương", "Tính toán giá trị" });
            cboChoice.Location = new Point(269, 125);
            cboChoice.Margin = new Padding(4, 5, 4, 5);
            cboChoice.Name = "cboChoice";
            cboChoice.Size = new Size(274, 36);
            cboChoice.TabIndex = 4;
            // 
            // btnCalculate
            // 
            btnCalculate.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCalculate.Location = new Point(75, 203);
            btnCalculate.Margin = new Padding(4, 5, 4, 5);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(200, 59);
            btnCalculate.TabIndex = 5;
            btnCalculate.Text = "Tính các giá trị";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnClear.Location = new Point(331, 203);
            btnClear.Margin = new Padding(4, 5, 4, 5);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(150, 59);
            btnClear.TabIndex = 6;
            btnClear.Text = "Xóa";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnExit.Location = new Point(538, 203);
            btnExit.Margin = new Padding(4, 5, 4, 5);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(200, 59);
            btnExit.TabIndex = 7;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblResult.Location = new Point(75, 297);
            lblResult.Margin = new Padding(4, 0, 4, 0);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(97, 28);
            lblResult.TabIndex = 8;
            lblResult.Text = "KẾT QUẢ";
            // 
            // rtbResult
            // 
            rtbResult.BackColor = Color.White;
            rtbResult.Font = new Font("Consolas", 10F);
            rtbResult.Location = new Point(75, 344);
            rtbResult.Margin = new Padding(4, 5, 4, 5);
            rtbResult.Name = "rtbResult";
            rtbResult.ReadOnly = true;
            rtbResult.Size = new Size(662, 326);
            rtbResult.TabIndex = 9;
            rtbResult.Text = "";
            // 
            // Lab01_Bai05
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(812, 719);
            Controls.Add(rtbResult);
            Controls.Add(lblResult);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnCalculate);
            Controls.Add(cboChoice);
            Controls.Add(txtB);
            Controls.Add(lblB);
            Controls.Add(txtA);
            Controls.Add(lblA);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "Lab01_Bai05";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bài 05 - Bảng cửu chương & Tính toán giá trị";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.ComboBox cboChoice;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.RichTextBox rtbResult;
    }
}