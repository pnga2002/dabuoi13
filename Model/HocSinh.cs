public class HocSinh
{
    public int MaHocSinh { get; set; }
    public string TenHocSinh { get; set; }
    public double DiemToan { get; set; }
    public double DiemVan { get; set; }
    public double DiemAnh { get; set; }

    public double TinhDiemTrungBinh()
    {
        return (DiemToan + DiemVan + DiemAnh) / 3.0;
    }

    public override string ToString()
    {
        return $"ID: {MaHocSinh}, Tên: {TenHocSinh}, Toán: {DiemToan}, Văn: {DiemVan}, Anh: {DiemAnh}, Điểm TB: {TinhDiemTrungBinh():F2}";
    }
}