using System;

namespace ls04_kieuGiaTri_KieuThamChieu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static void valuetypeExample()
        {
            // biến a kiểu int là kiểu giá trị, nó lưu giá trị là 100
            int a = 100;

            //kiểu giá trị khi gán giá trị được coppy
            int b = a;
            Console.WriteLine($"a = {a}, b = {b}");

            //b gán giá trị mới,a không thay đổi - vì cúng không cùng tham chiếu đến 1 đối tượng chưng mà mỗi biến lưu ở một giá trị

            b = 200;
            Console.WriteLine($"a = {a}, b = {b}");

            // a = 100, b = 100
            // a = 100, b = 200
        }
    }

}


/// Kiểu giá trị trong c#
// kiểu giá trị và kiểm tham chiếu là 2 nhóm chính phân loại kiểu dữ liệu của c#. Một biến kiểu giá trị thì biến đó sẽ lưu giá trị của đối tượng lưu trữ,
// còn kiểu tha chiếu biến chứa địa chỉ con trỏ đến nơi lưu đối tượng thực. 