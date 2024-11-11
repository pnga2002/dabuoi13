using System;
using System.Collections.Generic;

public class Menu
{
    private Dictionary<int, string> menuOptions;
    private QuanLyHocSinh quanLyHocSinh;

    public Menu()
    {
        quanLyHocSinh = new QuanLyHocSinh();
        menuOptions = new Dictionary<int, string>()
        {
            { 1, "Thêm học sinh" },
            { 2, "Tìm học sinh theo tên" },
            { 3, "Cập nhật điểm" },
            { 4, "Xóa học sinh" },
            { 5, "Hiển thị danh sách" },
            { 6, "Hiển thị danh sách theo điểm trung bình" },
            { 7, "Hiển thị học sinh theo tên" },
            { 0, "Thoát chương trình" }
        };
    }

    public void HienThiMenu()
    {
        Console.Clear();
        Console.WriteLine("Quản lý thông tin học sinh:");
        foreach (var option in menuOptions)
        {
            Console.WriteLine($"{option.Key}. {option.Value}");
        }
    }

    public void XuLyChucNang(int luaChon)
    {
        switch (luaChon)
        {
            case 1:
                ThemHocSinh();
                break;
            case 2:
                TimHocSinhTheoTen();
                break;
            case 3:
                CapNhatDiem();
                break;
            case 4:
                XoaHocSinh();
                break;
            case 5:
                quanLyHocSinh.HienThiDanhSach();
                break;
            case 6:
                quanLyHocSinh.HienThiDanhSachTheoDiemTrungBinh();
                break;
            case 7:
                quanLyHocSinh.HienThiHocSinhTheoTen();
                break;
            case 0:
                Console.WriteLine("Thoát chương trình. Tạm biệt!");
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Lựa chọn không hợp lệ!");
                break;
        }
    }

    private void ThemHocSinh()
    {
        Console.Write("Nhập tên học sinh: ");
        string ten = Console.ReadLine();
        Console.Write("Nhập điểm Toán: ");
        double toan = double.Parse(Console.ReadLine());
        Console.Write("Nhập điểm Văn: ");
        double van = double.Parse(Console.ReadLine());
        Console.Write("Nhập điểm Anh: ");
        double anh = double.Parse(Console.ReadLine());

        quanLyHocSinh.ThemHocSinh(new HocSinh { MaHocSinh = 0, TenHocSinh = ten, DiemToan = toan, DiemVan = van, DiemAnh = anh });
        Console.WriteLine("Đã thêm học sinh thành công!");
    }

    private void TimHocSinhTheoTen()
    {
        Console.Write("Nhập tên học sinh cần tìm: ");
        string ten = Console.ReadLine();
        var hs = quanLyHocSinh.TimHocSinhTheoTen(ten);
        Console.WriteLine(hs != null ? hs.ToString() : "Không tìm thấy học sinh.");
    }

    private void CapNhatDiem()
    {
        Console.Write("Nhập mã học sinh: ");
        int ma = int.Parse(Console.ReadLine());
        Console.Write("Nhập điểm Toán: ");
        double toan = double.Parse(Console.ReadLine());
        Console.Write("Nhập điểm Văn: ");
        double van = double.Parse(Console.ReadLine());
        Console.Write("Nhập điểm Anh: ");
        double anh = double.Parse(Console.ReadLine());

        quanLyHocSinh.CapNhatDiem(ma, toan, van, anh);
        Console.WriteLine("Cập nhật điểm thành công!");
    }

    private void XoaHocSinh()
    {
        Console.Write("Nhập mã học sinh cần xóa: ");
        int ma = int.Parse(Console.ReadLine());
        quanLyHocSinh.XoaHocSinh(ma);
        Console.WriteLine("Đã xóa học sinh thành công!");
    }
}
