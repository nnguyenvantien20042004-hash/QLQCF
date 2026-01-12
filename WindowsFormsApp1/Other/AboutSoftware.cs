using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Other
{
    public partial class AboutSoftware : Form
    {
        public AboutSoftware()
        {
            InitializeComponent();

            this.Text = "Giới Thiệu Phần Mềm";

            lblTitle.Text = "PHẦN MỀM QUẢN LÝ QUÁN CÀ PHÊ";
            lblTitle.Font = new Font("Segoe UI", 14, FontStyle.Bold);

            lblContent.Text =
                "Phiên bản: 1.0\n" +
                "Tác giả: Nguyễn Văn Tiền và Nguyễn Hữu Phúc\n" +
                "Ngày hoàn thành: 10/12/2024\n\n" +
                "Ứng dụng quản lý quán cà phê:\n" +
                "- Quản lý bàn\n" +
                "- Gọi món và tính tiền\n" +
                "- Quản lý doanh thu\n" +
                "- Quản lý món ăn theo loại\n\n" +
                "Phát triển bằng C# WinForms và SQL Server.";

            btnClose.Text = "Đóng";
            btnClose.Click += (s, e) => this.Close();
        }
    }
}
