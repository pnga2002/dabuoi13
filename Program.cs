class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        
        while (true)
        {
            menu.HienThiMenu();
            Console.Write("Chọn chức năng: ");
            if (int.TryParse(Console.ReadLine(), out int luaChon))
            {
                menu.XuLyChucNang(luaChon);
            }
            else
            {
                Console.WriteLine("Vui lòng nhập số hợp lệ!");
            }

            Console.WriteLine("Nhấn phím bất kỳ để tiếp tục...");
            Console.ReadKey();
        }
    }
}
