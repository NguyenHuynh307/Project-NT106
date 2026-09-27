namespace Lab01
{
    partial class Lab01_Bai04
    {

        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            cboMovie = new ComboBox();
            lblHeader = new Label();
            lblName = new Label();
            txtName = new TextBox();
            lblMovie = new Label();
            lblRoom = new Label();
            cboRoom = new ComboBox();
            lblPriceTag = new Label();
            pnlInfoCard = new Panel();
            cboShowtime = new ComboBox();
            lblShowtime = new Label();
            pnlSeatCard = new Panel();
            pnlInvoiceCard = new Panel();
            btnReset = new Button();
            lblInvoiceTitle = new Label();
            btnExit = new Button();
            btnBook = new Button();
            txtInvoice = new TextBox();
            lblLegendChuan = new Label();
            lblLegendVot = new Label();
            lblLegendVip = new Label();
            lblLegendSelected = new Label();
            pnlSeatMatrix = new Panel();
            lblScreen = new Label();
            pnlInfoCard.SuspendLayout();
            pnlSeatCard.SuspendLayout();
            pnlInvoiceCard.SuspendLayout();
            SuspendLayout();
            // 
            // cboMovie
            // 
            cboMovie.BackColor = Color.FromArgb(8, 15, 30);
            cboMovie.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMovie.FlatStyle = FlatStyle.Flat;
            cboMovie.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboMovie.ForeColor = Color.White;
            cboMovie.FormattingEnabled = true;
            cboMovie.Location = new Point(20, 218);
            cboMovie.Name = "cboMovie";
            cboMovie.Size = new Size(395, 36);
            cboMovie.TabIndex = 1;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.BackColor = Color.FromArgb(15, 23, 42);
            lblHeader.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeader.ForeColor = Color.FromArgb(245, 158, 11);
            lblHeader.Location = new Point(6, 3);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(432, 32);
            lblHeader.TabIndex = 2;
            lblHeader.Text = "HỆ THỐNG ĐẶT VÉ CINEMA LUXURY";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BackColor = Color.FromArgb(15, 23, 42);
            lblName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.ForeColor = Color.FromArgb(203, 213, 225);
            lblName.Location = new Point(20, 70);
            lblName.Name = "lblName";
            lblName.Size = new Size(237, 28);
            lblName.TabIndex = 3;
            lblName.Text = "👤 Họ và tên khách hàng:";
            // 
            // txtName
            // 
            txtName.BackColor = Color.FromArgb(8, 15, 30);
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.ForeColor = Color.White;
            txtName.Location = new Point(20, 112);
            txtName.Name = "txtName";
            txtName.Size = new Size(395, 34);
            txtName.TabIndex = 4;
            // 
            // lblMovie
            // 
            lblMovie.AutoSize = true;
            lblMovie.BackColor = Color.FromArgb(15, 23, 42);
            lblMovie.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMovie.ForeColor = Color.FromArgb(203, 213, 225);
            lblMovie.Location = new Point(20, 173);
            lblMovie.Name = "lblMovie";
            lblMovie.Size = new Size(177, 28);
            lblMovie.TabIndex = 5;
            lblMovie.Text = "🎞 Chọn tên phim:";
            // 
            // lblRoom
            // 
            lblRoom.AutoSize = true;
            lblRoom.BackColor = Color.FromArgb(15, 23, 42);
            lblRoom.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRoom.ForeColor = Color.FromArgb(203, 213, 225);
            lblRoom.Location = new Point(20, 284);
            lblRoom.Name = "lblRoom";
            lblRoom.Size = new Size(156, 28);
            lblRoom.TabIndex = 6;
            lblRoom.Text = "💺 Phòng chiếu:";
            // 
            // cboRoom
            // 
            cboRoom.BackColor = Color.FromArgb(8, 15, 30);
            cboRoom.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRoom.FlatStyle = FlatStyle.Flat;
            cboRoom.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboRoom.ForeColor = Color.White;
            cboRoom.FormattingEnabled = true;
            cboRoom.Location = new Point(20, 329);
            cboRoom.Name = "cboRoom";
            cboRoom.Size = new Size(395, 36);
            cboRoom.TabIndex = 7;
            // 
            // lblPriceTag
            // 
            lblPriceTag.AutoSize = true;
            lblPriceTag.BackColor = Color.FromArgb(8, 40, 80);
            lblPriceTag.BorderStyle = BorderStyle.FixedSingle;
            lblPriceTag.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPriceTag.ForeColor = Color.FromArgb(0, 229, 255);
            lblPriceTag.Location = new Point(101, 507);
            lblPriceTag.Name = "lblPriceTag";
            lblPriceTag.Size = new Size(235, 32);
            lblPriceTag.TabIndex = 8;
            lblPriceTag.Text = "🎟  Giá vé chuẩn: 0 đ";
            lblPriceTag.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlInfoCard
            // 
            pnlInfoCard.BackColor = Color.FromArgb(13, 27, 56);
            pnlInfoCard.Controls.Add(cboShowtime);
            pnlInfoCard.Controls.Add(lblShowtime);
            pnlInfoCard.Controls.Add(lblPriceTag);
            pnlInfoCard.Controls.Add(lblMovie);
            pnlInfoCard.Controls.Add(lblRoom);
            pnlInfoCard.Controls.Add(cboMovie);
            pnlInfoCard.Controls.Add(cboRoom);
            pnlInfoCard.Controls.Add(lblHeader);
            pnlInfoCard.Controls.Add(lblName);
            pnlInfoCard.Controls.Add(txtName);
            pnlInfoCard.Location = new Point(5, 20);
            pnlInfoCard.Name = "pnlInfoCard";
            pnlInfoCard.Size = new Size(444, 543);
            pnlInfoCard.TabIndex = 9;
            // 
            // cboShowtime
            // 
            cboShowtime.BackColor = Color.FromArgb(8, 15, 30);
            cboShowtime.DropDownStyle = ComboBoxStyle.DropDownList;
            cboShowtime.FlatStyle = FlatStyle.Flat;
            cboShowtime.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboShowtime.ForeColor = Color.White;
            cboShowtime.FormattingEnabled = true;
            cboShowtime.Location = new Point(20, 434);
            cboShowtime.Name = "cboShowtime";
            cboShowtime.Size = new Size(390, 36);
            cboShowtime.TabIndex = 10;
            // 
            // lblShowtime
            // 
            lblShowtime.AutoSize = true;
            lblShowtime.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblShowtime.ForeColor = Color.FromArgb(203, 213, 225);
            lblShowtime.Location = new Point(20, 392);
            lblShowtime.Name = "lblShowtime";
            lblShowtime.Size = new Size(138, 28);
            lblShowtime.TabIndex = 9;
            lblShowtime.Text = "⏰ Suất chiếu:";
            // 
            // pnlSeatCard
            // 
            pnlSeatCard.BackColor = Color.FromArgb(13, 27, 56);
            pnlSeatCard.Controls.Add(pnlInvoiceCard);
            pnlSeatCard.Controls.Add(lblLegendChuan);
            pnlSeatCard.Controls.Add(lblLegendVot);
            pnlSeatCard.Controls.Add(lblLegendVip);
            pnlSeatCard.Controls.Add(lblLegendSelected);
            pnlSeatCard.Controls.Add(pnlSeatMatrix);
            pnlSeatCard.Controls.Add(lblScreen);
            pnlSeatCard.Location = new Point(449, 20);
            pnlSeatCard.Name = "pnlSeatCard";
            pnlSeatCard.Size = new Size(828, 543);
            pnlSeatCard.TabIndex = 10;
            // 
            // pnlInvoiceCard
            // 
            pnlInvoiceCard.Controls.Add(btnReset);
            pnlInvoiceCard.Controls.Add(lblInvoiceTitle);
            pnlInvoiceCard.Controls.Add(btnExit);
            pnlInvoiceCard.Controls.Add(btnBook);
            pnlInvoiceCard.Controls.Add(txtInvoice);
            pnlInvoiceCard.Location = new Point(434, 40);
            pnlInvoiceCard.Name = "pnlInvoiceCard";
            pnlInvoiceCard.Size = new Size(394, 503);
            pnlInvoiceCard.TabIndex = 4;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.FromArgb(51, 65, 85);
            btnReset.FlatAppearance.BorderSize = 0;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReset.ForeColor = Color.FromArgb(241, 245, 249);
            btnReset.Location = new Point(21, 439);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(148, 38);
            btnReset.TabIndex = 4;
            btnReset.Text = "LÀM MỚI";
            btnReset.UseVisualStyleBackColor = false;
            // 
            // lblInvoiceTitle
            // 
            lblInvoiceTitle.AutoSize = true;
            lblInvoiceTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInvoiceTitle.ForeColor = Color.FromArgb(245, 158, 11);
            lblInvoiceTitle.Location = new Point(21, 6);
            lblInvoiceTitle.Name = "lblInvoiceTitle";
            lblInvoiceTitle.Size = new Size(307, 30);
            lblInvoiceTitle.TabIndex = 0;
            lblInvoiceTitle.Text = "\U0001f9fe HÓA ĐƠN THANH TOÁN";
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(225, 29, 72);
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(180, 439);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(148, 38);
            btnExit.TabIndex = 3;
            btnExit.Text = "THOÁT";
            btnExit.UseVisualStyleBackColor = false;
            // 
            // btnBook
            // 
            btnBook.BackColor = Color.FromArgb(245, 158, 11);
            btnBook.FlatAppearance.BorderSize = 0;
            btnBook.FlatStyle = FlatStyle.Flat;
            btnBook.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBook.ForeColor = Color.Black;
            btnBook.Location = new Point(21, 363);
            btnBook.Name = "btnBook";
            btnBook.Size = new Size(305, 42);
            btnBook.TabIndex = 2;
            btnBook.Text = "XÁC NHẬN ĐẶT VÉ";
            btnBook.UseVisualStyleBackColor = false;
            btnBook.Click += btnBook_Click;
            // 
            // txtInvoice
            // 
            txtInvoice.BackColor = Color.FromArgb(11, 19, 43);
            txtInvoice.BorderStyle = BorderStyle.FixedSingle;
            txtInvoice.Font = new Font("Consolas", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtInvoice.ForeColor = Color.FromArgb(52, 211, 153);
            txtInvoice.Location = new Point(5, 47);
            txtInvoice.Multiline = true;
            txtInvoice.Name = "txtInvoice";
            txtInvoice.ReadOnly = true;
            txtInvoice.ScrollBars = ScrollBars.Vertical;
            txtInvoice.Size = new Size(384, 294);
            txtInvoice.TabIndex = 1;
            txtInvoice.WordWrap = false;
            // 
            // lblLegendChuan
            // 
            lblLegendChuan.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLegendChuan.ForeColor = Color.White;
            lblLegendChuan.Location = new Point(270, 504);
            lblLegendChuan.Name = "lblLegendChuan";
            lblLegendChuan.Size = new Size(145, 33);
            lblLegendChuan.TabIndex = 1;
            lblLegendChuan.Text = "■  Chuẩn (x1)";
            // 
            // lblLegendVot
            // 
            lblLegendVot.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLegendVot.ForeColor = Color.FromArgb(147, 197, 253);
            lblLegendVot.Location = new Point(25, 457);
            lblLegendVot.Name = "lblLegendVot";
            lblLegendVot.Size = new Size(168, 34);
            lblLegendVot.TabIndex = 0;
            lblLegendVot.Text = "■  Vớt (x1/4)";
            // 
            // lblLegendVip
            // 
            lblLegendVip.AutoSize = true;
            lblLegendVip.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLegendVip.ForeColor = Color.FromArgb(253, 224, 71);
            lblLegendVip.Location = new Point(270, 457);
            lblLegendVip.Name = "lblLegendVip";
            lblLegendVip.Size = new Size(140, 32);
            lblLegendVip.TabIndex = 2;
            lblLegendVip.Text = "■  VIP (x2)";
            // 
            // lblLegendSelected
            // 
            lblLegendSelected.AutoSize = true;
            lblLegendSelected.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLegendSelected.ForeColor = Color.FromArgb(251, 113, 133);
            lblLegendSelected.Location = new Point(25, 505);
            lblLegendSelected.Name = "lblLegendSelected";
            lblLegendSelected.Size = new Size(173, 32);
            lblLegendSelected.TabIndex = 3;
            lblLegendSelected.Text = "■  Đang chọn";
            // 
            // pnlSeatMatrix
            // 
            pnlSeatMatrix.BackColor = Color.Transparent;
            pnlSeatMatrix.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pnlSeatMatrix.Location = new Point(0, 40);
            pnlSeatMatrix.Name = "pnlSeatMatrix";
            pnlSeatMatrix.Size = new Size(435, 405);
            pnlSeatMatrix.TabIndex = 1;
            // 
            // lblScreen
            // 
            lblScreen.BackColor = Color.FromArgb(19, 42, 74);
            lblScreen.BorderStyle = BorderStyle.FixedSingle;
            lblScreen.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblScreen.ForeColor = Color.FromArgb(0, 242, 254);
            lblScreen.Location = new Point(0, 0);
            lblScreen.Name = "lblScreen";
            lblScreen.Size = new Size(435, 39);
            lblScreen.TabIndex = 0;
            lblScreen.Text = "MÀN HÌNH CHIẾU • SCREEN";
            lblScreen.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Lab01_Bai04
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(8, 15, 30);
            ClientSize = new Size(1284, 566);
            Controls.Add(pnlSeatCard);
            Controls.Add(pnlInfoCard);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Lab01_Bai04";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ROYAL CINEMA - QUẢN LÝ ĐẶT VÉ CAO CẤP";
            pnlInfoCard.ResumeLayout(false);
            pnlInfoCard.PerformLayout();
            pnlSeatCard.ResumeLayout(false);
            pnlSeatCard.PerformLayout();
            pnlInvoiceCard.ResumeLayout(false);
            pnlInvoiceCard.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblBrandTitle;
        private ComboBox cboMovie;
        private Label lblHeader;
        private Label lblName;
        private TextBox txtName;
        private Label lblMovie;
        private Label lblRoom;
        private ComboBox cboRoom;
        private Label lblPriceTag;
        private Panel pnlInfoCard;
        private Panel pnlSeatCard;
        private Label lblLegendSelected;
        private Label lblScreen;
        private Panel pnlSeatMatrix;
        private Label lblLegendVot;
        private Label lblLegendVip;
        private Label lblLegendChuan;
        private Panel pnlInvoiceCard;
        private TextBox txtInvoice;
        private Label lblInvoiceTitle;
        private Button btnReset;
        private Button btnExit;
        private Button btnBook;
        private ComboBox cboShowtime;
        private Label lblShowtime;
    }
}