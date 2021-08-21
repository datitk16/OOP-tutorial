using System;
using Static;

namespace ls09_static
{
    class Program
    {
        static void Main(string[] args)
        {
            BienTinh.CountNumber c1 = new BienTinh.CountNumber();
            BienTinh.CountNumber c2 = new BienTinh.CountNumber();
            c1.count();// CountNumber.num = 1;
            c2.count();// CountNumber.num = 2;
            c1.count();// CountNumber.num = 3;
            Console.WriteLine(c2.getNum());


            int ketqua = PhuongThucTinh.MethodStatic.Sum(1, 2); // trả về 3 - gọi phương thức mà không cần tạo đối tượng

            Console.WriteLine(ketqua);
        }
    }
}
