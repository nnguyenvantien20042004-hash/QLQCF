# ☕ Hệ Thống Quản Lý Quán Cà Phê (QLQCF)

[![.NET Framework](https://img.shields.io/badge/.NET%20Framework-4.7-blue.svg)](https://dotnet.microsoft.com/)
[![SQL Server](https://img.shields.io/badge/SQL%20Server-2019-red.svg)](https://www.microsoft.com/sql-server)
[![License](https://img.shields.io/badge/license-MIT-green.svg)](LICENSE)

> Phần mềm quản lý quán cà phê chuyên nghiệp được xây dựng bằng C# Windows Forms với kiến trúc DAO/DTO.

## 📋 Mục Lục
- [Giới Thiệu](#-giới-thiệu)
- [Tính Năng](#-tính-năng)
- [Công Nghệ](#-công-nghệ-sử-dụng)
- [Cài Đặt](#-hướng-dẫn-cài-đặt)
- [Cấu Trúc Dự Án](#-cấu-trúc-dự-án)
- [Sử Dụng](#-hướng-dẫn-sử-dụng)
- [Tác Giả](#-tác-giả)

## 🎯 Giới Thiệu

Hệ thống Quản Lý Quán Cà Phê (QLQCF) là một ứng dụng desktop được thiết kế để hỗ trợ quản lý toàn diện các hoạt động của quán cà phê, từ quản lý bàn, order món, thanh toán đến quản lý tài khoản và báo cáo doanh thu.

### ✨ Điểm Nổi Bật
- 🖥️ Giao diện thân thiện, dễ sử dụng
- 🔐 Hệ thống phân quyền Admin/User
- 💰 Quản lý hóa đơn và thanh toán linh hoạt
- 📊 Báo cáo thống kê doanh thu theo thời gian
- 🎫 Hỗ trợ voucher/giảm giá
- 🔄 Chuyển bàn nhanh chóng

## 🚀 Tính Năng

### 👤 Quản Lý Tài Khoản
- Đăng nhập/Đăng xuất
- Phân quyền Admin và User
- Quản lý thông tin tài khoản cá nhân
- Đổi mật khẩu

### 🍽️ Quản Lý Bàn & Order
- Hiển thị trạng thái bàn (Trống/Có khách)
- Order món ăn/thức uống
- Thêm/Xóa/Sửa món trong hóa đơn
- Chuyển bàn
- Gộp bàn

### 💵 Thanh Toán
- Tính toán tổng tiền tự động
- Áp dụng voucher/giảm giá
- In hóa đơn
- Lưu lịch sử giao dịch

### 🔧 Quản Trị (Admin)
- Quản lý danh mục thức ăn/đồ uống
- Quản lý tài khoản nhân viên
- Xem báo cáo doanh thu
- Thống kê theo ngày/tháng/năm

## 🛠️ Công Nghệ Sử Dụng

- **Ngôn ngữ**: C# (.NET Framework 4.7+)
- **Framework**: Windows Forms
- **Database**: SQL Server 2019
- **Kiến trúc**: 3-Layer (DAO/DTO/GUI)
- **IDE**: Visual Studio 2019/2022

## 📦 Hướng Dẫn Cài Đặt

### Yêu Cầu Hệ Thống
- Windows 10/11 hoặc Windows Server 2016+
- .NET Framework 4.7 trở lên
- SQL Server 2019 Express trở lên
- RAM: 2GB trở lên
- Dung lượng ổ cứng: 500MB trở lên

### Các Bước Cài Đặt

#### Bước 1: Cài Đặt Cơ Sở Dữ Liệu
```bash
# Chạy script tạo database
setupDatabase.bat
```
Hoặc thực hiện thủ công:
1. Mở SQL Server Management Studio
2. Chạy file `Database.sql` để tạo database và tables
3. Kiểm tra kết nối database

#### Bước 2: Cài Đặt Ứng Dụng
1. Truy cập thư mục `Qli_Cafe/Debug/`
2. Chạy file `setup.exe`
3. Làm theo hướng dẫn trên màn hình
4. Hoàn tất cài đặt

#### Bước 3: Cấu Hình Kết Nối
- Mở file cấu hình trong thư mục cài đặt
- Cập nhật connection string nếu cần:
```
Server=localhost;Database=QLCF;Integrated Security=true;
```

### Biên Dịch Từ Source Code

```bash
# Clone repository
git clone https://github.com/yourusername/QLQCF.git

# Mở solution trong Visual Studio
# File > Open > Project/Solution > WindowsFormsApp1.sln

# Restore NuGet packages
# Tools > NuGet Package Manager > Restore

# Build solution
# Build > Build Solution (Ctrl+Shift+B)

# Run project
# Debug > Start Debugging (F5)
```

## 📁 Cấu Trúc Dự Án

```
QLQCF/
├── WindowsFormsApp1/           # Main application
│   ├── DAO/                    # Data Access Objects
│   │   ├── AccountDAO.cs       # Quản lý tài khoản
│   │   ├── BillDAO.cs          # Quản lý hóa đơn
│   │   ├── BillInforDAO.cs     # Chi tiết hóa đơn
│   │   ├── FoodDAOcs.cs        # Quản lý món ăn
│   │   ├── TableDAO.cs         # Quản lý bàn
│   │   └── dataProvider.cs     # Kết nối database
│   ├── DTO/                    # Data Transfer Objects
│   │   ├── Bill.cs             # Model hóa đơn
│   │   ├── billInfor.cs        # Model chi tiết hóa đơn
│   │   ├── FoodDTO.cs          # Model món ăn
│   │   ├── Menu.cs             # Model menu
│   │   └── TableDTO.cs         # Model bàn
│   ├── Other/                  # Forms & UI
│   │   ├── Login.cs            # Form đăng nhập
│   │   ├── Table.cs            # Form quản lý bàn (Main)
│   │   ├── AdminAccount.cs     # Form admin
│   │   ├── UserAccount.cs      # Form user
│   │   ├── ChangeTable.cs      # Form chuyển bàn
│   │   ├── AboutSoftware.cs    # Thông tin phần mềm
│   │   └── UserGuide.cs        # Hướng dẫn sử dụng
│   └── Program.cs              # Entry point
├── Database.sql                # Database schema
├── setupDatabase.bat           # Script cài đặt DB
├── Qli_Cafe/                   # Setup files
│   └── Debug/
│       └── setup.exe           # Installer
├── BaoCaoDoAn.mp4              # Video demo
├── Nguyen_Van_Tien-Nguyen_Huu_Phuc.docx  # Báo cáo
└── README.md                   # Tài liệu này
```

## 📖 Hướng Dẫn Sử Dụng

### Đăng Nhập
1. Khởi động ứng dụng
2. Nhập tên đăng nhập và mật khẩu
3. Chọn vai trò (Admin/User)

**Tài khoản mặc định:**
- Admin: `admin` / `admin`
- User: `user` / `user`

### Quản Lý Bàn (Nhân Viên)
1. Chọn bàn trống
2. Chọn danh mục thức ăn/đồ uống
3. Chọn món và số lượng
4. Click "Thêm Món"
5. Kiểm tra hóa đơn
6. Thanh toán khi khách yêu cầu

### Chuyển Bàn
1. Chọn bàn nguồn (đang có khách)
2. Click "Chuyển Bàn"
3. Chọn bàn đích
4. Xác nhận chuyển

### Thanh Toán
1. Kiểm tra lại hóa đơn
2. Nhập voucher (nếu có)
3. Click "Thanh Toán"
4. In hóa đơn (tùy chọn)

### Quản Trị (Admin)
1. Menu > Admin
2. Quản lý:
   - Tài khoản nhân viên
   - Danh mục món ăn
   - Bàn ăn
   - Xem báo cáo doanh thu

## 🎥 Demo

Xem video demo tại: [BaoCaoDoAn.mp4](./BaoCaoDoAn.mp4)

## 🐛 Báo Lỗi & Đóng Góp

Nếu bạn phát hiện lỗi hoặc muốn đóng góp cho dự án:
1. Tạo Issue mô tả chi tiết vấn đề
2. Fork repository
3. Tạo branch mới (`git checkout -b feature/AmazingFeature`)
4. Commit thay đổi (`git commit -m 'Add some AmazingFeature'`)
5. Push to branch (`git push origin feature/AmazingFeature`)
6. Tạo Pull Request

## 👥 Tác Giả

- **Nguyễn Văn Tiền** - *Developer*
- **Nguyễn Hữu Phúc** - *Developer*

## 📄 License

Dự án này được phân phối dưới giấy phép MIT License. Xem file [LICENSE](LICENSE) để biết thêm chi tiết.

## 🙏 Lời Cảm Ơn

Cảm ơn bạn đã quan tâm đến dự án Hệ Thống Quản Lý Quán Cà Phê!

---

**Phát triển với ❤️ bởi Nhóm QLQCF**

*Dự án môn Công Nghệ Phần Mềm*
