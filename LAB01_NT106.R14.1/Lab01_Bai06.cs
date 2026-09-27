using System;
using System.Windows.Forms;

namespace Lab01
{
    public partial class Lab01_Bai06 : Form
    {
        public Lab01_Bai06()
        {
            InitializeComponent();

            btnCheck.Click -= btnCheck_Click;
            btnCheck.Click += btnCheck_Click;

            btnClear.Click -= btnClear_Click;
            btnClear.Click += btnClear_Click;

            btnExit.Click -= btnExit_Click;
            btnExit.Click += btnExit_Click;

            dtpBirthDate.ValueChanged -= dtpBirthDate_ValueChanged;
            dtpBirthDate.ValueChanged += dtpBirthDate_ValueChanged;

            ExecuteCheck();
        }

        private void dtpBirthDate_ValueChanged(object sender, EventArgs e)
        {
            ExecuteCheck();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            ExecuteCheck();
        }

        private void ExecuteCheck()
        {
            rtbResult.Clear();

            int day = dtpBirthDate.Value.Day;
            int month = dtpBirthDate.Value.Month;

            string zodiacName = "";
            string englishName = "";
            string symbol = "";
            string element = "";
            string dateRange = "";
            string personality = "";

            switch (month)
            {
                case 1:
                    if (day <= 20)
                    {
                        zodiacName = "Ma Kết";
                        englishName = "Capricorn";
                        symbol = "♑";
                        element = "Đất (Earth)";
                        dateRange = "22/12 - 20/01";
                        personality = "Kiên định, kỷ luật cao, thực tế, làm việc bài bản, đáng tin cậy và luôn kiên trì theo đuổi mục tiêu lớn.";
                    }
                    else
                    {
                        zodiacName = "Bảo Bình";
                        englishName = "Aquarius";
                        symbol = "♒";
                        element = "Khí (Air)";
                        dateRange = "21/01 - 19/02";
                        personality = "Tư duy sáng tạo, độc lập, yêu tự do, cấp tiến, giàu lòng bác ái và luôn đi trước thời đại.";
                    }
                    break;

                case 2:
                    if (day <= 19)
                    {
                        zodiacName = "Bảo Bình";
                        englishName = "Aquarius";
                        symbol = "♒";
                        element = "Khí (Air)";
                        dateRange = "21/01 - 19/02";
                        personality = "Tư duy sáng tạo, độc lập, yêu tự do, cấp tiến, giàu lòng bác ái và luôn đi trước thời đại.";
                    }
                    else
                    {
                        zodiacName = "Song Ngư";
                        englishName = "Pisces";
                        symbol = "♓";
                        element = "Nước (Water)";
                        dateRange = "20/02 - 20/03";
                        personality = "Giàu lòng trắc ẩn, trực giác sâu sắc, nhạy bén, sống tình cảm, thấu hiểu lòng người và có năng khiếu nghệ thuật.";
                    }
                    break;

                case 3:
                    if (day <= 20)
                    {
                        zodiacName = "Song Ngư";
                        englishName = "Pisces";
                        symbol = "♓";
                        element = "Nước (Water)";
                        dateRange = "20/02 - 20/03";
                        personality = "Giàu lòng trắc ẩn, trực giác sâu sắc, nhạy bén, sống tình cảm, thấu hiểu lòng người và có năng khiếu nghệ thuật.";
                    }
                    else
                    {
                        zodiacName = "Bạch Dương";
                        englishName = "Aries";
                        symbol = "♈";
                        element = "Lửa (Fire)";
                        dateRange = "21/03 - 20/04";
                        personality = "Nhiệt huyết, dũng cảm, quyết đoán, mang tố chất tiên phong, tràn đầy năng lượng và dám nghĩ dám làm.";
                    }
                    break;

                case 4:
                    if (day <= 20)
                    {
                        zodiacName = "Bạch Dương";
                        englishName = "Aries";
                        symbol = "♈";
                        element = "Lửa (Fire)";
                        dateRange = "21/03 - 20/04";
                        personality = "Nhiệt huyết, dũng cảm, quyết đoán, mang tố chất tiên phong, tràn đầy năng lượng và dám nghĩ dám làm.";
                    }
                    else
                    {
                        zodiacName = "Kim Ngưu";
                        englishName = "Taurus";
                        symbol = "♉";
                        element = "Đất (Earth)";
                        dateRange = "21/04 - 21/05";
                        personality = "Điềm đạm, vững vàng, thực tế, kiên nhẫn, trung thành, coi trọng sự ổn định và có khả năng quản lý tài chính tốt.";
                    }
                    break;

                case 5:
                    if (day <= 21)
                    {
                        zodiacName = "Kim Ngưu";
                        englishName = "Taurus";
                        symbol = "♉";
                        element = "Đất (Earth)";
                        dateRange = "21/04 - 21/05";
                        personality = "Điềm đạm, vững vàng, thực tế, kiên nhẫn, trung thành, coi trọng sự ổn định và có khả năng quản lý tài chính tốt.";
                    }
                    else
                    {
                        zodiacName = "Song Tử";
                        englishName = "Gemini";
                        symbol = "♊";
                        element = "Khí (Air)";
                        dateRange = "22/05 - 21/06";
                        personality = "Thông minh, hoạt ngôn, tư duy nhanh nhạy, thích khám phá tri thức mới và có khả năng thích ứng linh hoạt.";
                    }
                    break;

                case 6:
                    if (day <= 21)
                    {
                        zodiacName = "Song Tử";
                        englishName = "Gemini";
                        symbol = "♊";
                        element = "Khí (Air)";
                        dateRange = "22/05 - 21/06";
                        personality = "Thông minh, hoạt ngôn, tư duy nhanh nhạy, thích khám phá tri thức mới và có khả năng thích ứng linh hoạt.";
                    }
                    else
                    {
                        zodiacName = "Cự Giải";
                        englishName = "Cancer";
                        symbol = "♋";
                        element = "Nước (Water)";
                        dateRange = "22/06 - 22/07";
                        personality = "Nhân hậu, chu đáo, bản năng che chở bảo bọc cao, nhạy cảm tinh tế và luôn hướng về gia đình, bạn bè.";
                    }
                    break;

                case 7:
                    if (day <= 22)
                    {
                        zodiacName = "Cự Giải";
                        englishName = "Cancer";
                        symbol = "♋";
                        element = "Nước (Water)";
                        dateRange = "22/06 - 22/07";
                        personality = "Nhân hậu, chu đáo, bản năng che chở bảo bọc cao, nhạy cảm tinh tế và luôn hướng về gia đình, bạn bè.";
                    }
                    else
                    {
                        zodiacName = "Sư Tử";
                        englishName = "Leo";
                        symbol = "♌";
                        element = "Lửa (Fire)";
                        dateRange = "23/07 - 22/08";
                        personality = "Tự tin, hào phóng, có tố chất lãnh đạo bẩm sinh, trọng danh dự, ấm áp và luôn truyền cảm hứng cho người khác.";
                    }
                    break;

                case 8:
                    if (day <= 22)
                    {
                        zodiacName = "Sư Tử";
                        englishName = "Leo";
                        symbol = "♌";
                        element = "Lửa (Fire)";
                        dateRange = "23/07 - 22/08";
                        personality = "Tự tin, hào phóng, có tố chất lãnh đạo bẩm sinh, trọng danh dự, ấm áp và luôn truyền cảm hứng cho người khác.";
                    }
                    else
                    {
                        zodiacName = "Xử Nữ";
                        englishName = "Virgo";
                        symbol = "♍";
                        element = "Đất (Earth)";
                        dateRange = "23/08 - 23/09";
                        personality = "Cẩn trọng, chu toàn, tư duy phản biện xuất sắc, làm việc ngăn nắp, tinh tế và luôn hướng đến sự hoàn hảo.";
                    }
                    break;

                case 9:
                    if (day <= 23)
                    {
                        zodiacName = "Xử Nữ";
                        englishName = "Virgo";
                        symbol = "♍";
                        element = "Đất (Earth)";
                        dateRange = "23/08 - 23/09";
                        personality = "Cẩn trọng, chu toàn, tư duy phản biện xuất sắc, làm việc ngăn nắp, tinh tế và luôn hướng đến sự hoàn hảo.";
                    }
                    else
                    {
                        zodiacName = "Thiên Bình";
                        englishName = "Libra";
                        symbol = "♎";
                        element = "Khí (Air)";
                        dateRange = "24/09 - 23/10";
                        personality = "Hòa nhã, chuộng công bằng, thanh lịch, có khiếu ngoại giao tốt và luôn duy trì sự cân bằng trong cuộc sống.";
                    }
                    break;

                case 10:
                    if (day <= 23)
                    {
                        zodiacName = "Thiên Bình";
                        englishName = "Libra";
                        symbol = "♎";
                        element = "Khí (Air)";
                        dateRange = "24/09 - 23/10";
                        personality = "Hòa nhã, chuộng công bằng, thanh lịch, có khiếu ngoại giao tốt và luôn duy trì sự cân bằng trong cuộc sống.";
                    }
                    else
                    {
                        zodiacName = "Thần Nông";
                        englishName = "Scorpio";
                        symbol = "♏";
                        element = "Nước (Water)";
                        dateRange = "24/10 - 22/11";
                        personality = "Bản lĩnh, sâu sắc, ý chí phi thường, nội tâm mạnh mẽ, trực giác cực kỳ nhạy bén và trung thành tuyệt đối.";
                    }
                    break;

                case 11:
                    if (day <= 22)
                    {
                        zodiacName = "Thần Nông";
                        englishName = "Scorpio";
                        symbol = "♏";
                        element = "Nước (Water)";
                        dateRange = "24/10 - 22/11";
                        personality = "Bản lĩnh, sâu sắc, ý chí phi thường, nội tâm mạnh mẽ, trực giác cực kỳ nhạy bén và trung thành tuyệt đối.";
                    }
                    else
                    {
                        zodiacName = "Nhân Mã";
                        englishName = "Sagittarius";
                        symbol = "♐";
                        element = "Lửa (Fire)";
                        dateRange = "23/11 - 21/12";
                        personality = "Lạc quan, trung thực, yêu tự do xê dịch, tư tưởng cởi mở, thích khám phá chân lý và giàu năng lượng tích cực.";
                    }
                    break;

                case 12:
                    if (day <= 21)
                    {
                        zodiacName = "Nhân Mã";
                        englishName = "Sagittarius";
                        symbol = "♐";
                        element = "Lửa (Fire)";
                        dateRange = "23/11 - 21/12";
                        personality = "Lạc quan, trung thực, yêu tự do xê dịch, tư tưởng cởi mở, thích khám phá chân lý và giàu năng lượng tích cực.";
                    }
                    else
                    {
                        zodiacName = "Ma Kết";
                        englishName = "Capricorn";
                        symbol = "♑";
                        element = "Đất (Earth)";
                        dateRange = "22/12 - 20/01";
                        personality = "Kiên định, kỷ luật cao, thực tế, làm việc bài bản, đáng tin cậy và luôn kiên trì theo đuổi mục tiêu lớn.";
                    }
                    break;
            }

            rtbResult.AppendText("┌───────────────────────────────────────────────────┐\r\n");
            rtbResult.AppendText(string.Format("│   CUNG HOÀNG ĐẠO: {0} ({1}) {2}\r\n", zodiacName.ToUpper(), englishName, symbol));
            rtbResult.AppendText("├───────────────────────────────────────────────────┤\r\n");
            rtbResult.AppendText(string.Format("  Ngày sinh:   {0:dd/MM/yyyy}\r\n", dtpBirthDate.Value));
            rtbResult.AppendText(string.Format("  Chu kỳ cung: {0}\r\n", dateRange));
            rtbResult.AppendText(string.Format("  Nguyên tố:   {0}\r\n", element));
            rtbResult.AppendText("├───────────────────────────────────────────────────┤\r\n");
            rtbResult.AppendText("  Tính cách đặc trưng:\r\n");
            rtbResult.AppendText(string.Format("  {0}\r\n", personality));
            rtbResult.AppendText("└───────────────────────────────────────────────────┘\r\n");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dtpBirthDate.ValueChanged -= dtpBirthDate_ValueChanged;
            dtpBirthDate.Value = DateTime.Now;
            dtpBirthDate.ValueChanged += dtpBirthDate_ValueChanged;
            rtbResult.Clear();
            dtpBirthDate.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}