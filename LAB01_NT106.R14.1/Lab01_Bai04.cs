using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Lab01
{
    public partial class Lab01_Bai04 : Form
    {
        private Random random = new Random();
        private Color[] colorList = new Color[]
        {
            Color.FromArgb(99, 102, 241),
            Color.FromArgb(14, 165, 233),
            Color.FromArgb(16, 185, 129),
            Color.FromArgb(245, 158, 11),
            Color.FromArgb(236, 72, 153),
            Color.FromArgb(139, 92, 246),
            Color.FromArgb(20, 184, 166),
            Color.FromArgb(244, 63, 94)
        };

        private Dictionary<string, int> moviePrices = new Dictionary<string, int>()
        {
            { "Đào, phở và piano", 45000 },
            { "Mai", 100000 },
            { "Gặp lại chị bầu", 70000 },
            { "Tarot", 90000 }
        };

        private Dictionary<string, List<int>> movieRooms = new Dictionary<string, List<int>>()
        {
            { "Đào, phở và piano", new List<int> { 1, 2, 3 } },
            { "Mai", new List<int> { 2, 3 } },
            { "Gặp lại chị bầu", new List<int> { 1 } },
            { "Tarot", new List<int> { 3 } }
        };

        private Dictionary<string, double> seatMultipliers = new Dictionary<string, double>()
        {
            { "A1", 0.25 }, { "A5", 0.25 }, { "C1", 0.25 }, { "C5", 0.25 },
            { "B2", 2.0 },  { "B3", 2.0 },  { "B4", 2.0 },
            { "A2", 1.0 },  { "A3", 1.0 },  { "A4", 1.0 },
            { "B1", 1.0 },  { "B5", 1.0 },
            { "C2", 1.0 },  { "C3", 1.0 },  { "C4", 1.0 }
        };

        private Dictionary<string, (double rate, string banner, string promoName, string tag)> showtimeData = new Dictionary<string, (double, string, string, string)>()
        {
            { "Không áp dụng (Giá vé chuẩn)", (1.00, "🎟 GIÁ VÉ TIÊU CHUẨN\r\nKhông phụ thu & Không ưu đãi", "Không áp dụng", "Tiêu chuẩn") },
            { "09:15 - Early Bird (-20%)", (0.80, "🌅 SUẤT SÁNG EARLY BIRD\r\nƯu đãi giảm 20% giá vé", "Early Bird (-20%)", "09:15") },
            { "11:30 - Early Bird (-20%)", (0.80, "🌅 SUẤT TRƯA EARLY BIRD\r\nƯu đãi giảm 20% giá vé", "Early Bird (-20%)", "11:30") },
            { "14:00 - Standard (Giá gốc)", (1.00, "☀️ SUẤT CHIỀU STANDARD\r\nÁp dụng nguyên giá vé gốc", "Standard (Giá gốc)", "14:00") },
            { "16:30 - Standard (Giá gốc)", (1.00, "☀️ SUẤT CHIỀU STANDARD\r\nÁp dụng nguyên giá vé gốc", "Standard (Giá gốc)", "16:30") },
            { "18:45 - Prime Time (+15%)", (1.15, "🔥 GIỜ VÀNG PRIME TIME\r\nPhụ thu +15% giá vé chuẩn", "Prime Time (+15%)", "18:45") },
            { "20:15 - Prime Time (+15%)", (1.15, "🔥 GIỜ VÀNG PRIME TIME\r\nPhụ thu +15% giá vé chuẩn", "Prime Time (+15%)", "20:15") },
            { "21:45 - Night Owl (-15%)", (0.85, "🌙 SUẤT KHUYA NIGHT OWL\r\nƯu đãi giảm 15% giá vé", "Night Owl (-15%)", "21:45") },
            { "23:15 - Night Owl (-15%)", (0.85, "🌙 SUẤT KHUYA NIGHT OWL\r\nƯu đãi giảm 15% giá vé", "Night Owl (-15%)", "23:15") }
        };

        private HashSet<string> purchasedSeats = new HashSet<string>();
        private HashSet<string> currentSelectedSeats = new HashSet<string>();
        private Dictionary<string, Button> seatButtonMap = new Dictionary<string, Button>();
        private Label lblNoticeBanner;

        public Lab01_Bai04()
        {
            InitializeComponent();
            BindFormEvents();
            SetupSeatLayout();
            SetupMovieData();
            RandomizeActionColors();
        }

        private void BindFormEvents()
        {
            cboMovie.SelectedIndexChanged -= cboMovie_SelectedIndexChanged;
            cboMovie.SelectedIndexChanged += cboMovie_SelectedIndexChanged;

            cboRoom.SelectedIndexChanged -= cboRoom_SelectedIndexChanged;
            cboRoom.SelectedIndexChanged += cboRoom_SelectedIndexChanged;

            if (cboShowtime != null)
            {
                cboShowtime.SelectedIndexChanged -= cboShowtime_SelectedIndexChanged;
                cboShowtime.SelectedIndexChanged += cboShowtime_SelectedIndexChanged;
            }

            btnBook.Click -= btnBook_Click;
            btnBook.Click += btnBook_Click;

            btnReset.Click -= btnReset_Click;
            btnReset.Click += btnReset_Click;

            btnExit.Click -= btnExit_Click;
            btnExit.Click += btnExit_Click;
        }

        private void RandomizeActionColors()
        {
            btnBook.BackColor = colorList[random.Next(colorList.Length)];
            btnBook.ForeColor = Color.White;
            btnReset.BackColor = Color.FromArgb(51, 65, 85);
            btnReset.ForeColor = Color.White;
            btnExit.BackColor = Color.FromArgb(225, 29, 72);
            btnExit.ForeColor = Color.White;
        }

        private void SetupSeatLayout()
        {
            string[] rowLetters = { "A", "B", "C" };
            pnlSeatMatrix.Controls.Clear();
            seatButtonMap.Clear();

            for (int r = 0; r < 3; r++)
            {
                Label lblRow = new Label();
                lblRow.Text = rowLetters[r];
                lblRow.Font = new Font("Segoe UI", 11.5f, FontStyle.Bold);
                lblRow.ForeColor = Color.FromArgb(0, 242, 254);
                lblRow.Size = new Size(28, 52);
                lblRow.Location = new Point(2, 8 + r * 64);
                lblRow.TextAlign = ContentAlignment.MiddleCenter;
                pnlSeatMatrix.Controls.Add(lblRow);

                for (int c = 1; c <= 5; c++)
                {
                    string seatCode = rowLetters[r] + c.ToString();
                    Button btn = new Button();
                    btn.Name = "btnSeat_" + seatCode;
                    btn.Text = c.ToString();
                    btn.Size = new Size(74, 52);
                    btn.Location = new Point(34 + (c - 1) * 80, 8 + r * 64);
                    btn.Font = new Font("Segoe UI", 11f, FontStyle.Bold);
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 1;
                    btn.Click += SeatButton_Click;

                    pnlSeatMatrix.Controls.Add(btn);
                    seatButtonMap.Add(seatCode, btn);
                }
            }

            lblNoticeBanner = new Label();
            lblNoticeBanner.Name = "lblNoticeBanner";
            lblNoticeBanner.Size = new Size(310, 56);
            lblNoticeBanner.Location = new Point(76, 204);
            lblNoticeBanner.Font = new Font("Segoe UI", 9.5f, FontStyle.Bold);
            lblNoticeBanner.TextAlign = ContentAlignment.MiddleCenter;
            lblNoticeBanner.BorderStyle = BorderStyle.FixedSingle;
            lblNoticeBanner.BackColor = Color.FromArgb(26, 16, 48);
            lblNoticeBanner.ForeColor = Color.FromArgb(192, 132, 252);
            lblNoticeBanner.Text = "🎟 GIÁ VÉ TIÊU CHUẨN\r\nKhông phụ thu & Không ưu đãi";
            pnlSeatMatrix.Controls.Add(lblNoticeBanner);
        }

        private void SetupMovieData()
        {
            cboMovie.Items.Clear();
            foreach (string title in moviePrices.Keys)
            {
                cboMovie.Items.Add(title);
            }

            if (cboShowtime != null)
            {
                cboShowtime.Items.Clear();
                foreach (string opt in showtimeData.Keys)
                {
                    cboShowtime.Items.Add(opt);
                }
                cboShowtime.SelectedIndex = 0;
            }

            if (cboMovie.Items.Count > 0)
            {
                cboMovie.SelectedIndex = 0;
                LoadRoomsForMovie(cboMovie.SelectedItem.ToString());
            }

            UpdateShowtimeNotice();
        }

        private void LoadRoomsForMovie(string movieName)
        {
            cboRoom.Items.Clear();
            if (movieRooms.ContainsKey(movieName))
            {
                foreach (int room in movieRooms[movieName])
                {
                    cboRoom.Items.Add("Phòng " + room.ToString());
                }
            }

            if (cboRoom.Items.Count > 0)
            {
                cboRoom.SelectedIndex = 0;
            }
            else
            {
                currentSelectedSeats.Clear();
                RefreshSeatMatrixUI();
            }

            UpdatePriceDisplay();
        }

        private void UpdateShowtimeNotice()
        {
            if (cboShowtime != null && cboShowtime.SelectedItem != null)
            {
                string selectedKey = cboShowtime.SelectedItem.ToString();
                if (showtimeData.ContainsKey(selectedKey))
                {
                    if (lblNoticeBanner != null)
                    {
                        lblNoticeBanner.Text = showtimeData[selectedKey].banner;
                    }
                }
            }
            UpdatePriceDisplay();
        }

        private void UpdatePriceDisplay()
        {
            if (cboMovie.SelectedItem == null) return;
            string movie = cboMovie.SelectedItem.ToString();
            int basePrice = moviePrices[movie];
            double timeRate = 1.0;

            if (cboShowtime != null && cboShowtime.SelectedItem != null)
            {
                string selectedKey = cboShowtime.SelectedItem.ToString();
                if (showtimeData.ContainsKey(selectedKey))
                {
                    timeRate = showtimeData[selectedKey].rate;
                }
            }

            double actualPrice = basePrice * timeRate;
            lblPriceTag.Text = string.Format("🎟 Giá vé: {0:#,##0} đ", actualPrice);
        }

        private void cboMovie_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMovie.SelectedItem == null) return;
            LoadRoomsForMovie(cboMovie.SelectedItem.ToString());
        }

        private void cboRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentSelectedSeats.Clear();
            RefreshSeatMatrixUI();
        }

        private void cboShowtime_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentSelectedSeats.Clear();
            UpdateShowtimeNotice();
            RefreshSeatMatrixUI();
        }

        private void RefreshSeatMatrixUI()
        {
            string moviePrefix = "";
            string roomPrefix = "";
            string timeTag = "";

            if (cboMovie.SelectedItem != null) moviePrefix = cboMovie.SelectedItem.ToString();
            if (cboRoom.SelectedItem != null) roomPrefix = cboRoom.SelectedItem.ToString();
            if (cboShowtime != null && cboShowtime.SelectedItem != null)
            {
                string key = cboShowtime.SelectedItem.ToString();
                if (showtimeData.ContainsKey(key))
                {
                    timeTag = showtimeData[key].tag;
                }
            }

            string keyPrefix = moviePrefix + "_" + roomPrefix + "_" + timeTag + "_";

            foreach (var kvp in seatButtonMap)
            {
                string globalSeatKey = keyPrefix + kvp.Key;

                if (!string.IsNullOrEmpty(roomPrefix) && purchasedSeats.Contains(globalSeatKey))
                {
                    kvp.Value.BackColor = Color.FromArgb(30, 41, 59);
                    kvp.Value.ForeColor = Color.FromArgb(100, 116, 139);
                    kvp.Value.FlatAppearance.BorderColor = Color.FromArgb(51, 65, 85);
                    kvp.Value.Enabled = false;
                }
                else if (currentSelectedSeats.Contains(kvp.Key))
                {
                    kvp.Value.BackColor = Color.FromArgb(244, 63, 94);
                    kvp.Value.ForeColor = Color.White;
                    kvp.Value.FlatAppearance.BorderColor = Color.FromArgb(225, 29, 72);
                    kvp.Value.Enabled = true;
                }
                else
                {
                    kvp.Value.BackColor = GetSeatTypeColor(kvp.Key);
                    kvp.Value.ForeColor = (kvp.Key == "A1" || kvp.Key == "A5" || kvp.Key == "C1" || kvp.Key == "C5") ? Color.White : Color.FromArgb(15, 23, 42);
                    kvp.Value.FlatAppearance.BorderColor = Color.FromArgb(148, 163, 184);
                    kvp.Value.Enabled = true;
                }
            }
        }

        private Color GetSeatTypeColor(string seatCode)
        {
            if (seatCode == "A1" || seatCode == "A5" || seatCode == "C1" || seatCode == "C5")
            {
                return Color.FromArgb(100, 116, 139);
            }
            if (seatCode == "B2" || seatCode == "B3" || seatCode == "B4")
            {
                return Color.FromArgb(245, 158, 11);
            }
            return Color.White;
        }

        private void SeatButton_Click(object sender, EventArgs e)
        {
            if (cboRoom.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn phòng chiếu trước khi chọn ghế!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Button btn = sender as Button;
            string seatCode = "";
            foreach (var pair in seatButtonMap)
            {
                if (pair.Value == btn)
                {
                    seatCode = pair.Key;
                    break;
                }
            }

            if (currentSelectedSeats.Contains(seatCode))
            {
                currentSelectedSeats.Remove(seatCode);
            }
            else
            {
                if (currentSelectedSeats.Count >= 2)
                {
                    MessageBox.Show("Không thể chọn nhiều hơn 2 vé!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                currentSelectedSeats.Add(seatCode);
            }

            RefreshSeatMatrixUI();
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            RandomizeActionColors();

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Vui lòng nhập họ và tên khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return;
            }

            if (cboRoom.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn phòng chiếu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (currentSelectedSeats.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ghế trên sơ đồ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string currentMovie = cboMovie.SelectedItem.ToString();
            string currentRoom = cboRoom.SelectedItem.ToString();
            string selectedKey = cboShowtime != null && cboShowtime.SelectedItem != null ? cboShowtime.SelectedItem.ToString() : "Không áp dụng (Giá vé chuẩn)";

            double timeRate = showtimeData.ContainsKey(selectedKey) ? showtimeData[selectedKey].rate : 1.0;
            string promoName = showtimeData.ContainsKey(selectedKey) ? showtimeData[selectedKey].promoName : "Không áp dụng";
            string timeTag = showtimeData.ContainsKey(selectedKey) ? showtimeData[selectedKey].tag : "Tiêu chuẩn";

            int basePrice = moviePrices[currentMovie];
            double totalAmount = 0;

            List<string> selectedList = new List<string>(currentSelectedSeats);
            selectedList.Sort();

            foreach (string seat in selectedList)
            {
                string globalKey = currentMovie + "_" + currentRoom + "_" + timeTag + "_" + seat;
                purchasedSeats.Add(globalKey);
                totalAmount += (basePrice * timeRate) * seatMultipliers[seat];
            }

            txtInvoice.Clear();
            txtInvoice.AppendText("┌─────────────────────────────┐\r\n");
            txtInvoice.AppendText("│       HÓA ĐƠN ĐẶT VÉ        │\r\n");
            txtInvoice.AppendText("├─────────────────────────────┤\r\n");
            txtInvoice.AppendText(string.Format("  Khách:  {0}\r\n", txtName.Text.Trim()));
            txtInvoice.AppendText(string.Format("  Phim:   {0}\r\n", currentMovie));
            txtInvoice.AppendText(string.Format("  Suất:   {0}\r\n", timeTag));
            txtInvoice.AppendText(string.Format("  Ưu đãi: {0}\r\n", promoName));
            txtInvoice.AppendText(string.Format("  Phòng:  {0}\r\n", currentRoom));
            txtInvoice.AppendText(string.Format("  Ghế:    {0}\r\n", string.Join(", ", selectedList)));
            txtInvoice.AppendText(string.Format("  SL:     {0} vé\r\n", selectedList.Count));
            txtInvoice.AppendText("├─────────────────────────────┤\r\n");
            txtInvoice.AppendText(string.Format("  TỔNG:   {0} VNĐ\r\n", totalAmount.ToString("#,##0")));
            txtInvoice.AppendText("├─────────────────────────────┤\r\n");
            txtInvoice.AppendText("   ♥ CẢM ƠN QUÝ KHÁCH HÀNG ♥  \r\n");
            txtInvoice.AppendText("   Chúc bạn xem phim vui vẻ!  \r\n");
            txtInvoice.AppendText("└─────────────────────────────┘\r\n");

            currentSelectedSeats.Clear();
            RefreshSeatMatrixUI();
            MessageBox.Show("Giao dịch đặt vé thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            RandomizeActionColors();
            txtName.Clear();
            currentSelectedSeats.Clear();
            txtInvoice.Clear();
            if (cboShowtime != null && cboShowtime.Items.Count > 0)
            {
                cboShowtime.SelectedIndex = 0;
            }
            RefreshSeatMatrixUI();
            txtName.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}