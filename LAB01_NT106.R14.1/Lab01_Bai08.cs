using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Lab01
{
    public partial class Lab01_Bai08 : Form
    {
        private string favoriteDishString = "Bún riêu; Bún thịt nướng; Cơm tấm sườn trứng; Phở; Gỏi cuốn";
        private Random random = new Random();

        public class FoodItem
        {
            public string Name { get; set; }
            public string Category { get; set; }
            public string Meal { get; set; }
            public int Price { get; set; }
            public string Description { get; set; }
        }

        private List<FoodItem> foodDatabase = new List<FoodItem>();

        private string[] all34Provinces = new string[]
        {
            "TP. Hồ Chí Minh", "Hà Nội", "Hải Phòng", "Đà Nẵng", "Cần Thơ",
            "An Giang", "Bà Rịa - Vũng Tàu", "Bắc Giang", "Bắc Ninh", "Bến Tre",
            "Bình Định", "Bình Dương", "Bình Thuận", "Cà Mau", "Đắk Lắk",
            "Đồng Nai", "Đồng Tháp", "Gia Lai", "Hà Tĩnh", "Hải Dương",
            "Khánh Hòa", "Kiên Giang", "Lâm Đồng", "Long An", "Nam Định",
            "Nghệ An", "Ninh Bình", "Phú Thọ", "Quảng Nam", "Quảng Ninh",
            "Tây Ninh", "Thái Nguyên", "Thanh Hóa", "Thừa Thiên Huế"
        };

        private List<string> hcmc168Wards = new List<string>()
        {
            // TP. Thủ Đức
            "TP. Thủ Đức - Phường An Khánh", "TP. Thủ Đức - Phường An Lợi Đông", "TP. Thủ Đức - Phường An Phú",
            "TP. Thủ Đức - Phường Bình Chiểu", "TP. Thủ Đức - Phường Bình Thọ", "TP. Thủ Đức - Phường Hiệp Bình Chánh",
            "TP. Thủ Đức - Phường Hiệp Bình Phước", "TP. Thủ Đức - Phường Hiệp Phú", "TP. Thủ Đức - Phường Linh Chiểu",
            "TP. Thủ Đức - Phường Linh Đông", "TP. Thủ Đức - Phường Linh Tây", "TP. Thủ Đức - Phường Linh Trung",
            "TP. Thủ Đức - Phường Linh Xuân", "TP. Thủ Đức - Phường Long Bình", "TP. Thủ Đức - Phường Long Phước",
            "TP. Thủ Đức - Phường Long Thạnh Mỹ", "TP. Thủ Đức - Phường Long Trường", "TP. Thủ Đức - Phường Phú Hữu",
            "TP. Thủ Đức - Phường Phước Bình", "TP. Thủ Đức - Phường Phước Long A", "TP. Thủ Đức - Phường Phước Long B",
            "TP. Thủ Đức - Phường Tam Bình", "TP. Thủ Đức - Phường Tam Phú", "TP. Thủ Đức - Phường Tăng Nhơn Phú A",
            "TP. Thủ Đức - Phường Tăng Nhơn Phú B", "TP. Thủ Đức - Phường Thạnh Mỹ Lợi", "TP. Thủ Đức - Phường Thảo Điền",
            "TP. Thủ Đức - Phường Thủ Thiêm", "TP. Thủ Đức - Phường Trường Thạnh", "TP. Thủ Đức - Phường Trường Thọ",
            
            // Quận Gò Vấp (Có Phường Tân Sơn sau sáp nhập)
            "Quận Gò Vấp - Phường Tân Sơn", "Quận Gò Vấp - Phường 1", "Quận Gò Vấp - Phường 3",
            "Quận Gò Vấp - Phường 4 (Sáp nhập P4 & P7)", "Quận Gò Vấp - Phường 5", "Quận Gò Vấp - Phường 8",
            "Quận Gò Vấp - Phường 9 (Sáp nhập P8 & P9)", "Quận Gò Vấp - Phường 10", "Quận Gò Vấp - Phường 11",
            "Quận Gò Vấp - Phường 12", "Quận Gò Vấp - Phường 14", "Quận Gò Vấp - Phường 15", "Quận Gò Vấp - Phường 16",

            // Quận 1
            "Quận 1 - Phường Bến Nghé", "Quận 1 - Phường Bến Thành", "Quận 1 - Phường Cầu Kho", "Quận 1 - Phường Cầu Ông Lãnh",
            "Quận 1 - Phường Cô Giang", "Quận 1 - Phường Đa Kao", "Quận 1 - Phường Nguyễn Cư Trinh", "Quận 1 - Phường Nguyễn Thái Bình",
            "Quận 1 - Phường Phạm Ngũ Lão", "Quận 1 - Phường Tân Định",

            // Quận 3
            "Quận 3 - Phường Võ Thị Sáu", "Quận 3 - Phường 1", "Quận 3 - Phường 2", "Quận 3 - Phường 3", "Quận 3 - Phường 4",
            "Quận 3 - Phường 5", "Quận 3 - Phường 9 (Sáp nhập P9 & P10)", "Quận 3 - Phường 11", "Quận 3 - Phường 12 (Sáp nhập P12 & P14)",

            // Quận 4
            "Quận 4 - Phường 1", "Quận 4 - Phường 2", "Quận 4 - Phường 3", "Quận 4 - Phường 4", "Quận 4 - Phường 6 (Sáp nhập P6 & P9)",
            "Quận 4 - Phường 8 (Sáp nhập P8 & P9)", "Quận 4 - Phường 13", "Quận 4 - Phường 14", "Quận 4 - Phường 15", "Quận 4 - Phường 16",

            // Quận 5
            "Quận 5 - Phường 1", "Quận 5 - Phường 2 (Sáp nhập P2 & P3)", "Quận 5 - Phường 4", "Quận 5 - Phường 5 (Sáp nhập P5 & P6)",
            "Quận 5 - Phường 7 (Sáp nhập P7 & P8)", "Quận 5 - Phường 9", "Quận 5 - Phường 10", "Quận 5 - Phường 11", "Quận 5 - Phường 12", "Quận 5 - Phường 14",

            // Quận 6
            "Quận 6 - Phường 1", "Quận 6 - Phường 2 (Sáp nhập P2 & P6)", "Quận 6 - Phường 3", "Quận 6 - Phường 4", "Quận 6 - Phường 5",
            "Quận 6 - Phường 7", "Quận 6 - Phường 8", "Quận 6 - Phường 9", "Quận 6 - Phường 10", "Quận 6 - Phường 11", "Quận 6 - Phường 12",

            // Quận 7
            "Quận 7 - Phường Tân Phong", "Quận 7 - Phường Tân Phú", "Quận 7 - Phường Tân Hưng", "Quận 7 - Phường Tân Quy",
            "Quận 7 - Phường Tân Kiểng", "Quận 7 - Phường Tân Thuận Đông", "Quận 7 - Phường Tân Thuận Tây", "Quận 7 - Phường Phú Mỹ",

            // Quận 8
            "Quận 8 - Phường 1", "Quận 8 - Phường 2 (Sáp nhập P1, P2, P3)", "Quận 8 - Phường 4", "Quận 8 - Phường 5",
            "Quận 8 - Phường 8 (Sáp nhập P8 & P9)", "Quận 8 - Phường 10", "Quận 8 - Phường 14", "Quận 8 - Phường 15",

            // Quận 10
            "Quận 10 - Phường 1", "Quận 10 - Phường 2", "Quận 10 - Phường 4", "Quận 10 - Phường 5 (Sáp nhập P5 & P8)",
            "Quận 10 - Phường 6 (Sáp nhập P6 & P7)", "Quận 10 - Phường 9", "Quận 10 - Phường 10", "Quận 10 - Phường 11", "Quận 10 - Phường 12",

            // Quận 11
            "Quận 11 - Phường 1", "Quận 11 - Phường 2", "Quận 11 - Phường 3", "Quận 11 - Phường 5", "Quận 11 - Phường 7",
            "Quận 11 - Phường 8", "Quận 11 - Phường 9", "Quận 11 - Phường 11", "Quận 11 - Phường 14",

            // Quận 12
            "Quận 12 - Phường An Phú Đông", "Quận 12 - Phường Hiệp Thành", "Quận 12 - Phường Tân Chánh Hiệp", "Quận 12 - Phường Thạnh Lộc",
            "Quận 12 - Phường Tân Thới Nhất", "Quận 12 - Phường Thới An", "Quận 12 - Phường Trung Mỹ Tây",

            // Quận Bình Thạnh
            "Quận Bình Thạnh - Phường 1", "Quận Bình Thạnh - Phường 2", "Quận Bình Thạnh - Phường 3", "Quận Bình Thạnh - Phường 11",
            "Quận Bình Thạnh - Phường 12", "Quận Bình Thạnh - Phường 13 (Sáp nhập P11 & P13)", "Quận Bình Thạnh - Phường 19",
            "Quận Bình Thạnh - Phường 25", "Quận Bình Thạnh - Phường 26", "Quận Bình Thạnh - Phường 27",

            // Quận Phú Nhuận
            "Quận Phú Nhuận - Phường 1", "Quận Phú Nhuận - Phường 2", "Quận Phú Nhuận - Phường 7", "Quận Phú Nhuận - Phường 9",
            "Quận Phú Nhuận - Phường 11 (Sáp nhập P11 & P12)", "Quận Phú Nhuận - Phường 15 (Sáp nhập P15 & P17)",

            // Quận Tân Bình
            "Quận Tân Bình - Phường Tân Sơn Hòa", "Quận Tân Bình - Phường 1", "Quận Tân Bình - Phường 2", "Quận Tân Bình - Phường 4",
            "Quận Tân Bình - Phường 12", "Quận Tân Bình - Phường 15",

            // Quận Tân Phú
            "Quận Tân Phú - Phường Tân Sơn Nhì", "Quận Tân Phú - Phường Tây Thạnh", "Quận Tân Phú - Phường Sơn Kỳ", "Quận Tân Phú - Phường Phú Thạnh",

            // Quận Bình Tân
            "Quận Bình Tân - Phường An Lạc", "Quận Bình Tân - Phường Bình Hưng Hòa", "Quận Bình Tân - Phường Bình Trị Đông", "Quận Bình Tân - Phường Tân Tạo"
        };

        private Dictionary<string, List<string>> streetData = new Dictionary<string, List<string>>()
        {
            { "Quận Gò Vấp - Phường Tân Sơn", new List<string> { "Đường Tân Sơn", "Đường Quang Trung", "Đường Phạm Văn Bạch", "Đường Phan Huy Ích", "Đường Nguyễn Văn Khối", "Hẻm 45 Tân Sơn" } },
            { "Quận Tân Bình - Phường Tân Sơn Hòa", new List<string> { "Đường Lê Văn Sỹ", "Đường Hoàng Sa", "Đường Trường Sa", "Đường Phạm Văn Hai" } },
            { "Quận Tân Phú - Phường Tân Sơn Nhì", new List<string> { "Đường Tân Sơn Nhì", "Đường Gò Dầu", "Đường Trương Vĩnh Ký", "Đường Nguyễn Cửu Đàm" } },
            { "TP. Thủ Đức - Phường An Khánh", new List<string> { "Đường Lương Định Của", "Đường Trần Não", "Đường Mai Chí Thọ", "Đường Nguyễn Cơ Thạch", "Đường số 12" } },
            { "TP. Thủ Đức - Phường Thảo Điền", new List<string> { "Đường Xuân Thủy", "Đường Thảo Điền", "Đường Quốc Hương", "Đường Nguyễn Văn Hưởng", "Đường Tống Hữu Định" } },
            { "TP. Thủ Đức - Phường Linh Trung", new List<string> { "Đường Lê Văn Chí", "Đường Hoàng Diệu 2", "Đường Võ Văn Ngân", "Đường Quốc Lộ 1A", "Đường số 6" } },
            { "TP. Thủ Đức - Phường Hiệp Bình Chánh", new List<string> { "Đường Phạm Văn Đồng", "Đường Quốc Lộ 13", "Đường số 25", "Đường Hiệp Bình", "Đường Tam Bình" } },
            { "Quận 1 - Phường Bến Nghé", new List<string> { "Đường Nguyễn Huệ", "Đường Đồng Khởi", "Đường Lê Lợi", "Đường Hai Bà Trưng", "Đường Tôn Đức Thắng" } },
            { "Quận 1 - Phường Bến Thành", new List<string> { "Đường Phan Chu Trinh", "Đường Lê Thánh Tôn", "Đường Cách Mạng Tháng 8", "Đường Lý Tự Trọng", "Đường Nguyễn Du" } },
            { "Quận 1 - Phường Đa Kao", new List<string> { "Đường Đinh Tiên Hoàng", "Đường Điện Biên Phủ", "Đường Nguyễn Đình Chiểu", "Đường Mạc Đĩnh Chi", "Đường Phan Kế Bính" } },
            { "Quận 3 - Phường Võ Thị Sáu", new List<string> { "Đường Nam Kỳ Khởi Nghĩa", "Đường Võ Văn Tần", "Đường Nguyễn Thị Minh Khai", "Đường Pasteur", "Đường Trương Định" } },
            { "Quận 3 - Phường 9 (Sáp nhập P9 & P10)", new List<string> { "Đường Kỳ Đồng", "Đường Bà Huyện Thanh Quan", "Đường Trương Định", "Đường Rạch Bùng Binh" } },
            { "Quận Bình Thạnh - Phường 25", new List<string> { "Đường Điện Biên Phủ", "Đường Nguyễn Gia Trí (D2)", "Đường Ung Văn Khiêm", "Đường Xô Viết Nghệ Tĩnh" } },
            { "Quận 7 - Phường Tân Phong", new List<string> { "Đường Nguyễn Văn Linh", "Đường Nguyễn Thị Thập", "Đường Lê Văn Lương", "Đường Phạm Thái Bường" } }
        };

        public Lab01_Bai08()
        {
            InitializeComponent();
            BindEvents();
            LoadFavoriteDishesToList();
            Generate500AuthenticVietnameseDishes();
            InitTabKetAmThuc();
            InitTabTimQuan();
            InitTabMenuTong();
            HighlightActiveNavButton(btnNavFav);
        }

        private void BindEvents()
        {
            btnNavFav.Click += (s, e) => { tabControl.SelectedTab = tabLab01; HighlightActiveNavButton(btnNavFav); };
            btnNavChest.Click += (s, e) => { tabControl.SelectedTab = tabKetAmThuc; HighlightActiveNavButton(btnNavChest); };
            btnNavFortune.Click += (s, e) => { tabControl.SelectedTab = tabBocQue; HighlightActiveNavButton(btnNavFortune); };
            btnNavMaps.Click += (s, e) => { tabControl.SelectedTab = tabTimQuan; HighlightActiveNavButton(btnNavMaps); };
            btnNavMenu.Click += (s, e) => { tabControl.SelectedTab = tabMenuTong; HighlightActiveNavButton(btnNavMenu); };

            btnAddFavorite.Click -= btnAddFavorite_Click;
            btnAddFavorite.Click += btnAddFavorite_Click;

            btnDeleteFavorite.Click -= btnDeleteFavorite_Click;
            btnDeleteFavorite.Click += btnDeleteFavorite_Click;

            btnQuickFill.Click -= btnQuickFill_Click;
            btnQuickFill.Click += btnQuickFill_Click;

            btnFindDish.Click -= btnFindDish_Click;
            btnFindDish.Click += btnFindDish_Click;

            btnClearFavorite.Click -= btnClearFavorite_Click;
            btnClearFavorite.Click += btnClearFavorite_Click;

            btnExitFavorite.Click -= btnExitFavorite_Click;
            btnExitFavorite.Click += btnExitFavorite_Click;

            btnOpenChest.Click -= btnOpenChest_Click;
            btnOpenChest.Click += btnOpenChest_Click;

            btnDrawFortune.Click -= btnDrawFortune_Click;
            btnDrawFortune.Click += btnDrawFortune_Click;

            cboCity.SelectedIndexChanged -= cboCity_SelectedIndexChanged;
            cboCity.SelectedIndexChanged += cboCity_SelectedIndexChanged;

            cboWard.SelectedIndexChanged -= cboWard_SelectedIndexChanged;
            cboWard.SelectedIndexChanged += cboWard_SelectedIndexChanged;

            cboWard.DropDown -= cboWard_DropDown;
            cboWard.DropDown += cboWard_DropDown;

            cboStreet.DropDown -= cboStreet_DropDown;
            cboStreet.DropDown += cboStreet_DropDown;

            btnFindNearShops.Click -= btnFindNearShops_Click;
            btnFindNearShops.Click += btnFindNearShops_Click;

            btnOpenGoogleMaps.Click -= btnOpenGoogleMaps_Click;
            btnOpenGoogleMaps.Click += btnOpenGoogleMaps_Click;

            txtSearchMenu.TextChanged -= txtSearchMenu_TextChanged;
            txtSearchMenu.TextChanged += txtSearchMenu_TextChanged;
        }

        private void HighlightActiveNavButton(Button activeBtn)
        {
            Button[] navBtns = { btnNavFav, btnNavChest, btnNavFortune, btnNavMaps, btnNavMenu };
            foreach (var b in navBtns)
            {
                if (b == activeBtn)
                {
                    b.BackColor = Color.FromArgb(37, 99, 235);
                    b.ForeColor = Color.White;
                }
                else
                {
                    b.BackColor = Color.White;
                    b.ForeColor = Color.FromArgb(71, 85, 105);
                }
            }
        }

        private void LoadFavoriteDishesToList()
        {
            lstFavoriteDishes.Items.Clear();
            string[] items = favoriteDishString.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string item in items)
            {
                if (!string.IsNullOrWhiteSpace(item))
                {
                    lstFavoriteDishes.Items.Add(item.Trim());
                }
            }
        }

        private void btnQuickFill_Click(object sender, EventArgs e)
        {
            txtNewDish.Text = "Ăn gì cũng được";
            txtNewDish.Focus();
        }

        private void btnAddFavorite_Click(object sender, EventArgs e)
        {
            string newDish = txtNewDish.Text.Trim();
            if (string.IsNullOrEmpty(newDish))
            {
                MessageBox.Show("Vui lòng nhập tên món ăn cần thêm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNewDish.Focus();
                return;
            }

            favoriteDishString += "; " + newDish;
            LoadFavoriteDishesToList();
            txtNewDish.Clear();
            txtNewDish.Focus();
        }

        private void btnDeleteFavorite_Click(object sender, EventArgs e)
        {
            if (lstFavoriteDishes.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn một món ăn trong danh sách để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string selected = lstFavoriteDishes.SelectedItem.ToString();
            List<string> currentList = new List<string>();
            foreach (var item in lstFavoriteDishes.Items)
            {
                currentList.Add(item.ToString());
            }

            currentList.Remove(selected);
            favoriteDishString = string.Join("; ", currentList);
            LoadFavoriteDishesToList();

            if (lblSelectedDish.Text == selected)
            {
                lblSelectedDish.Text = "Món vừa chọn đã được xóa khỏi danh sách!";
            }
        }

        private void btnFindDish_Click(object sender, EventArgs e)
        {
            if (lstFavoriteDishes.Items.Count == 0)
            {
                MessageBox.Show("Danh sách món ăn đang trống! Vui lòng thêm món trước.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int index = random.Next(lstFavoriteDishes.Items.Count);
            lblSelectedDish.Text = lstFavoriteDishes.Items[index].ToString();
        }

        private void btnClearFavorite_Click(object sender, EventArgs e)
        {
            txtNewDish.Clear();
            lblSelectedDish.Text = "Chưa có gợi ý. Hãy nhấn nút tìm món!";
            txtNewDish.Focus();
        }

        private void btnExitFavorite_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Generate500AuthenticVietnameseDishes()
        {
            foodDatabase = new List<FoodItem>();

            var comList = new (string, string, int, string)[]
            {
                ("Cơm tấm sườn nướng than hoa", "Trưa", 45000, "Sườn cây ướp mật ong nướng than hoa vàng rụm mỡ hành tóp mỡ"),
                ("Cơm tấm bì chả trứng ốp la", "Sáng", 40000, "Chả trứng hấp thịt thơm nức bì heo giòn dai chấm mắm tỏi ớt"),
                ("Cơm tấm Long Xuyên sườn cay nhuyễn", "Sáng", 45000, "Thịt sườn xắt sợi nhuyễn ăn kèm trứng kho bùi béo"),
                ("Cơm tấm sườn non rim mặn ngọt", "Trưa", 48000, "Sườn non chặt khúc rim nước mắm cốt dừa béo mặn"),
                ("Cơm tấm chả cua đúc trứng lòng đào", "Trưa", 52000, "Thịt cua đồng đúc trứng béo bùi ăn cùng đồ chua giòn"),
                ("Cơm tấm ba chỉ nướng mật ong rừng", "Trưa", 48000, "Thịt rọi vàng ươm mọng mỡ ăn kèm dưa leo cà chua"),
                ("Cơm gà xối mỡ đùi góc tư giòn rụm", "Trưa", 48000, "Cơm đỏ chiên săn da gà xối mỡ giòn bóng chấm tương gừng"),
                ("Cơm gà luộc Hải Nam sốt gừng tỏi", "Trưa", 50000, "Gà ta da giòn thịt ngọt nấu cơm từ nước luộc gà thơm nức"),
                ("Cơm gà Tam Kỳ xé phay bóp rau răm", "Trưa", 48000, "Gà xé trộn hành tây tiêu đen chua cay đậm vị miền Trung"),
                ("Cơm gà Hội An cơm vàng nghệ dưa góp", "Trưa", 50000, "Cơm nấu nghệ vàng óng thịt gà xé phay ớt rim Hội An"),
                ("Cơm niêu cá bống kho tộ tiêu đen", "Trưa", 65000, "Cơm cháy đáy niêu giòn rụm chan nước cá kho kẹo đậm đà"),
                ("Cơm niêu thịt kho quẹt rau củ luộc", "Trưa", 60000, "Kho quẹt tôm khô tóp mỡ chấm bông cải đậu bắp giòn ngọt"),
                ("Cơm niêu sườn non xào chua ngọt", "Tối", 65000, "Sườn sụn giòn mềm ngập sốt dứa cà chua óng ánh"),
                ("Cơm niêu cá kèo kho rau răm", "Trưa", 62000, "Cá kèo béo bùi kho sệt thơm nức mùi rau răm cay ấm"),
                ("Cơm lam gà nướng than Bản Đôn", "Tối", 85000, "Cơm nếp dẻo ống nứa gà nướng than chấm muối vừng rừng"),
                ("Cơm hến xứ Huế mắm ruốc tóp mỡ", "Sáng", 35000, "Hến xào thì là đậu phộng da heo chiên giòn cay nồng cố đô"),
                ("Cơm chiên cá mặn gà xé hạt sen", "Trưa", 45000, "Hạt cơm săn bóng thơm mùi khô cá mặn đặc sản biển"),
                ("Cơm chiên Dương Châu tôm lạp xưởng", "Trưa", 45000, "Cơm chiên trứng tơi xốp ngập tôm tươi đậu hà lan cà rốt"),
                ("Cơm chiên kim chi bò lúc lắc", "Tối", 55000, "Hạt cơm chua cay xào cùng thăn bò mềm ngậy sốt bơ"),
                ("Cơm chiên hải sản tôm mực trứng cút", "Trưa", 50000, "Đầy ắp hải sản tươi sống ngọt lịm chấm tương ớt"),
                ("Cơm bò lúc lắc khoai tây sốt tiêu đen", "Tối", 65000, "Thịt bò thăn mềm xào lửa lớn đẫm sốt bơ tỏi thơm ngậy"),
                ("Cơm thịt kho tàu nước dừa trứng cút", "Trưa", 42000, "Thịt ba chỉ mềm tan nước dừa ngọt dịu màu cánh gián"),
                ("Cơm cá diêu hồng chiên xù sốt mắm me", "Trưa", 45000, "Cá vàng giòn rụm chan ngập nước sốt me chua ngọt cay the"),
                ("Cơm cá thu sốt cà chua hành tây", "Trưa", 55000, "Khúc cá thu nạc thịt ngọt thơm đượm sốt cà chua đưa cơm"),
                ("Cơm sườn cốt lết ram nước dừa xiêm", "Trưa", 45000, "Sườn rim mềm thơm béo ngậy vị nước dừa tươi Bến Tre"),
                ("Cơm tôm sú rim thịt ba chỉ cháy cạnh", "Trưa", 50000, "Tôm đồng tươi bóng mẩy rim cùng thịt rọi béo giòn"),
                ("Cơm canh cua đồng cà pháo mắm tôm", "Trưa", 45000, "Bát canh cua rau đay mồng tơi ăn cùng cà pháo giòn tan"),
                ("Cơm canh chua cá lóc rau bổi Nam Bộ", "Trưa", 55000, "Canh chua bạc hà đậu bắp ngọt thanh giải nhiệt ngày hè"),
                ("Cơm canh khổ qua nhồi thịt bằm", "Trưa", 40000, "Khổ qua hầm mềm nước canh ngọt thanh mát gan giải độc"),
                ("Cơm sườn xào dưa chua giòn rụm", "Trưa", 48000, "Vị chua thanh của dưa cải muối quyện cùng sườn non béo mềm")
            };

            foreach (var item in comList)
            {
                foodDatabase.Add(new FoodItem { Name = item.Item1, Category = "Món chính", Meal = item.Item2, Price = item.Item3, Description = item.Item4 });
            }

            var phoBunList = new (string, string, int, string)[]
            {
                ("Phở bò tái lăn gừng tỏi Hà Nội", "Sáng", 55000, "Bò xào lăn tỏi thơm nức nước dùng ninh xương bò ngọt thanh"),
                ("Phở bò chín nạm gầu giòn phố cổ", "Sáng", 50000, "Gầu giòn sần sật nạm bò mềm ngậy nước súp trong vắt"),
                ("Phở gà ta đồi lá chanh bánh tráng tay", "Sáng", 45000, "Gà đồi thịt dai da vàng ươm ngậy hương lá chanh tươi"),
                ("Phở sốt vang bò gân mềm quẩy giòn", "Sáng", 55000, "Nước sốt vang sánh đỏ đậm đà thịt bò hầm nhừ ăn kèm quẩy"),
                ("Phở cuốn Hà Nội thịt bò rau thơm", "Trưa", 45000, "Bánh phở tráng mỏng cuốn bắp bò xào chấm mắm tỏi ớt"),
                ("Phở chiên phồng bò xào rau cải", "Trưa", 55000, "Miếng phở chiên phồng giòn rụm ngập sốt bò xào cải ngọt"),
                ("Phở khô Gia Lai 2 tô tương đen", "Sáng", 48000, "Tô phở trộn tóp mỡ hành phi ăn kèm tô nước súp bò ngọt lịm"),
                ("Bún bò Huế giò heo chả cua mắm ruốc", "Sáng", 50000, "Nước lèo ruốc sả thơm nồng chả cua giòn ngọt bắp bò mềm"),
                ("Bún bò bắp hoa nạm gân xứ Huế", "Sáng", 55000, "Bắp hoa giòn sần sật gân trong veo cay nồng sa tế"),
                ("Bún chả que tre nướng than Hà Nội", "Trưa", 50000, "Chả nướng than hoa ngâm bát nước mắm ấm đu đủ cà rốt"),
                ("Bún đậu mắm tôm mẹt thập cẩm lòng dồi", "Trưa", 65000, "Đậu chiên giòn rụm chả cốm nem chua dồi sụn mắm sủi bọt"),
                ("Bún riêu cua đồng ốc bươu đậu hũ", "Sáng", 45000, "Riêu cua nổi váng vàng ươm ốc bươu giòn sần sật mắm tôm nồng"),
                ("Bún mắm miền Tây cá lóc mực tôm", "Trưa", 55000, "Nước lèo mắm sặc mắm linh rau đắng kèo nèo cọng súng tươi"),
                ("Bún cá cay Hải Phòng chả mực giòn", "Sáng", 45000, "Cá rô phi chiên giòn rụm ngập nước dùng cay ấm đất Cảng"),
                ("Bún chả cá Nha Trang sứa biển giòn", "Sáng", 45000, "Chả cá thu dai ngọt sứa tươi trong vắt nước lèo thanh ngọt"),
                ("Bún sườn chua mọc dọc mùng Hà Nội", "Sáng", 45000, "Nước canh sấu thanh chua dọc mùng giòn mát viên mọc béo"),
                ("Bún mọc nấm hương giò sống thanh vị", "Sáng", 40000, "Viên mọc nấm giòn thơm sườn heo ninh mềm nước dùng trong"),
                ("Bún thang phố cổ tinh hoa đất Tràng An", "Sáng", 55000, "Giò lụa trứng tráng gà xé sợi nấm hương thanh tao nhẹ nhàng"),
                ("Bún quậy Phú Quốc chả tôm mực tươi", "Sáng", 50000, "Chả tươi quậy trực tiếp tại tô nước chấm tắc ớt tự pha"),
                ("Bún nước lèo Sóc Trăng cá đồng thịt heo quay", "Trưa", 45000, "Hương ngải bún đặc trưng nước lèo thanh ngọt đậm đà"),
                ("Hủ tiếu Nam Vang thập cẩm khô sốt cay", "Sáng", 48000, "Sợi hủ tiếu dai thấm sốt tôm sú cật heo thịt bằm thơm lừng"),
                ("Hủ tiếu Sa Đéc sườn cọng nước trong", "Sáng", 45000, "Sợi bột Sa Đéc trứ danh sườn heo hầm mềm ngọt tủy xương"),
                ("Hủ tiếu Mỹ Tho sườn tôm mực giòn", "Sáng", 45000, "Sợi bánh dai trong chan nước lèo tôm khô mực nướng thơm nức"),
                ("Hủ tiếu dê sa tế cay nồng béo bùi", "Tối", 65000, "Thịt dê mềm ngậy nước sa tế cay ấm thơm lừng đậu phộng"),
                ("Bánh canh cua biển giò heo huyết mềm", "Sáng", 55000, "Nước súp gạch cua sánh sệt màu cam sợi bánh mềm dai"),
                ("Bánh canh ghẹ Muối Ớt Vũng Tàu", "Trưa", 65000, "Ghẹ tươi sống tách vỏ thịt ngọt chấm muối ớt xanh"),
                ("Bánh canh cá lóc bột gạo Quảng Trị", "Sáng", 40000, "Cá lóc đồng um thơm lừng sợi bột gạo cán tay dẻo ngọt"),
                ("Bánh canh Trảng Bàng giò heo rau rừng", "Sáng", 48000, "Bột gạo thơm lừng ăn kèm giò heo nạc chấm nước mắm tiêu"),
                ("Mì Quảng gà ta trứng cút bánh tráng mè", "Sáng", 45000, "Nước nhưn đậm đà rau bắp chuối đậu phộng rang giòn"),
                ("Mì Quảng tôm thịt sườn non xứ Quảng", "Trưa", 48000, "Tôm rim mặn ngọt sợi mì vàng nghệ ăn cùng bánh tráng giòn"),
                ("Cao lầu Hội An xá xíu tóp mỡ giòn", "Trưa", 48000, "Sợi mì ngâm tro củi giếng Bá Lễ thơm lừng xá xíu đậm vị"),
                ("Mì xào giòn hải sản tôm mực cải ngọt", "Trưa", 55000, "Vắt mì chiên phồng giòn tan chan ngập sốt hải sản nóng hổi"),
                ("Mì vịt tiềm thảo mộc nấm đông cô giòn da", "Tối", 85000, "Đùi vịt tiềm da giòn thơm nồng vị thuốc bắc bổ dưỡng"),
                ("Mì hoành thánh xá xíu nước dùng tôm khô", "Sáng", 45000, "Viên hoành thánh tôm thịt đầy đặn xá xíu mềm ngọt"),
                ("Bánh mì chảo xíu mại pate bơ thơm nức", "Sáng", 42000, "Trứng lòng đào pate gan béo ngậy chấm bánh mì giòn"),
                ("Bánh cuốn nóng tráng tay chả quế mộc nhĩ", "Sáng", 35000, "Bánh mỏng mướt nhân thịt mộc nhĩ hành phi thơm giòn"),
                ("Bánh ướt lòng gà trứng non Đà Lạt", "Sáng", 45000, "Bánh ướt dẻo mềm thịt gà xé lòng mề trứng non béo bùi"),
                ("Bánh hỏi thịt heo quay giòn bì bánh hỏi", "Sáng", 45000, "Heo quay nổ bì rụm rụm cuốn bánh hỏi thoa mỡ hành")
            };

            foreach (var item in phoBunList)
            {
                foodDatabase.Add(new FoodItem { Name = item.Item1, Category = "Món chính", Meal = item.Item2, Price = item.Item3, Description = item.Item4 });
            }

            var lauNuongList = new (string, string, int, string)[]
            {
                ("Lẩu gà lá é Tao Ngộ ớt hiểm xanh Đà Lạt", "Tối", 195000, "Thịt gà ta giòn dai thơm lừng lá é the the cay ấm bụng"),
                ("Lẩu gà tiềm ớt hiểm nấm đông cô thanh ngọt", "Tối", 210000, "Gà chiên săn hầm ớt hiểm nước dùng ngọt thanh đại bổ"),
                ("Lẩu Thái Tomyum hải sản tôm mực chua cay", "Tối", 230000, "Nước cốt dừa béo sả ớt hiểm tôm sú mực tươi ngọt lịm"),
                ("Lẩu riêu cua bắp bò hoa sườn sụn giòn", "Tối", 250000, "Váng riêu cua đồng thơm ngát nhúng bắp bò hoa sần sật"),
                ("Lẩu cá kèo lá giang hoa chuối bông súng", "Tối", 185000, "Cá kèo tươi bơi sống vị chua thanh của lá giang Nam Bộ"),
                ("Lẩu mắm cá linh bông điên điển mùa nước nổi", "Tối", 220000, "Hương mắm sặc mắm linh ngập tràn rau nhúng miệt vườn"),
                ("Lẩu dê thuốc bắc tiềm củ sen táo đỏ", "Tối", 260000, "Thịt dê núi mềm nhừ nước tiềm thảo mộc bổ dưỡng ấm người"),
                ("Lẩu bắp bò nhúng giấm cuốn bánh tráng rau rừng", "Tối", 200000, "Nước giấm táo chua dịu nhúng bắp bò mềm cuốn rau rừng"),
                ("Lẩu cua đồng hột vịt lộn sườn non nóng hổi", "Tối", 210000, "Vị ngọt từ cua đồng và vị béo bùi của trứng vịt lộn"),
                ("Lẩu cá đuối lá giang Vũng Tàu chua cay", "Tối", 190000, "Cá đuối sụn giòn ngọt nước lẩu chua cay ăn cùng bún tươi"),
                ("Lẩu vịt nấu chao Cần Thơ khoai môn dẻo", "Tối", 210000, "Chao đỏ thơm béo khoai môn bùi thịt vịt mềm ngậy"),
                ("Lẩu ếch măng cay sa tế thơm nồng", "Tối", 190000, "Thịt ếch đồng xào săn da giòn măng chua cay the kích thích"),
                ("Lẩu bò sa tế nấm kim châm đậu hũ non", "Tối", 220000, "Đuôi bò nạm bò gân giòn sần sật nước dùng cay nồng"),
                ("Bò tơ Tây Ninh nướng tảng than hoa thơm lừng", "Tối", 160000, "Thịt bò tơ mềm mọng nước nướng than chấm muối ớt chanh"),
                ("Bò nướng sốt hàu phô mai kéo sợi đút lò", "Tối", 145000, "Hàu sữa tươi mập béo bò mềm quyện phô mai béo ngậy"),
                ("Gà tre nướng muối ớt sốt tiêu rừng xanh", "Tối", 175000, "Da gà vàng giòn ươm đượm sốt tiêu xanh thơm nức"),
                ("Sườn cọng heo nướng tảng mật ong rừng", "Tối", 135000, "Sườn cọng mọng nước nướng xém cạnh mật ong vàng óng"),
                ("Dê nướng mọi than hồng chấm chao sa tế", "Tối", 155000, "Thịt dê tươi ướp dầu mè nướng than thơm ngọt tự nhiên"),
                ("Ốc hương nướng muối tuyết tiêu xanh Phú Quốc", "Tối", 95000, "Ốc hương giòn ngọt áo đều lớp muối sấy trắng giòn cay"),
                ("Hàu sữa nướng phô mai đút lò béo ngậy", "Tối", 75000, "Hàu béo ngậy ngập phô mai mozzarella chảy tràn"),
                ("Mực một nắng Phan Thiết nướng sa tế cay", "Tối", 130000, "Mực một nắng dày cơm thịt ngọt nướng vàng ruộm thơm"),
                ("Tôm càng xanh nướng than chấm muối tiêu chanh", "Tối", 180000, "Gạch tôm béo ngậy thịt tôm săn chắc ngọt ngào"),
                ("Sò điệp nướng mỡ hành đậu phộng tóp mỡ", "Tối", 65000, "Thịt sò béo ngọt chan ngập mỡ hành thơm nức"),
                ("Càng ghẹ sốt trứng muối hoàng kim béo mặn", "Tối", 95000, "Sốt trứng muối sánh mịn bọc quanh càng ghẹ tươi"),
                ("Bạch tuộc nướng sa tế giòn sần sật", "Tối", 85000, "Bạch tuộc tươi giòn cay the ướp sa tế nướng than hoa")
            };

            foreach (var item in lauNuongList)
            {
                foodDatabase.Add(new FoodItem { Name = item.Item1, Category = "Món chính", Meal = item.Item2, Price = item.Item3, Description = item.Item4 });
            }

            var anVatList = new (string, string, int, string)[]
            {
                ("Bánh tráng trộn bò khô trứng cút sốt tắc", "Chiều", 25000, "Bánh tráng dẻo ngấm sốt bò khô xoài chua đậu phộng"),
                ("Bánh tráng nướng phô mai xúc xích trứng gà", "Chiều", 25000, "Pizza Đà Lạt giòn rụm phết bơ béo hành lá thơm lừng"),
                ("Bánh tráng cuốn bơ sốt me chua ngọt", "Chiều", 22000, "Cuốn bánh tráng dẻo sốt bơ béo ngậy hành phi ruốc tôm"),
                ("Trứng cút lộn xào me sốt chua ngọt đậm vị", "Chiều", 30000, "Sốt me chua thanh sánh đặc ngập rau răm thơm nồng"),
                ("Bột chiên giòn rụm 2 trứng đu đủ bào sợi", "Chiều", 35000, "Bột vuông giòn vỏ mềm ruột chấm xì dầu chua ngọt"),
                ("Cá viên bò viên tôm viên chiên mắm bơ tỏi", "Chiều", 35000, "Xiên que chiên ngập sốt bơ tỏi thơm ngậy đường phố"),
                ("Nem chua rán giòn xù phố cổ Hà Nội", "Chiều", 35000, "Nem lăn bột chiên vàng rụm chấm tương ớt cay nồng"),
                ("Nem nướng Nha Trang cuộn ram giòn tương nếp", "Chiều", 50000, "Nem nướng than thơm lừng cuộn xoài dưa leo bánh tráng"),
                ("Bánh xèo miền Tây củ hũ dừa tép đồng giòn", "Chiều", 40000, "Vỏ vàng óng mỏng giòn cuộn rau cải non mắm tỏi ớt"),
                ("Bánh khọt Vũng Tàu tôm nhảy giòn rụm", "Chiều", 40000, "Bánh chiên viền mỏng giòn tôm tươi ăn cùng đồ chua"),
                ("Bánh bèo chén tôm cháy mỡ hành da heo giòn", "Chiều", 30000, "Khay bánh bèo nóng hổi nhân tôm thịt đậm vị Trung"),
                ("Bánh bột lọc Huế nhân tôm thịt đậm đà", "Chiều", 30000, "Vỏ bánh trong veo thấy rõ con tôm đỏ au chấm mắm ớt"),
                ("Bánh nậm lá chuối nhân tôm thịt mềm mướt", "Chiều", 25000, "Bánh nậm dẻo mềm thơm mùi lá chuối chấm nước mắm"),
                ("Gỏi cuốn tôm thịt tai heo tương nếp đậu phộng", "Chiều", 25000, "Cuốn tôm sú thịt ba rọi bún rau thơm chấm tương ngọt"),
                ("Bò bía mặn lạp xưởng tôm khô củ sắn tương đen", "Chiều", 20000, "Cuốn tròn củ sắn ngọt mát chấm tương ớt mè rang"),
                ("Bắp xào bơ tôm khô hành phi giòn tan", "Chiều", 25000, "Bắp hạt vàng óng xào bơ béo ngậy thơm nức góc phố"),
                ("Súp cua trứng bắc thảo gà xé nấm tuyết", "Chiều", 35000, "Chén súp nóng hổi sánh đặc đầy ắp thịt cua nấm tuyết"),
                ("Phá lấu bò nước cốt dừa bánh mì nóng giòn", "Chiều", 35000, "Lòng bò làm sạch ninh mềm nước cốt dừa béo mặn"),
                ("Khoai lang mật lắc bột phô mai giòn tan", "Chiều", 25000, "Khoai lang mật ngọt lịm áo lớp bột phô mai mằn mặn"),
                ("Chân gà rút xương ngâm sả tắc cóc non chua cay", "Chiều", 50000, "Chân gà giòn sần sật ngấm sốt sả tắc thơm mát"),
                ("Chuối nếp nướng nước cốt dừa mè rang dẻo", "Chiều", 20000, "Chuối sứ bọc xôi nếp nướng than hoa chan ngập cốt dừa"),
                ("Bánh chuối chiên giòn rụm mè đen đường thốt nốt", "Chiều", 15000, "Bánh chuối ép mỏng chiên phồng vàng ruộm giòn rụm"),
                ("Da heo chiên giòn lắc tỏi ớt sa tế cay", "Chiều", 25000, "Da heo xốp giòn cay the mặn mòi thích hợp ăn xế"),
                ("Gỏi xoài khô bò đen chua ngọt thơm ngon", "Chiều", 30000, "Xoài xanh băm sợi trộn khô bò ngập nước mắm chua ngọt"),
                ("Bánh tiêu xôi nếp hạt sen chiên phồng mè", "Chiều", 15000, "Vỏ bánh giòn xốp kẹp xôi nếp dẻo thơm rắc hạt sen")
            };

            foreach (var item in anVatList)
            {
                foodDatabase.Add(new FoodItem { Name = item.Item1, Category = "Ăn vặt", Meal = item.Item2, Price = item.Item3, Description = item.Item4 });
            }

            var doUongList = new (string, string, int, string)[]
            {
                ("Cà phê sữa đá Sài Gòn rang xay đậm vị", "Sáng", 25000, "Robusta nguyên chất pha phin hòa quyện sữa đặc béo"),
                ("Cà phê muối xứ Huế kem mặn béo ngậy", "Sáng", 28000, "Lớp kem muối sánh mịn hòa quyện vị cà phê đậm đà"),
                ("Cà phê trứng Hà Nội bồng bềnh ngậy bơ", "Sáng", 35000, "Lòng đỏ trứng đánh bông xốp mịn thơm nồng cà phê nóng"),
                ("Bạc xỉu ba tầng sữa dừa sương sa", "Sáng", 28000, "Ngọt ngào êm dịu cho buổi sáng nhiều sữa ít cà phê"),
                ("Trà đào cam sả thanh mát giải nhiệt", "Trưa", 35000, "Miếng đào giòn ngọt hương sả the mát và nước cam tươi"),
                ("Trà mãng cầu xiêm đười ươi hạt chia tươi mát", "Trưa", 35000, "Vị chua ngọt thanh nhã của mãng cầu chín cây"),
                ("Trà dâu tây Đà Lạt lắc đá mật ong", "Chiều", 30000, "Dâu tây tươi ngào đường lắc đá mát rượi đỏ au"),
                ("Trà vải kim quất nha đam hạt chia", "Trưa", 35000, "Trái vải mọng nước kết hợp vị quất thanh chua mát"),
                ("Trà sen vàng long nhãn kem sữa Macchiato", "Chiều", 42000, "Hạt sen bùi thơm nhãn lồng giòn ngọt lớp kem béo"),
                ("Trà sữa Ô Long nướng trân châu hoàng kim", "Chiều", 40000, "Hương trà rang đậm vị sữa béo ngậy trân châu dẻo thơm"),
                ("Trà lài sữa phô mai tươi trân châu trắng", "Chiều", 38000, "Hương hoa lài thanh khiết lớp kem phô mai béo ngậy"),
                ("Nước mía sầu riêng cốt dừa bọt tuyết", "Trưa", 20000, "Nước mía tươi thơm lừng cơm sầu riêng chín cây béo bùi"),
                ("Nước mía tắc giải khát truyền thống", "Trưa", 15000, "Vị ngọt tự nhiên của mía hòa quyện tinh dầu vỏ tắc"),
                ("Nước dừa xiêm gọt sọ Bến Tre ướp lạnh", "Trưa", 25000, "Nước dừa ngọt mát cơm dừa non mỏng dẻo thanh khiết"),
                ("Rau má đậu xanh sữa dừa mát gan", "Trưa", 25000, "Thanh lọc cơ thể giải độc ngày nắng gắt dân dã"),
                ("Nước ép cam sành mật ong hoa rừng nguyên chất", "Sáng", 30000, "Bổ sung lượng vitamin C dồi dào tăng cường đề kháng"),
                ("Nước ép ổi hồng ruby trân châu trắng giòn", "Chiều", 28000, "Màu hồng tự nhiên vị thanh ngọt dịu mát cho vóc dáng"),
                ("Nước ép táo cần tây dứa xanh detox dáng", "Sáng", 35000, "Thanh lọc cơ thể nhẹ nhàng giữ dáng đẹp da"),
                ("Sinh tố bơ sáp Đắk Lắk sữa đặc béo ngậy", "Chiều", 35000, "Trái bơ sáp dẻo quánh xay mịn béo ngậy thơm ngon"),
                ("Sinh tố xoài cát Chu chín cây ngọt lịm", "Chiều", 30000, "Hương xoài chín thơm ngát đặc sản vùng sông nước"),
                ("Sinh tố sapoche cà phê xay mịn bùi béo", "Chiều", 32000, "Hồng xiêm chín mọng thơm lừng quyện chút đắng cà phê"),
                ("Sữa đậu nành nguyên chất nấu lá dứa ấm", "Sáng", 15000, "Đậu nành thơm lành nấu lá dứa tươi ấm nóng buổi sớm"),
                ("Sữa bắp non ngọt thơm sánh mịn tự nhiên", "Sáng", 18000, "Hạt bắp non xay sánh dẻo thơm lừng vị đồng quê")
            };

            foreach (var item in doUongList)
            {
                foodDatabase.Add(new FoodItem { Name = item.Item1, Category = "Đồ uống", Meal = item.Item2, Price = item.Item3, Description = item.Item4 });
            }

            var traiCayCheList = new (string, string, int, string)[]
            {
                ("Chè bưởi An Giang cốt dừa béo ngậy", "Chiều", 20000, "Cùi bưởi giòn sần sật ngập nước đường thốt nốt"),
                ("Chè Thái sầu riêng thạch mít hạt lựu cốt dừa", "Chiều", 35000, "Thơm ngát múi sầu riêng tươi hòa quyện thạch mít nhãn"),
                ("Chè khúc bạch hạnh nhân thanh mát vải thiều", "Chiều", 35000, "Khúc bạch mềm dẻo hạnh nhân lát rang giòn nước đường phèn"),
                ("Tàu hũ trân châu đường thốt nốt cốt dừa ấm", "Chiều", 25000, "Tàu hũ mềm mịn tan trên đầu lưỡi ngập tràn sốt ấm"),
                ("Sữa chua nếp cẩm Điện Biên dẻo thơm", "Chiều", 25000, "Hạt nếp cẩm dẻo bùi quyện sữa chua lên men tự nhiên"),
                ("Trái cây tô dầm sữa chua ngũ cốc hạt chia", "Chiều", 40000, "Tô dưa hấu thanh long xoài bơ chan đẫm sữa chua bổ dưỡng"),
                ("Đĩa cóc xoài ổi mận lắc muối tôm Tây Ninh cay", "Chiều", 30000, "Trái cây giòn rụm ngấm đều muối tôm cay xè kích thích vị giác"),
                ("Xoài keo xanh giòn chấm mắm ruốc ớt hiểm", "Chiều", 25000, "Xoài chua giòn sần sật quết mắm ruốc xào cay nồng"),
                ("Mận hậu Sơn La xóc muối ớt đường chua ngọt", "Chiều", 35000, "Mận chín đỏ giòn ngọt nước chấm muối ớt cay"),
                ("Bưởi da xanh ruột hồng Bến Tre tách múi tươi", "Sáng", 45000, "Tép bưởi mọng nước ngọt thanh dịu nhẹ tốt cho sức khỏe"),
                ("Dưa hấu Long An ướp lạnh ngọt lịm mát lành", "Trưa", 20000, "Từng miếng dưa đỏ thắm ướp đá mát lạnh giải nhiệt"),
                ("Sầu riêng Ri6 Cái Mơn cơm vàng hạt lép", "Chiều", 95000, "Múi sầu riêng vàng ươm béo ngậy thơm lừng đặc sản Bến Tre"),
                ("Rau củ luộc thập cẩm chấm kho quẹt tôm khô", "Trưa", 45000, "Đậu bắp cà rốt bông cải luộc giòn ngọt quết kho quẹt"),
                ("Đậu bắp nướng mỡ hành chấm chao Sa Giang", "Tối", 30000, "Đậu bắp non nướng giòn ngọt chấm sốt chao ớt cay béo"),
                ("Salad rau mầm trứng gà luộc sốt dầu giấm", "Trưa", 35000, "Rau mầm tươi giòn thanh mát dầu giấm chua ngọt")
            };

            foreach (var item in traiCayCheList)
            {
                foodDatabase.Add(new FoodItem { Name = item.Item1, Category = "Rau củ / Trái cây", Meal = item.Item2, Price = item.Item3, Description = item.Item4 });
            }

            string[] regions = { "Hà Nội", "Xứ Huế", "Đà Nẵng", "Sài Gòn", "Cần Thơ", "Nha Trang", "Đà Lạt", "Hải Phòng", "Quảng Ninh", "Tây Bắc", "Bến Tre", "An Giang", "Phú Quốc" };
            string[] cookingStyles = { "truyền thống", "gia truyền", "đặc sản", "sốt cay", "nướng than hoa", "hầm thảo mộc", "chiên giòn rụm", "hấp gừng", "kho tộ", "om chuối đậu" };
            string[] mainProteins = { "bò tơ", "gà đồi", "thịt heo bản", "cá lăng", "tôm sú", "mực ống", "sườn non", "vịt cỏ", "cá chép giòn", "cua biển", "ếch đồng", "lươn đồng" };

            int genIdx = 0;
            while (foodDatabase.Count < 508)
            {
                string r = regions[genIdx % regions.Length];
                string c = cookingStyles[(genIdx / regions.Length) % cookingStyles.Length];
                string p = mainProteins[genIdx % mainProteins.Length];

                int typeCase = genIdx % 5;
                if (typeCase == 0)
                {
                    foodDatabase.Add(new FoodItem
                    {
                        Name = string.Format("Cơm {0} {1} {2}", p, c, r),
                        Category = "Món chính",
                        Meal = (genIdx % 2 == 0) ? "Trưa" : "Tối",
                        Price = 45000 + (genIdx % 5) * 5000,
                        Description = string.Format("Món cơm {0} nấu theo phong vị {1} đặc trưng vùng {2}, ăn kèm canh nóng.", p, c, r)
                    });
                }
                else if (typeCase == 1)
                {
                    foodDatabase.Add(new FoodItem
                    {
                        Name = string.Format("Bún {0} {1} phố {2}", p, c, r),
                        Category = "Món chính",
                        Meal = (genIdx % 3 == 0) ? "Sáng" : "Trưa",
                        Price = 40000 + (genIdx % 4) * 5000,
                        Description = string.Format("Bún tươi nước dùng ninh xương đậm vị kết hợp {0} {1} kiểu {2}.", p, c, r)
                    });
                }
                else if (typeCase == 2)
                {
                    foodDatabase.Add(new FoodItem
                    {
                        Name = string.Format("Lẩu {0} {1} phong cách {2}", p, c, r),
                        Category = "Món chính",
                        Meal = "Tối",
                        Price = 180000 + (genIdx % 6) * 15000,
                        Description = string.Format("Nồi lẩu {0} nóng hổi gia vị {1} tinh hoa ẩm thực vùng {2}.", p, c, r)
                    });
                }
                else if (typeCase == 3)
                {
                    foodDatabase.Add(new FoodItem
                    {
                        Name = string.Format("Món nhắm {0} {1} vùng {2}", p, c, r),
                        Category = "Ăn vặt",
                        Meal = "Chiều",
                        Price = 30000 + (genIdx % 5) * 5000,
                        Description = string.Format("Món ăn xế chiều lạ miệng từ {0} chế biến {1} đậm đà xứ {2}.", p, c, r)
                    });
                }
                else
                {
                    string[] drinks = { "Trà thảo mộc", "Trà trái cây dầm", "Nước ép tươi", "Sinh tố hoa quả", "Sữa chua hạt sen" };
                    string d = drinks[genIdx % drinks.Length];
                    foodDatabase.Add(new FoodItem
                    {
                        Name = string.Format("{0} {1} ({2})", d, r, (genIdx % 2 == 0 ? "Vị thanh mát" : "Vị ngọt bùi")),
                        Category = "Đồ uống",
                        Meal = (genIdx % 2 == 0) ? "Trưa" : "Chiều",
                        Price = 25000 + (genIdx % 4) * 5000,
                        Description = string.Format("Thức uống giải khát mát lành chiết xuất từ hoa quả và thảo mộc vùng {0}.", r)
                    });
                }

                genIdx++;
            }
        }

        private void InitTabKetAmThuc()
        {
            cboMealTime.Items.Clear();
            cboMealTime.Items.AddRange(new object[] { "Tất cả các bữa", "Sáng", "Trưa", "Chiều", "Tối" });
            cboMealTime.SelectedIndex = 0;

            cboCategory.Items.Clear();
            cboCategory.Items.AddRange(new object[] { "Tất cả thể loại", "Món chính", "Đồ uống", "Ăn vặt", "Rau củ / Trái cây" });
            cboCategory.SelectedIndex = 0;
        }

        private void btnOpenChest_Click(object sender, EventArgs e)
        {
            rtbChestResult.Clear();

            string selectedMeal = cboMealTime.SelectedItem.ToString();
            string selectedCat = cboCategory.SelectedItem.ToString();

            var query = foodDatabase.AsEnumerable();

            if (selectedMeal != "Tất cả các bữa")
            {
                query = query.Where(f => f.Meal == selectedMeal);
            }

            if (selectedCat != "Tất cả thể loại")
            {
                query = query.Where(f => f.Category == selectedCat);
            }

            List<FoodItem> filtered = query.ToList();
            if (filtered.Count == 0)
            {
                MessageBox.Show("Không tìm thấy món ăn phù hợp với bộ lọc hiện tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            FoodItem chosen = filtered[random.Next(filtered.Count)];

            rtbChestResult.AppendText("┌─────────────────────────────────────────────────────────────┐\r\n");
            rtbChestResult.AppendText(string.Format("│  ★ KẾT QUẢ KHAI MỞ KÉT: {0}\r\n", chosen.Name.ToUpper()));
            rtbChestResult.AppendText("├─────────────────────────────────────────────────────────────┤\r\n");
            rtbChestResult.AppendText(string.Format("  • Thể loại:       {0}\r\n", chosen.Category));
            rtbChestResult.AppendText(string.Format("  • Bữa ăn phù hợp: Bữa {0}\r\n", chosen.Meal));
            rtbChestResult.AppendText(string.Format("  • Giá tham khảo:  {0:#,##0} VNĐ\r\n", chosen.Price));
            rtbChestResult.AppendText("├─────────────────────────────────────────────────────────────┤\r\n");
            rtbChestResult.AppendText("  • Hương vị & Đặc sắc:\r\n");
            rtbChestResult.AppendText(string.Format("    {0}\r\n", chosen.Description));
            rtbChestResult.AppendText("└─────────────────────────────────────────────────────────────┘\r\n");
        }

        private void btnDrawFortune_Click(object sender, EventArgs e)
        {
            rtbFortuneResult.Clear();

            string[] fortuneNames = {
                "QUẺ THƯỢNG CÁT - VẠN SỰ VỪA MIỆNG",
                "QUẺ DUYÊN VỊ - TÂM HỒN ĐỒNG ĐIỆU",
                "QUẺ ĐẠI CÁT - BỮA ĂN TRÒN VỊ",
                "QUẺ AN LÀNH - THƠM THẢO BỐN PHƯƠNG",
                "QUẺ HỶ VỊ - HẠNH PHÚC TỪNG MIẾNG CƠM"
            };

            string[] fortunePoems = {
                "\"Gió đưa cành trúc la đà, hôm nay ăn no chiều về thảnh thơi.\"",
                "\"Lắc quẻ tìm duyên, thấy món này ngon liền đặt ngay không đắn đo.\"",
                "\"Có thực mới vực được đạo, thưởng thức món ngon lòng liền nở hoa.\"",
                "\"Cuộc đời có lúc thăng trầm, nhưng đồ ăn ngon thì luôn chân thật.\"",
                "\"Mỗi món ngon một tâm hồn, hôm nay thưởng vị ấm nồng con tim.\""
            };

            int fIdx = random.Next(fortuneNames.Length);
            FoodItem chosen = foodDatabase[random.Next(foodDatabase.Count)];

            rtbFortuneResult.AppendText("╔═════════════════════════════════════════════════════════════╗\r\n");
            rtbFortuneResult.AppendText(string.Format("║   🎋 {0}\r\n", fortuneNames[fIdx]));
            rtbFortuneResult.AppendText("╠═════════════════════════════════════════════════════════════╣\r\n");
            rtbFortuneResult.AppendText(string.Format("  Lời quẻ chỉ lối:\r\n  {0}\r\n\r\n", fortunePoems[fIdx]));
            rtbFortuneResult.AppendText(string.Format("  MÓN QUẺ BAN CHO:   {0}\r\n", chosen.Name.ToUpper()));
            rtbFortuneResult.AppendText(string.Format("  Thể loại món:      {0} (Bữa {1})\r\n", chosen.Category, chosen.Meal));
            rtbFortuneResult.AppendText(string.Format("  Mức giá tham khảo: {0:#,##0} VNĐ\r\n", chosen.Price));
            rtbFortuneResult.AppendText("├─────────────────────────────────────────────────────────────┤\r\n");
            rtbFortuneResult.AppendText(string.Format("  Lời khuyên ẩm thực: {0}\r\n", chosen.Description));
            rtbFortuneResult.AppendText("╚═════════════════════════════════════════════════════════════╝\r\n");
        }

        private void InitTabTimQuan()
        {
            cboCity.Items.Clear();
            foreach (string prov in all34Provinces)
            {
                cboCity.Items.Add(prov);
            }
            cboCity.SelectedIndex = -1;
            cboCity.Text = "";

            cboWard.Items.Clear();
            cboWard.SelectedIndex = -1;
            cboWard.Text = "";

            cboStreet.Items.Clear();
            cboStreet.SelectedIndex = -1;
            cboStreet.Text = "";
        }

        private void cboWard_DropDown(object sender, EventArgs e)
        {
            if (cboCity.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn Tỉnh/Thành phố trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboCity.Focus();
            }
        }

        private void cboStreet_DropDown(object sender, EventArgs e)
        {
            if (cboCity.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn Tỉnh/Thành phố trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboCity.Focus();
                return;
            }

            if (cboWard.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn Phường/Xã trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboWard.Focus();
            }
        }

        private void cboCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCity.SelectedItem == null) return;
            string city = cboCity.SelectedItem.ToString();
            LoadWardsForCity(city);
        }

        private void LoadWardsForCity(string city)
        {
            cboWard.Items.Clear();
            cboStreet.Items.Clear();
            cboWard.SelectedIndex = -1;
            cboWard.Text = "";
            cboStreet.SelectedIndex = -1;
            cboStreet.Text = "";

            if (city == "TP. Hồ Chí Minh")
            {
                foreach (string w in hcmc168Wards)
                {
                    cboWard.Items.Add(w);
                }
            }
            else if (city == "Hà Nội")
            {
                cboWard.Items.AddRange(new object[] {
                    "Quận Hoàn Kiếm - Phường Hàng Trống", "Quận Hoàn Kiếm - Phường Tràng Tiền", "Quận Hoàn Kiếm - Phường Hàng Bạc",
                    "Quận Ba Đình - Phường Kim Mã", "Quận Ba Đình - Phường Giảng Võ", "Quận Cầu Giấy - Phường Dịch Vọng Hậu",
                    "Quận Cầu Giấy - Phường Nghĩa Đô", "Quận Đống Đa - Phường Ô Chợ Dừa", "Quận Hai Bà Trưng - Phường Bách Khoa"
                });
            }
            else if (city == "Đà Nẵng")
            {
                cboWard.Items.AddRange(new object[] {
                    "Quận Hải Châu - Phường Hải Châu 1", "Quận Hải Châu - Phường Hải Châu 2", "Quận Hải Châu - Phường Thạch Thang",
                    "Quận Sơn Trà - Phường An Hải Bắc", "Quận Sơn Trà - Phường Phước Mỹ", "Quận Ngũ Hành Sơn - Phường Mỹ An"
                });
            }
            else
            {
                cboWard.Items.AddRange(new object[] {
                    "Phường 1 (Trung tâm Hành chính)",
                    "Phường 2 (Khu Đô thị Mới)",
                    "Phường 3 (Khu Dân cư Thương mại)",
                    "Phường An Bình",
                    "Xã Nông Thôn Mới Kiểu Mẫu"
                });
            }
        }

        private void cboWard_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboWard.SelectedItem == null) return;
            LoadStreetsForWard(cboWard.SelectedItem.ToString());
        }

        private void LoadStreetsForWard(string ward)
        {
            cboStreet.Items.Clear();
            cboStreet.SelectedIndex = -1;
            cboStreet.Text = "";

            if (streetData.ContainsKey(ward))
            {
                foreach (string st in streetData[ward])
                {
                    cboStreet.Items.Add(st);
                }
            }
            else
            {
                cboStreet.Items.AddRange(new object[] {
                    "Đường Trục Chính Tuyến 1",
                    "Đường Nguyễn Huệ",
                    "Đường Trần Hưng Đạo",
                    "Đường Hẻm 12 Liên Khu",
                    "Đường Hẻm 68 Thông Thoáng"
                });
            }
        }

        private void btnFindNearShops_Click(object sender, EventArgs e)
        {
            if (cboCity.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn Tỉnh/Thành phố trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboCity.Focus();
                return;
            }

            if (cboWard.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn Phường/Xã trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboWard.Focus();
                return;
            }

            if (cboStreet.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn Đường/Hẻm trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboStreet.Focus();
                return;
            }

            string dish = txtSearchFood.Text.Trim();
            if (string.IsNullOrEmpty(dish))
            {
                MessageBox.Show("Vui lòng nhập tên món ăn cần tìm quán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSearchFood.Focus();
                return;
            }

            string city = cboCity.SelectedItem.ToString();
            string ward = cboWard.SelectedItem.ToString();
            string street = cboStreet.SelectedItem.ToString();

            rtbNearShops.Clear();
            rtbNearShops.AppendText(string.Format("📍 CÁC QUÁN '{0}' GẦN KHU VỰC CỦA BẠN:\r\n", dish.ToUpper()));
            rtbNearShops.AppendText(string.Format("Địa chỉ khảo sát: {0}, {1}, {2}\r\n", street, ward, city));
            rtbNearShops.AppendText("═════════════════════════════════════════════════════════════\r\n");
            rtbNearShops.AppendText(string.Format("1. Quán {0} Cô Ba - Số 45 {1}, {2}\r\n", dish, street, ward));
            rtbNearShops.AppendText(string.Format("   • Đánh giá: 4.8★ (Hơn 500 lượt đánh giá tích cực trên Google Maps)\r\n"));
            rtbNearShops.AppendText(string.Format("   • Mức giá: 35.000đ - 65.000đ | Giờ mở cửa: 06:30 - 22:00\r\n\r\n"));

            rtbNearShops.AppendText(string.Format("2. {0} Gia Truyền 1985 - Mặt tiền {1}, {2}\r\n", dish, street, ward));
            rtbNearShops.AppendText(string.Format("   • Đánh giá: 4.7★ (Quán lâu đời, công thức nêm nếm đậm đà chuẩn vị)\r\n"));
            rtbNearShops.AppendText(string.Format("   • Mức giá: 40.000đ - 70.000đ | Giờ mở cửa: 07:00 - 21:30\r\n\r\n"));

            rtbNearShops.AppendText(string.Format("3. Bếp Ăn Hoàng Kim ({0}) - Gần ngã ba {1}\r\n", dish, street));
            rtbNearShops.AppendText(string.Format("   • Đánh giá: 4.9★ (Phục vụ nhanh nhẹn, không gian sạch sẽ thoáng mát)\r\n"));
            rtbNearShops.AppendText(string.Format("   • Mức giá: 45.000đ - 85.000đ | Giờ mở cửa: Mở cả ngày\r\n"));
            rtbNearShops.AppendText("═════════════════════════════════════════════════════════════\r\n");
            rtbNearShops.AppendText("👉 Nhấn 'Mở trên Google Maps' để bật chỉ đường trực tiếp qua GPS xe máy/ô tô.\r\n");
        }

        private void btnOpenGoogleMaps_Click(object sender, EventArgs e)
        {
            string city = cboCity.SelectedItem != null ? cboCity.SelectedItem.ToString() : "";
            string ward = cboWard.SelectedItem != null ? cboWard.SelectedItem.ToString() : "";
            string street = cboStreet.SelectedItem != null ? cboStreet.SelectedItem.ToString() : "";
            string dish = txtSearchFood.Text.Trim();

            string query = string.Format("quán {0} {1} {2} {3}", dish, street, ward, city).Trim();
            string url = "https://www.google.com/maps/search/" + Uri.EscapeDataString(query);

            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể mở trình duyệt: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitTabMenuTong()
        {
            dgvAllFoods.Columns.Clear();
            dgvAllFoods.Columns.Add("STT", "STT");
            dgvAllFoods.Columns.Add("Name", "Tên món / Đồ uống");
            dgvAllFoods.Columns.Add("Category", "Thể loại");
            dgvAllFoods.Columns.Add("Meal", "Bữa ăn");
            dgvAllFoods.Columns.Add("Price", "Giá tham khảo (VNĐ)");

            dgvAllFoods.Columns["STT"].FillWeight = 18;
            dgvAllFoods.Columns["Name"].FillWeight = 95;
            dgvAllFoods.Columns["Category"].FillWeight = 42;
            dgvAllFoods.Columns["Meal"].FillWeight = 28;
            dgvAllFoods.Columns["Price"].FillWeight = 48;

            RenderMenuGrid(foodDatabase);
        }

        private void RenderMenuGrid(List<FoodItem> list)
        {
            dgvAllFoods.Rows.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                var item = list[i];
                dgvAllFoods.Rows.Add(i + 1, item.Name, item.Category, item.Meal, item.Price.ToString("#,##0") + " đ");
            }
        }

        private void txtSearchMenu_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearchMenu.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(keyword))
            {
                RenderMenuGrid(foodDatabase);
            }
            else
            {
                var filtered = foodDatabase.Where(f => f.Name.ToLower().Contains(keyword) || f.Category.ToLower().Contains(keyword) || f.Meal.ToLower().Contains(keyword)).ToList();
                RenderMenuGrid(filtered);
            }
        }
    }
}