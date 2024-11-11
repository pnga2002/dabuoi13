public class QuanLyHocSinh
{
   private List<HocSinh> danhSachHocSinh;
    private int nextId = 1; // Biến quản lý Id tự động tăng

    public QuanLyHocSinh()
    {
        danhSachHocSinh = new List<HocSinh>();
    }

    public void ThemHocSinh(HocSinh hocSinh)
    {
        hocSinh.MaHocSinh = nextId; // Gán giá trị Id tự động tăng
        nextId++;
        danhSachHocSinh.Add(hocSinh);
        Console.WriteLine($"Học sinh {hocSinh.TenHocSinh} đã được thêm với mã ID {hocSinh.MaHocSinh}");
    }

    public HocSinh TimHocSinhTheoTen(string ten)
    {
        return danhSachHocSinh.FirstOrDefault(hs => hs.TenHocSinh.Contains(ten, StringComparison.OrdinalIgnoreCase));
    }

    public void CapNhatDiem(int maHocSinh, double diemToan, double diemVan, double diemAnh)
    {
        var hs = danhSachHocSinh.FirstOrDefault(h => h.MaHocSinh == maHocSinh);
        if (hs != null)
        {
            hs.DiemToan = diemToan;
            hs.DiemVan = diemVan;
            hs.DiemAnh = diemAnh;
        }
    }

    public void XoaHocSinh(int maHocSinh)
    {
        danhSachHocSinh.RemoveAll(hs => hs.MaHocSinh == maHocSinh);
    }

    public void HienThiDanhSach()
    {
        foreach (var hs in danhSachHocSinh)
        {
            Console.WriteLine(hs);
        }
    }

    public void HienThiDanhSachTheoDiemTrungBinh()
    {
        var sortedList = danhSachHocSinh.OrderBy(hs => hs.TinhDiemTrungBinh()).ToList();
        foreach (var hs in sortedList)
        {
            Console.WriteLine(hs);
        }
    }

    public void HienThiHocSinhTheoTen()
    {
        var sortedList = danhSachHocSinh.OrderBy(hs => hs.TenHocSinh.Split(' ').Last()).ToList();
        foreach (var hs in sortedList)
        {
            Console.WriteLine(hs);
        }
    }
}
