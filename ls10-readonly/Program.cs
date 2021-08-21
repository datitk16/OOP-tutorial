using System;
using Readonly;

namespace ls10_readonly
{
    class Program
    {
        static void Main(string[] args)
        {
           Student student = new Student("ABC");  // khởi tạo biến readonly trong hàm tạo
           string n = student.name;  // đọc biển readonly
           Console.WriteLine(n);
           s.name = "AA";                      // lỗi - vì không thể gán - chỉ có thể đọc
        }
    }
}
