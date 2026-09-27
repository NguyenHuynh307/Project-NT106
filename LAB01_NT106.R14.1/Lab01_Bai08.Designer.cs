namespace Lab01
{
    partial class Lab01_Bai08
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            pnlTopBanner = new Panel();
            lblHeaderTitle = new Label();
            lblHeaderSub = new Label();
            pnlNavBar = new Panel();
            btnNavFav = new Button();
            btnNavChest = new Button();
            btnNavFortune = new Button();
            btnNavMaps = new Button();
            btnNavMenu = new Button();
            tabControl = new TabControl();
            tabLab01 = new TabPage();
            pnlFavCard = new Panel();
            lblFavoriteTitle = new Label();
            lblDishInput = new Label();
            txtNewDish = new TextBox();
            btnQuickFill = new Button();
            btnAddFavorite = new Button();
            btnDeleteFavorite = new Button();
            lblListTitle = new Label();
            lstFavoriteDishes = new ListBox();
            btnFindDish = new Button();
            btnClearFavorite = new Button();
            btnExitFavorite = new Button();
            pnlResultCard = new Panel();
            lblTodayBanner = new Label();
            lblSelectedDish = new Label();
            tabKetAmThuc = new TabPage();
            pnlChestCard = new Panel();
            lblChestHeader = new Label();
            lblFilterMeal = new Label();
            cboMealTime = new ComboBox();
            lblFilterCategory = new Label();
            cboCategory = new ComboBox();
            btnOpenChest = new Button();
            rtbChestResult = new RichTextBox();
            tabBocQue = new TabPage();
            pnlFortuneCard = new Panel();
            lblFortuneHeader = new Label();
            lblQueDesc = new Label();
            btnDrawFortune = new Button();
            rtbFortuneResult = new RichTextBox();
            tabTimQuan = new TabPage();
            pnlMapCard = new Panel();
            lblMapHeader = new Label();
            lblCity = new Label();
            cboCity = new ComboBox();
            lblWard = new Label();
            cboWard = new ComboBox();
            lblStreet = new Label();
            cboStreet = new ComboBox();
            lblSearchDish = new Label();
            txtSearchFood = new TextBox();
            btnFindNearShops = new Button();
            btnOpenGoogleMaps = new Button();
            rtbNearShops = new RichTextBox();
            tabMenuTong = new TabPage();
            pnlMenuCard = new Panel();
            lblMenuCount = new Label();
            lblSearchMenu = new Label();
            txtSearchMenu = new TextBox();
            dgvAllFoods = new DataGridView();
            pnlTopBanner.SuspendLayout();
            pnlNavBar.SuspendLayout();
            tabControl.SuspendLayout();
            tabLab01.SuspendLayout();
            pnlFavCard.SuspendLayout();
            pnlResultCard.SuspendLayout();
            tabKetAmThuc.SuspendLayout();
            pnlChestCard.SuspendLayout();
            tabBocQue.SuspendLayout();
            pnlFortuneCard.SuspendLayout();
            tabTimQuan.SuspendLayout();
            pnlMapCard.SuspendLayout();
            tabMenuTong.SuspendLayout();
            pnlMenuCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAllFoods).BeginInit();
            SuspendLayout();
            // 
            // pnlTopBanner
            // 
            pnlTopBanner.BackColor = Color.White;
            pnlTopBanner.Controls.Add(lblHeaderTitle);
            pnlTopBanner.Controls.Add(lblHeaderSub);
            pnlTopBanner.Dock = DockStyle.Top;
            pnlTopBanner.Location = new Point(0, 0);
            pnlTopBanner.Margin = new Padding(4, 5, 4, 5);
            pnlTopBanner.Name = "pnlTopBanner";
            pnlTopBanner.Size = new Size(1250, 100);
            pnlTopBanner.TabIndex = 0;
            // 
            // lblHeaderTitle
            // 
            lblHeaderTitle.AutoSize = true;
            lblHeaderTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblHeaderTitle.ForeColor = Color.FromArgb(15, 23, 42);
            lblHeaderTitle.Location = new Point(28, 14);
            lblHeaderTitle.Margin = new Padding(4, 0, 4, 0);
            lblHeaderTitle.Name = "lblHeaderTitle";
            lblHeaderTitle.Size = new Size(473, 38);
            lblHeaderTitle.TabIndex = 0;
            lblHeaderTitle.Text = "🍲 Khám phá món ngon hôm nay!";
            // 
            // lblHeaderSub
            // 
            lblHeaderSub.AutoSize = true;
            lblHeaderSub.Font = new Font("Segoe UI", 9.5F);
            lblHeaderSub.ForeColor = Color.FromArgb(100, 116, 139);
            lblHeaderSub.Location = new Point(30, 59);
            lblHeaderSub.Margin = new Padding(4, 0, 4, 0);
            lblHeaderSub.Name = "lblHeaderSub";
            lblHeaderSub.Size = new Size(536, 25);
            lblHeaderSub.TabIndex = 1;
            lblHeaderSub.Text = "Gợi ý món ăn theo khẩu vị, thời điểm và tìm quán gần nhà bạn";
            // 
            // pnlNavBar
            // 
            pnlNavBar.BackColor = Color.FromArgb(241, 245, 249);
            pnlNavBar.Controls.Add(btnNavFav);
            pnlNavBar.Controls.Add(btnNavChest);
            pnlNavBar.Controls.Add(btnNavFortune);
            pnlNavBar.Controls.Add(btnNavMaps);
            pnlNavBar.Controls.Add(btnNavMenu);
            pnlNavBar.Dock = DockStyle.Top;
            pnlNavBar.Location = new Point(0, 100);
            pnlNavBar.Margin = new Padding(4, 5, 4, 5);
            pnlNavBar.Name = "pnlNavBar";
            pnlNavBar.Padding = new Padding(15, 9, 15, 9);
            pnlNavBar.Size = new Size(1250, 75);
            pnlNavBar.TabIndex = 1;
            // 
            // btnNavFav
            // 
            btnNavFav.BackColor = Color.FromArgb(37, 99, 235);
            btnNavFav.FlatAppearance.BorderSize = 0;
            btnNavFav.FlatStyle = FlatStyle.Flat;
            btnNavFav.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnNavFav.ForeColor = Color.White;
            btnNavFav.Location = new Point(15, 9);
            btnNavFav.Margin = new Padding(4, 5, 4, 5);
            btnNavFav.Name = "btnNavFav";
            btnNavFav.Size = new Size(231, 56);
            btnNavFav.TabIndex = 0;
            btnNavFav.Text = "★ Món ưa thích (Lab 01)";
            btnNavFav.UseVisualStyleBackColor = false;
            // 
            // btnNavChest
            // 
            btnNavChest.BackColor = Color.White;
            btnNavChest.FlatAppearance.BorderSize = 0;
            btnNavChest.FlatStyle = FlatStyle.Flat;
            btnNavChest.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnNavChest.ForeColor = Color.FromArgb(71, 85, 105);
            btnNavChest.Location = new Point(254, 9);
            btnNavChest.Margin = new Padding(4, 5, 4, 5);
            btnNavChest.Name = "btnNavChest";
            btnNavChest.Size = new Size(244, 56);
            btnNavChest.TabIndex = 1;
            btnNavChest.Text = "☖ Két ẩm thực (Theo bữa)";
            btnNavChest.UseVisualStyleBackColor = false;
            // 
            // btnNavFortune
            // 
            btnNavFortune.BackColor = Color.White;
            btnNavFortune.FlatAppearance.BorderSize = 0;
            btnNavFortune.FlatStyle = FlatStyle.Flat;
            btnNavFortune.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnNavFortune.ForeColor = Color.FromArgb(71, 85, 105);
            btnNavFortune.Location = new Point(505, 9);
            btnNavFortune.Margin = new Padding(4, 5, 4, 5);
            btnNavFortune.Name = "btnNavFortune";
            btnNavFortune.Size = new Size(225, 56);
            btnNavFortune.TabIndex = 2;
            btnNavFortune.Text = "\U0001f9e7 Bóc quẻ ẩm thực";
            btnNavFortune.UseVisualStyleBackColor = false;
            // 
            // btnNavMaps
            // 
            btnNavMaps.BackColor = Color.White;
            btnNavMaps.FlatAppearance.BorderSize = 0;
            btnNavMaps.FlatStyle = FlatStyle.Flat;
            btnNavMaps.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnNavMaps.ForeColor = Color.FromArgb(71, 85, 105);
            btnNavMaps.Location = new Point(738, 9);
            btnNavMaps.Margin = new Padding(4, 5, 4, 5);
            btnNavMaps.Name = "btnNavMaps";
            btnNavMaps.Size = new Size(231, 56);
            btnNavMaps.TabIndex = 3;
            btnNavMaps.Text = "📍 Quán gần nhà (Maps)";
            btnNavMaps.UseVisualStyleBackColor = false;
            // 
            // btnNavMenu
            // 
            btnNavMenu.BackColor = Color.White;
            btnNavMenu.FlatAppearance.BorderSize = 0;
            btnNavMenu.FlatStyle = FlatStyle.Flat;
            btnNavMenu.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnNavMenu.ForeColor = Color.FromArgb(71, 85, 105);
            btnNavMenu.Location = new Point(976, 9);
            btnNavMenu.Margin = new Padding(4, 5, 4, 5);
            btnNavMenu.Name = "btnNavMenu";
            btnNavMenu.Size = new Size(244, 56);
            btnNavMenu.TabIndex = 4;
            btnNavMenu.Text = "📖 Kho 500+ Món & Giá";
            btnNavMenu.UseVisualStyleBackColor = false;
            // 
            // tabControl
            // 
            tabControl.Appearance = TabAppearance.FlatButtons;
            tabControl.Controls.Add(tabLab01);
            tabControl.Controls.Add(tabKetAmThuc);
            tabControl.Controls.Add(tabBocQue);
            tabControl.Controls.Add(tabTimQuan);
            tabControl.Controls.Add(tabMenuTong);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Font = new Font("Segoe UI", 10F);
            tabControl.ItemSize = new Size(0, 1);
            tabControl.Location = new Point(0, 175);
            tabControl.Margin = new Padding(4, 5, 4, 5);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1250, 856);
            tabControl.SizeMode = TabSizeMode.Fixed;
            tabControl.TabIndex = 2;
            // 
            // tabLab01
            // 
            tabLab01.BackColor = Color.FromArgb(241, 245, 249);
            tabLab01.Controls.Add(pnlFavCard);
            tabLab01.Location = new Point(4, 5);
            tabLab01.Margin = new Padding(4, 5, 4, 5);
            tabLab01.Name = "tabLab01";
            tabLab01.Padding = new Padding(15, 19, 15, 19);
            tabLab01.Size = new Size(1242, 847);
            tabLab01.TabIndex = 0;
            tabLab01.Text = "Tab1";
            // 
            // pnlFavCard
            // 
            pnlFavCard.BackColor = Color.White;
            pnlFavCard.BorderStyle = BorderStyle.FixedSingle;
            pnlFavCard.Controls.Add(lblFavoriteTitle);
            pnlFavCard.Controls.Add(lblDishInput);
            pnlFavCard.Controls.Add(txtNewDish);
            pnlFavCard.Controls.Add(btnQuickFill);
            pnlFavCard.Controls.Add(btnAddFavorite);
            pnlFavCard.Controls.Add(btnDeleteFavorite);
            pnlFavCard.Controls.Add(lblListTitle);
            pnlFavCard.Controls.Add(lstFavoriteDishes);
            pnlFavCard.Controls.Add(btnFindDish);
            pnlFavCard.Controls.Add(btnClearFavorite);
            pnlFavCard.Controls.Add(btnExitFavorite);
            pnlFavCard.Controls.Add(pnlResultCard);
            pnlFavCard.Dock = DockStyle.Fill;
            pnlFavCard.Location = new Point(15, 19);
            pnlFavCard.Margin = new Padding(4, 5, 4, 5);
            pnlFavCard.Name = "pnlFavCard";
            pnlFavCard.Size = new Size(1212, 809);
            pnlFavCard.TabIndex = 0;
            // 
            // lblFavoriteTitle
            // 
            lblFavoriteTitle.AutoSize = true;
            lblFavoriteTitle.Font = new Font("Segoe UI", 13.5F, FontStyle.Bold);
            lblFavoriteTitle.ForeColor = Color.FromArgb(30, 41, 59);
            lblFavoriteTitle.Location = new Point(406, 19);
            lblFavoriteTitle.Margin = new Padding(4, 0, 4, 0);
            lblFavoriteTitle.Name = "lblFavoriteTitle";
            lblFavoriteTitle.Size = new Size(354, 37);
            lblFavoriteTitle.TabIndex = 0;
            lblFavoriteTitle.Text = "HÔM NAY ĂN GÌ? - LAB 01";
            // 
            // lblDishInput
            // 
            lblDishInput.AutoSize = true;
            lblDishInput.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDishInput.Location = new Point(44, 97);
            lblDishInput.Margin = new Padding(4, 0, 4, 0);
            lblDishInput.Name = "lblDishInput";
            lblDishInput.Size = new Size(145, 28);
            lblDishInput.TabIndex = 1;
            lblDishInput.Text = "Nhập món ăn:";
            // 
            // txtNewDish
            // 
            txtNewDish.Font = new Font("Segoe UI", 10.5F);
            txtNewDish.Location = new Point(206, 91);
            txtNewDish.Margin = new Padding(4, 5, 4, 5);
            txtNewDish.Name = "txtNewDish";
            txtNewDish.Size = new Size(330, 35);
            txtNewDish.TabIndex = 2;
            // 
            // btnQuickFill
            // 
            btnQuickFill.BackColor = Color.FromArgb(241, 245, 249);
            btnQuickFill.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnQuickFill.FlatStyle = FlatStyle.Flat;
            btnQuickFill.Font = new Font("Segoe UI", 9F);
            btnQuickFill.ForeColor = Color.FromArgb(71, 85, 105);
            btnQuickFill.Location = new Point(206, 150);
            btnQuickFill.Margin = new Padding(4, 5, 4, 5);
            btnQuickFill.Name = "btnQuickFill";
            btnQuickFill.Size = new Size(162, 50);
            btnQuickFill.TabIndex = 3;
            btnQuickFill.Text = "Ăn gì cũng được";
            btnQuickFill.UseVisualStyleBackColor = false;
            // 
            // btnAddFavorite
            // 
            btnAddFavorite.BackColor = Color.FromArgb(37, 99, 235);
            btnAddFavorite.FlatAppearance.BorderSize = 0;
            btnAddFavorite.FlatStyle = FlatStyle.Flat;
            btnAddFavorite.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAddFavorite.ForeColor = Color.White;
            btnAddFavorite.Location = new Point(381, 147);
            btnAddFavorite.Margin = new Padding(4, 5, 4, 5);
            btnAddFavorite.Name = "btnAddFavorite";
            btnAddFavorite.Size = new Size(156, 56);
            btnAddFavorite.TabIndex = 4;
            btnAddFavorite.Text = "✚ Thêm";
            btnAddFavorite.UseVisualStyleBackColor = false;
            // 
            // btnDeleteFavorite
            // 
            btnDeleteFavorite.BackColor = Color.FromArgb(225, 29, 72);
            btnDeleteFavorite.FlatAppearance.BorderSize = 0;
            btnDeleteFavorite.FlatStyle = FlatStyle.Flat;
            btnDeleteFavorite.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDeleteFavorite.ForeColor = Color.White;
            btnDeleteFavorite.Location = new Point(619, 375);
            btnDeleteFavorite.Margin = new Padding(4, 5, 4, 5);
            btnDeleteFavorite.Name = "btnDeleteFavorite";
            btnDeleteFavorite.Size = new Size(206, 53);
            btnDeleteFavorite.TabIndex = 5;
            btnDeleteFavorite.Text = "✖ Xóa món đã chọn";
            btnDeleteFavorite.UseVisualStyleBackColor = false;
            // 
            // lblListTitle
            // 
            lblListTitle.AutoSize = true;
            lblListTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblListTitle.ForeColor = Color.FromArgb(30, 41, 59);
            lblListTitle.Location = new Point(619, 97);
            lblListTitle.Margin = new Padding(4, 0, 4, 0);
            lblListTitle.Name = "lblListTitle";
            lblListTitle.Size = new Size(276, 28);
            lblListTitle.TabIndex = 6;
            lblListTitle.Text = "Danh sách món ăn ưa thích:";
            // 
            // lstFavoriteDishes
            // 
            lstFavoriteDishes.BorderStyle = BorderStyle.FixedSingle;
            lstFavoriteDishes.Font = new Font("Segoe UI", 10F);
            lstFavoriteDishes.FormattingEnabled = true;
            lstFavoriteDishes.Location = new Point(619, 141);
            lstFavoriteDishes.Margin = new Padding(4, 5, 4, 5);
            lstFavoriteDishes.Name = "lstFavoriteDishes";
            lstFavoriteDishes.Size = new Size(537, 198);
            lstFavoriteDishes.TabIndex = 7;
            // 
            // btnFindDish
            // 
            btnFindDish.BackColor = Color.FromArgb(16, 185, 129);
            btnFindDish.FlatAppearance.BorderSize = 0;
            btnFindDish.FlatStyle = FlatStyle.Flat;
            btnFindDish.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnFindDish.ForeColor = Color.White;
            btnFindDish.Location = new Point(44, 242);
            btnFindDish.Margin = new Padding(4, 5, 4, 5);
            btnFindDish.Name = "btnFindDish";
            btnFindDish.Size = new Size(219, 75);
            btnFindDish.TabIndex = 8;
            btnFindDish.Text = "🍽 Tìm món ăn";
            btnFindDish.UseVisualStyleBackColor = false;
            // 
            // btnClearFavorite
            // 
            btnClearFavorite.BackColor = Color.FromArgb(100, 116, 139);
            btnClearFavorite.FlatAppearance.BorderSize = 0;
            btnClearFavorite.FlatStyle = FlatStyle.Flat;
            btnClearFavorite.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnClearFavorite.ForeColor = Color.White;
            btnClearFavorite.Location = new Point(281, 242);
            btnClearFavorite.Margin = new Padding(4, 5, 4, 5);
            btnClearFavorite.Name = "btnClearFavorite";
            btnClearFavorite.Size = new Size(125, 75);
            btnClearFavorite.TabIndex = 9;
            btnClearFavorite.Text = "Xóa";
            btnClearFavorite.UseVisualStyleBackColor = false;
            // 
            // btnExitFavorite
            // 
            btnExitFavorite.BackColor = Color.FromArgb(239, 68, 68);
            btnExitFavorite.FlatAppearance.BorderSize = 0;
            btnExitFavorite.FlatStyle = FlatStyle.Flat;
            btnExitFavorite.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnExitFavorite.ForeColor = Color.White;
            btnExitFavorite.Location = new Point(419, 242);
            btnExitFavorite.Margin = new Padding(4, 5, 4, 5);
            btnExitFavorite.Name = "btnExitFavorite";
            btnExitFavorite.Size = new Size(119, 75);
            btnExitFavorite.TabIndex = 10;
            btnExitFavorite.Text = "Thoát";
            btnExitFavorite.UseVisualStyleBackColor = false;
            // 
            // pnlResultCard
            // 
            pnlResultCard.BackColor = Color.FromArgb(248, 250, 252);
            pnlResultCard.BorderStyle = BorderStyle.FixedSingle;
            pnlResultCard.Controls.Add(lblTodayBanner);
            pnlResultCard.Controls.Add(lblSelectedDish);
            pnlResultCard.Location = new Point(44, 461);
            pnlResultCard.Margin = new Padding(4, 5, 4, 5);
            pnlResultCard.Name = "pnlResultCard";
            pnlResultCard.Size = new Size(1112, 304);
            pnlResultCard.TabIndex = 11;
            // 
            // lblTodayBanner
            // 
            lblTodayBanner.AutoSize = true;
            lblTodayBanner.Font = new Font("Segoe UI", 11.5F, FontStyle.Bold);
            lblTodayBanner.ForeColor = Color.FromArgb(71, 85, 105);
            lblTodayBanner.Location = new Point(412, 28);
            lblTodayBanner.Margin = new Padding(4, 0, 4, 0);
            lblTodayBanner.Name = "lblTodayBanner";
            lblTodayBanner.Size = new Size(258, 31);
            lblTodayBanner.TabIndex = 0;
            lblTodayBanner.Text = "Món ăn hôm nay ăn là:";
            // 
            // lblSelectedDish
            // 
            lblSelectedDish.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblSelectedDish.ForeColor = Color.FromArgb(185, 28, 28);
            lblSelectedDish.Location = new Point(25, 91);
            lblSelectedDish.Margin = new Padding(4, 0, 4, 0);
            lblSelectedDish.Name = "lblSelectedDish";
            lblSelectedDish.Size = new Size(1062, 172);
            lblSelectedDish.TabIndex = 1;
            lblSelectedDish.Text = "Chưa có gợi ý. Hãy nhấn nút tìm món!";
            lblSelectedDish.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tabKetAmThuc
            // 
            tabKetAmThuc.BackColor = Color.FromArgb(241, 245, 249);
            tabKetAmThuc.Controls.Add(pnlChestCard);
            tabKetAmThuc.Location = new Point(4, 5);
            tabKetAmThuc.Margin = new Padding(4, 5, 4, 5);
            tabKetAmThuc.Name = "tabKetAmThuc";
            tabKetAmThuc.Padding = new Padding(15, 19, 15, 19);
            tabKetAmThuc.Size = new Size(1242, 847);
            tabKetAmThuc.TabIndex = 1;
            tabKetAmThuc.Text = "Tab2";
            // 
            // pnlChestCard
            // 
            pnlChestCard.BackColor = Color.White;
            pnlChestCard.BorderStyle = BorderStyle.FixedSingle;
            pnlChestCard.Controls.Add(lblChestHeader);
            pnlChestCard.Controls.Add(lblFilterMeal);
            pnlChestCard.Controls.Add(cboMealTime);
            pnlChestCard.Controls.Add(lblFilterCategory);
            pnlChestCard.Controls.Add(cboCategory);
            pnlChestCard.Controls.Add(btnOpenChest);
            pnlChestCard.Controls.Add(rtbChestResult);
            pnlChestCard.Dock = DockStyle.Fill;
            pnlChestCard.Location = new Point(15, 19);
            pnlChestCard.Margin = new Padding(4, 5, 4, 5);
            pnlChestCard.Name = "pnlChestCard";
            pnlChestCard.Size = new Size(1212, 809);
            pnlChestCard.TabIndex = 0;
            // 
            // lblChestHeader
            // 
            lblChestHeader.AutoSize = true;
            lblChestHeader.Font = new Font("Segoe UI", 13.5F, FontStyle.Bold);
            lblChestHeader.ForeColor = Color.FromArgb(180, 83, 9);
            lblChestHeader.Location = new Point(388, 23);
            lblChestHeader.Margin = new Padding(4, 0, 4, 0);
            lblChestHeader.Name = "lblChestHeader";
            lblChestHeader.Size = new Size(418, 37);
            lblChestHeader.TabIndex = 0;
            lblChestHeader.Text = "KHÁM PHÁ KÉT ẨM THỰC VIỆT";
            // 
            // lblFilterMeal
            // 
            lblFilterMeal.AutoSize = true;
            lblFilterMeal.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblFilterMeal.Location = new Point(62, 106);
            lblFilterMeal.Margin = new Padding(4, 0, 4, 0);
            lblFilterMeal.Name = "lblFilterMeal";
            lblFilterMeal.Size = new Size(136, 28);
            lblFilterMeal.TabIndex = 1;
            lblFilterMeal.Text = "Chọn bữa ăn:";
            // 
            // cboMealTime
            // 
            cboMealTime.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMealTime.FormattingEnabled = true;
            cboMealTime.Location = new Point(219, 102);
            cboMealTime.Margin = new Padding(4, 5, 4, 5);
            cboMealTime.Name = "cboMealTime";
            cboMealTime.Size = new Size(274, 36);
            cboMealTime.TabIndex = 2;
            // 
            // lblFilterCategory
            // 
            lblFilterCategory.AutoSize = true;
            lblFilterCategory.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblFilterCategory.Location = new Point(575, 106);
            lblFilterCategory.Margin = new Padding(4, 0, 4, 0);
            lblFilterCategory.Name = "lblFilterCategory";
            lblFilterCategory.Size = new Size(93, 28);
            lblFilterCategory.TabIndex = 3;
            lblFilterCategory.Text = "Thể loại:";
            // 
            // cboCategory
            // 
            cboCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(694, 102);
            cboCategory.Margin = new Padding(4, 5, 4, 5);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(405, 36);
            cboCategory.TabIndex = 4;
            // 
            // btnOpenChest
            // 
            btnOpenChest.BackColor = Color.FromArgb(217, 119, 6);
            btnOpenChest.FlatAppearance.BorderSize = 0;
            btnOpenChest.FlatStyle = FlatStyle.Flat;
            btnOpenChest.Font = new Font("Segoe UI", 11.5F, FontStyle.Bold);
            btnOpenChest.ForeColor = Color.White;
            btnOpenChest.Location = new Point(375, 180);
            btnOpenChest.Margin = new Padding(4, 5, 4, 5);
            btnOpenChest.Name = "btnOpenChest";
            btnOpenChest.Size = new Size(462, 75);
            btnOpenChest.TabIndex = 5;
            btnOpenChest.Text = "★ KHAI MỞ KÉT ẨM THỰC ★";
            btnOpenChest.UseVisualStyleBackColor = false;
            // 
            // rtbChestResult
            // 
            rtbChestResult.BackColor = Color.FromArgb(248, 250, 252);
            rtbChestResult.BorderStyle = BorderStyle.FixedSingle;
            rtbChestResult.Font = new Font("Consolas", 10.5F);
            rtbChestResult.Location = new Point(62, 281);
            rtbChestResult.Margin = new Padding(4, 5, 4, 5);
            rtbChestResult.Name = "rtbChestResult";
            rtbChestResult.ReadOnly = true;
            rtbChestResult.Size = new Size(1036, 482);
            rtbChestResult.TabIndex = 6;
            rtbChestResult.Text = "";
            // 
            // tabBocQue
            // 
            tabBocQue.BackColor = Color.FromArgb(241, 245, 249);
            tabBocQue.Controls.Add(pnlFortuneCard);
            tabBocQue.Location = new Point(4, 5);
            tabBocQue.Margin = new Padding(4, 5, 4, 5);
            tabBocQue.Name = "tabBocQue";
            tabBocQue.Padding = new Padding(15, 19, 15, 19);
            tabBocQue.Size = new Size(1242, 847);
            tabBocQue.TabIndex = 2;
            tabBocQue.Text = "Tab3";
            // 
            // pnlFortuneCard
            // 
            pnlFortuneCard.BackColor = Color.FromArgb(255, 251, 235);
            pnlFortuneCard.BorderStyle = BorderStyle.FixedSingle;
            pnlFortuneCard.Controls.Add(lblFortuneHeader);
            pnlFortuneCard.Controls.Add(lblQueDesc);
            pnlFortuneCard.Controls.Add(btnDrawFortune);
            pnlFortuneCard.Controls.Add(rtbFortuneResult);
            pnlFortuneCard.Dock = DockStyle.Fill;
            pnlFortuneCard.Location = new Point(15, 19);
            pnlFortuneCard.Margin = new Padding(4, 5, 4, 5);
            pnlFortuneCard.Name = "pnlFortuneCard";
            pnlFortuneCard.Size = new Size(1212, 809);
            pnlFortuneCard.TabIndex = 0;
            // 
            // lblFortuneHeader
            // 
            lblFortuneHeader.AutoSize = true;
            lblFortuneHeader.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblFortuneHeader.ForeColor = Color.FromArgb(153, 27, 27);
            lblFortuneHeader.Location = new Point(488, 23);
            lblFortuneHeader.Margin = new Padding(4, 0, 4, 0);
            lblFortuneHeader.Name = "lblFortuneHeader";
            lblFortuneHeader.Size = new Size(229, 41);
            lblFortuneHeader.TabIndex = 0;
            lblFortuneHeader.Text = "QUẺ ẨM THỰC";
            // 
            // lblQueDesc
            // 
            lblQueDesc.AutoSize = true;
            lblQueDesc.Font = new Font("Segoe UI", 11.5F, FontStyle.Italic);
            lblQueDesc.ForeColor = Color.FromArgb(146, 64, 14);
            lblQueDesc.Location = new Point(344, 86);
            lblQueDesc.Margin = new Padding(4, 0, 4, 0);
            lblQueDesc.Name = "lblQueDesc";
            lblQueDesc.Size = new Size(495, 31);
            lblQueDesc.TabIndex = 1;
            lblQueDesc.Text = "\"Lắc nhẹ ống tre, đón một quẻ cho bữa hôm nay\"";
            // 
            // btnDrawFortune
            // 
            btnDrawFortune.BackColor = Color.FromArgb(220, 38, 38);
            btnDrawFortune.FlatAppearance.BorderSize = 0;
            btnDrawFortune.FlatStyle = FlatStyle.Flat;
            btnDrawFortune.Font = new Font("Segoe UI", 11.5F, FontStyle.Bold);
            btnDrawFortune.ForeColor = Color.White;
            btnDrawFortune.Location = new Point(425, 148);
            btnDrawFortune.Margin = new Padding(4, 5, 4, 5);
            btnDrawFortune.Name = "btnDrawFortune";
            btnDrawFortune.Size = new Size(362, 75);
            btnDrawFortune.TabIndex = 2;
            btnDrawFortune.Text = "🎋 LẮC ỐNG BỐC QUẺ 🎋";
            btnDrawFortune.UseVisualStyleBackColor = false;
            // 
            // rtbFortuneResult
            // 
            rtbFortuneResult.BackColor = Color.White;
            rtbFortuneResult.BorderStyle = BorderStyle.FixedSingle;
            rtbFortuneResult.Font = new Font("Consolas", 10.5F);
            rtbFortuneResult.Location = new Point(62, 250);
            rtbFortuneResult.Margin = new Padding(4, 5, 4, 5);
            rtbFortuneResult.Name = "rtbFortuneResult";
            rtbFortuneResult.ReadOnly = true;
            rtbFortuneResult.Size = new Size(1074, 513);
            rtbFortuneResult.TabIndex = 3;
            rtbFortuneResult.Text = "";
            // 
            // tabTimQuan
            // 
            tabTimQuan.BackColor = Color.FromArgb(241, 245, 249);
            tabTimQuan.Controls.Add(pnlMapCard);
            tabTimQuan.Location = new Point(4, 5);
            tabTimQuan.Margin = new Padding(4, 5, 4, 5);
            tabTimQuan.Name = "tabTimQuan";
            tabTimQuan.Padding = new Padding(15, 19, 15, 19);
            tabTimQuan.Size = new Size(1242, 847);
            tabTimQuan.TabIndex = 3;
            tabTimQuan.Text = "Tab4";
            // 
            // pnlMapCard
            // 
            pnlMapCard.BackColor = Color.White;
            pnlMapCard.BorderStyle = BorderStyle.FixedSingle;
            pnlMapCard.Controls.Add(lblMapHeader);
            pnlMapCard.Controls.Add(lblCity);
            pnlMapCard.Controls.Add(cboCity);
            pnlMapCard.Controls.Add(lblWard);
            pnlMapCard.Controls.Add(cboWard);
            pnlMapCard.Controls.Add(lblStreet);
            pnlMapCard.Controls.Add(cboStreet);
            pnlMapCard.Controls.Add(lblSearchDish);
            pnlMapCard.Controls.Add(txtSearchFood);
            pnlMapCard.Controls.Add(btnFindNearShops);
            pnlMapCard.Controls.Add(btnOpenGoogleMaps);
            pnlMapCard.Controls.Add(rtbNearShops);
            pnlMapCard.Dock = DockStyle.Fill;
            pnlMapCard.Location = new Point(15, 19);
            pnlMapCard.Margin = new Padding(4, 5, 4, 5);
            pnlMapCard.Name = "pnlMapCard";
            pnlMapCard.Size = new Size(1212, 809);
            pnlMapCard.TabIndex = 0;
            // 
            // lblMapHeader
            // 
            lblMapHeader.AutoSize = true;
            lblMapHeader.Font = new Font("Segoe UI", 13.5F, FontStyle.Bold);
            lblMapHeader.ForeColor = Color.FromArgb(14, 116, 144);
            lblMapHeader.Location = new Point(350, 19);
            lblMapHeader.Margin = new Padding(4, 0, 4, 0);
            lblMapHeader.Name = "lblMapHeader";
            lblMapHeader.Size = new Size(496, 37);
            lblMapHeader.TabIndex = 0;
            lblMapHeader.Text = "TÌM QUÁN ĂN GẦN NHÀ TRÊN MAPS";
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblCity.Location = new Point(38, 91);
            lblCity.Margin = new Padding(4, 0, 4, 0);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(159, 25);
            lblCity.TabIndex = 1;
            lblCity.Text = "Tỉnh/Thành phố:";
            // 
            // cboCity
            // 
            cboCity.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCity.FormattingEnabled = true;
            cboCity.Location = new Point(212, 84);
            cboCity.Margin = new Padding(4, 5, 4, 5);
            cboCity.Name = "cboCity";
            cboCity.Size = new Size(312, 36);
            cboCity.TabIndex = 2;
            // 
            // lblWard
            // 
            lblWard.AutoSize = true;
            lblWard.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblWard.Location = new Point(562, 91);
            lblWard.Margin = new Padding(4, 0, 4, 0);
            lblWard.Name = "lblWard";
            lblWard.Size = new Size(221, 25);
            lblWard.TabIndex = 3;
            lblWard.Text = "Phường/Xã (Sáp nhập):";
            // 
            // cboWard
            // 
            cboWard.DropDownStyle = ComboBoxStyle.DropDownList;
            cboWard.FormattingEnabled = true;
            cboWard.Location = new Point(800, 84);
            cboWard.Margin = new Padding(4, 5, 4, 5);
            cboWard.Name = "cboWard";
            cboWard.Size = new Size(368, 36);
            cboWard.TabIndex = 4;
            // 
            // lblStreet
            // 
            lblStreet.AutoSize = true;
            lblStreet.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblStreet.Location = new Point(38, 166);
            lblStreet.Margin = new Padding(4, 0, 4, 0);
            lblStreet.Name = "lblStreet";
            lblStreet.Size = new Size(163, 25);
            lblStreet.TabIndex = 5;
            lblStreet.Text = "Đường/Hẻm/Ấp:";
            // 
            // cboStreet
            // 
            cboStreet.DropDownStyle = ComboBoxStyle.DropDownList;
            cboStreet.FormattingEnabled = true;
            cboStreet.Location = new Point(212, 159);
            cboStreet.Margin = new Padding(4, 5, 4, 5);
            cboStreet.Name = "cboStreet";
            cboStreet.Size = new Size(312, 36);
            cboStreet.TabIndex = 6;
            // 
            // lblSearchDish
            // 
            lblSearchDish.AutoSize = true;
            lblSearchDish.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblSearchDish.Location = new Point(562, 166);
            lblSearchDish.Margin = new Padding(4, 0, 4, 0);
            lblSearchDish.Name = "lblSearchDish";
            lblSearchDish.Size = new Size(202, 25);
            lblSearchDish.TabIndex = 7;
            lblSearchDish.Text = "Món muốn tìm quán:";
            // 
            // txtSearchFood
            // 
            txtSearchFood.Location = new Point(800, 159);
            txtSearchFood.Margin = new Padding(4, 5, 4, 5);
            txtSearchFood.Name = "txtSearchFood";
            txtSearchFood.Size = new Size(368, 34);
            txtSearchFood.TabIndex = 8;
            txtSearchFood.Text = "Cơm tấm";
            // 
            // btnFindNearShops
            // 
            btnFindNearShops.BackColor = Color.FromArgb(2, 132, 199);
            btnFindNearShops.FlatAppearance.BorderSize = 0;
            btnFindNearShops.FlatStyle = FlatStyle.Flat;
            btnFindNearShops.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnFindNearShops.ForeColor = Color.White;
            btnFindNearShops.Location = new Point(212, 231);
            btnFindNearShops.Margin = new Padding(4, 5, 4, 5);
            btnFindNearShops.Name = "btnFindNearShops";
            btnFindNearShops.Size = new Size(312, 66);
            btnFindNearShops.TabIndex = 9;
            btnFindNearShops.Text = "🔍 Tìm quán gần nhất";
            btnFindNearShops.UseVisualStyleBackColor = false;
            // 
            // btnOpenGoogleMaps
            // 
            btnOpenGoogleMaps.BackColor = Color.FromArgb(16, 185, 129);
            btnOpenGoogleMaps.FlatAppearance.BorderSize = 0;
            btnOpenGoogleMaps.FlatStyle = FlatStyle.Flat;
            btnOpenGoogleMaps.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnOpenGoogleMaps.ForeColor = Color.White;
            btnOpenGoogleMaps.Location = new Point(562, 231);
            btnOpenGoogleMaps.Margin = new Padding(4, 5, 4, 5);
            btnOpenGoogleMaps.Name = "btnOpenGoogleMaps";
            btnOpenGoogleMaps.Size = new Size(344, 66);
            btnOpenGoogleMaps.TabIndex = 10;
            btnOpenGoogleMaps.Text = "🌐 Mở trên Google Maps";
            btnOpenGoogleMaps.UseVisualStyleBackColor = false;
            // 
            // rtbNearShops
            // 
            rtbNearShops.BackColor = Color.FromArgb(248, 250, 252);
            rtbNearShops.BorderStyle = BorderStyle.FixedSingle;
            rtbNearShops.Font = new Font("Consolas", 10F);
            rtbNearShops.Location = new Point(38, 316);
            rtbNearShops.Margin = new Padding(4, 5, 4, 5);
            rtbNearShops.Name = "rtbNearShops";
            rtbNearShops.ReadOnly = true;
            rtbNearShops.Size = new Size(1130, 459);
            rtbNearShops.TabIndex = 11;
            rtbNearShops.Text = "";
            // 
            // tabMenuTong
            // 
            tabMenuTong.BackColor = Color.FromArgb(241, 245, 249);
            tabMenuTong.Controls.Add(pnlMenuCard);
            tabMenuTong.Location = new Point(4, 5);
            tabMenuTong.Margin = new Padding(4, 5, 4, 5);
            tabMenuTong.Name = "tabMenuTong";
            tabMenuTong.Padding = new Padding(15, 19, 15, 19);
            tabMenuTong.Size = new Size(1242, 847);
            tabMenuTong.TabIndex = 4;
            tabMenuTong.Text = "Tab5";
            // 
            // pnlMenuCard
            // 
            pnlMenuCard.BackColor = Color.White;
            pnlMenuCard.BorderStyle = BorderStyle.FixedSingle;
            pnlMenuCard.Controls.Add(lblMenuCount);
            pnlMenuCard.Controls.Add(lblSearchMenu);
            pnlMenuCard.Controls.Add(txtSearchMenu);
            pnlMenuCard.Controls.Add(dgvAllFoods);
            pnlMenuCard.Dock = DockStyle.Fill;
            pnlMenuCard.Location = new Point(15, 19);
            pnlMenuCard.Margin = new Padding(4, 5, 4, 5);
            pnlMenuCard.Name = "pnlMenuCard";
            pnlMenuCard.Size = new Size(1212, 809);
            pnlMenuCard.TabIndex = 0;
            // 
            // lblMenuCount
            // 
            lblMenuCount.AutoSize = true;
            lblMenuCount.Font = new Font("Segoe UI", 11.5F, FontStyle.Bold);
            lblMenuCount.ForeColor = Color.FromArgb(30, 41, 59);
            lblMenuCount.Location = new Point(31, 28);
            lblMenuCount.Margin = new Padding(4, 0, 4, 0);
            lblMenuCount.Name = "lblMenuCount";
            lblMenuCount.Size = new Size(432, 31);
            lblMenuCount.TabIndex = 0;
            lblMenuCount.Text = "KHO ẨM THỰC VIỆT NAM (500+ MÓN)";
            // 
            // lblSearchMenu
            // 
            lblSearchMenu.AutoSize = true;
            lblSearchMenu.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblSearchMenu.Location = new Point(594, 34);
            lblSearchMenu.Margin = new Padding(4, 0, 4, 0);
            lblSearchMenu.Name = "lblSearchMenu";
            lblSearchMenu.Size = new Size(98, 25);
            lblSearchMenu.TabIndex = 1;
            lblSearchMenu.Text = "Tìm kiếm:";
            // 
            // txtSearchMenu
            // 
            txtSearchMenu.Location = new Point(706, 28);
            txtSearchMenu.Margin = new Padding(4, 5, 4, 5);
            txtSearchMenu.Name = "txtSearchMenu";
            txtSearchMenu.Size = new Size(462, 34);
            txtSearchMenu.TabIndex = 2;
            // 
            // dgvAllFoods
            // 
            dgvAllFoods.AllowUserToAddRows = false;
            dgvAllFoods.AllowUserToDeleteRows = false;
            dgvAllFoods.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAllFoods.BackgroundColor = Color.FromArgb(248, 250, 252);
            dgvAllFoods.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(241, 245, 249);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(51, 65, 85);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvAllFoods.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvAllFoods.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(224, 231, 255);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(30, 41, 59);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvAllFoods.DefaultCellStyle = dataGridViewCellStyle2;
            dgvAllFoods.EnableHeadersVisualStyles = false;
            dgvAllFoods.GridColor = Color.FromArgb(226, 232, 240);
            dgvAllFoods.Location = new Point(31, 94);
            dgvAllFoods.Margin = new Padding(4, 5, 4, 5);
            dgvAllFoods.Name = "dgvAllFoods";
            dgvAllFoods.ReadOnly = true;
            dgvAllFoods.RowHeadersVisible = false;
            dgvAllFoods.RowHeadersWidth = 51;
            dgvAllFoods.RowTemplate.Height = 26;
            dgvAllFoods.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAllFoods.Size = new Size(1138, 688);
            dgvAllFoods.TabIndex = 3;
            // 
            // Lab01_Bai08
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 245, 249);
            ClientSize = new Size(1250, 1031);
            Controls.Add(tabControl);
            Controls.Add(pnlNavBar);
            Controls.Add(pnlTopBanner);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "Lab01_Bai08";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bài 08 - Hệ thống gợi ý ẩm thực hôm nay ăn gì?";
            pnlTopBanner.ResumeLayout(false);
            pnlTopBanner.PerformLayout();
            pnlNavBar.ResumeLayout(false);
            tabControl.ResumeLayout(false);
            tabLab01.ResumeLayout(false);
            pnlFavCard.ResumeLayout(false);
            pnlFavCard.PerformLayout();
            pnlResultCard.ResumeLayout(false);
            pnlResultCard.PerformLayout();
            tabKetAmThuc.ResumeLayout(false);
            pnlChestCard.ResumeLayout(false);
            pnlChestCard.PerformLayout();
            tabBocQue.ResumeLayout(false);
            pnlFortuneCard.ResumeLayout(false);
            pnlFortuneCard.PerformLayout();
            tabTimQuan.ResumeLayout(false);
            pnlMapCard.ResumeLayout(false);
            pnlMapCard.PerformLayout();
            tabMenuTong.ResumeLayout(false);
            pnlMenuCard.ResumeLayout(false);
            pnlMenuCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAllFoods).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlTopBanner;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Label lblHeaderSub;
        private System.Windows.Forms.Panel pnlNavBar;
        private System.Windows.Forms.Button btnNavFav;
        private System.Windows.Forms.Button btnNavChest;
        private System.Windows.Forms.Button btnNavFortune;
        private System.Windows.Forms.Button btnNavMaps;
        private System.Windows.Forms.Button btnNavMenu;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabLab01;
        private System.Windows.Forms.Panel pnlFavCard;
        private System.Windows.Forms.Label lblFavoriteTitle;
        private System.Windows.Forms.Label lblDishInput;
        private System.Windows.Forms.TextBox txtNewDish;
        private System.Windows.Forms.Button btnQuickFill;
        private System.Windows.Forms.Button btnAddFavorite;
        private System.Windows.Forms.Button btnDeleteFavorite;
        private System.Windows.Forms.Label lblListTitle;
        private System.Windows.Forms.ListBox lstFavoriteDishes;
        private System.Windows.Forms.Button btnFindDish;
        private System.Windows.Forms.Button btnClearFavorite;
        private System.Windows.Forms.Button btnExitFavorite;
        private System.Windows.Forms.Panel pnlResultCard;
        private System.Windows.Forms.Label lblTodayBanner;
        private System.Windows.Forms.Label lblSelectedDish;

        private System.Windows.Forms.TabPage tabKetAmThuc;
        private System.Windows.Forms.Panel pnlChestCard;
        private System.Windows.Forms.Label lblChestHeader;
        private System.Windows.Forms.Label lblFilterMeal;
        private System.Windows.Forms.ComboBox cboMealTime;
        private System.Windows.Forms.Label lblFilterCategory;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Button btnOpenChest;
        private System.Windows.Forms.RichTextBox rtbChestResult;

        private System.Windows.Forms.TabPage tabBocQue;
        private System.Windows.Forms.Panel pnlFortuneCard;
        private System.Windows.Forms.Label lblFortuneHeader;
        private System.Windows.Forms.Label lblQueDesc;
        private System.Windows.Forms.Button btnDrawFortune;
        private System.Windows.Forms.RichTextBox rtbFortuneResult;

        private System.Windows.Forms.TabPage tabTimQuan;
        private System.Windows.Forms.Panel pnlMapCard;
        private System.Windows.Forms.Label lblMapHeader;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.ComboBox cboCity;
        private System.Windows.Forms.Label lblWard;
        private System.Windows.Forms.ComboBox cboWard;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.ComboBox cboStreet;
        private System.Windows.Forms.Label lblSearchDish;
        private System.Windows.Forms.TextBox txtSearchFood;
        private System.Windows.Forms.Button btnFindNearShops;
        private System.Windows.Forms.Button btnOpenGoogleMaps;
        private System.Windows.Forms.RichTextBox rtbNearShops;

        private System.Windows.Forms.TabPage tabMenuTong;
        private System.Windows.Forms.Panel pnlMenuCard;
        private System.Windows.Forms.Label lblMenuCount;
        private System.Windows.Forms.Label lblSearchMenu;
        private System.Windows.Forms.TextBox txtSearchMenu;
        private System.Windows.Forms.DataGridView dgvAllFoods;
    }
}