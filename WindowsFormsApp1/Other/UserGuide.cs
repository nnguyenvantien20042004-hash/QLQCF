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
    public partial class UserGuide : Form
    {
        public UserGuide()
        {
            InitializeComponent();
            this.Text = "Hướng Dẫn Sử Dụng";
            this.StartPosition = FormStartPosition.CenterScreen;

            lblTitle.Text = "HƯỚNG DẪN SỬ DỤNG";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;

            lblContent.Text =
                "1. Quản Lý Bàn\n" +
                "- Chọn bàn từ danh sách bên trái.\n" +
                "- Bàn xanh: Bàn trống.\n" +
                "- Bàn vàng: Đang sử dụng.\n\n" +

                "2. Gọi Món\n" +
                "- Chọn Danh Mục.\n" +
                "- Chọn món cần gọi.\n" +
                "- Nhập số lượng → bấm 'Thêm Món'.\n\n" +

                "3. Xóa Món\n" +
                "- Chọn món cần xóa trong bill.\n" +
                "- Bấm 'Xóa Món'.\n\n" +

                "4. Thanh Toán\n" +
                "- Nhập giảm giá (nếu có).\n" +
                "- Kiểm tra tổng tiền.\n" +
                "- Bấm 'Thanh Toán'.\n\n" +

                "5. Quản Trị\n" +
                "- Thêm, sửa, xóa món ăn.\n" +
                "- Quản lý loại món.\n" +
                "- Quản lý danh sách bàn.\n\n" +

                "Chúc bạn sử dụng phần mềm hiệu quả và thuận tiện!";

            btnClose.Click += (s, e) => this.Close();
        }
    }
}
