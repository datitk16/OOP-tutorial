using System;

using KeThua;
/**
kế thừa là một trong 4 khía cạnh của lập trình hướng đối tượng , nó cho phép chúng ta có khả năng định nghĩa ra một lớp mới dựa trên một lớp khác có sẵn
kế thừa giúp cho việc mở rộng code bảo trì trở nên dễ hơn.

ví dụ: lớp NhanVien mô tả chung (thuộc tính) về nhân viên trong một công ty (chức năng, nhiệm vụ,văng bằng,...) kể cả cách ứng xử(phương thức) của nhân viên.
Từ đó kế thừa lại xây dựng nên lớp mới cho nhân viên lễ tân NhanVienLeTan, nhân viên bán hàng NhanVienBanHang,..., nhưng lớp mới đã kế thừa lại các thông tin của lớp
cơ sở và thêm những đặc tính riêng của nó.

- public : thành viên có thể truy cập code bất kỳ đâu
- private: phương thức , thuộc tính trường khai báo với private chỉ có thể gọi hoặc truy cập bởi những dòng code trong cùng.
- protected : Phương thức thuộc tính , trường chỉ có thể truy cập, bởi dòng code cùng lớp, hoặc các lớp kế thừa của nó.

**/

namespace ls11_KeThua
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            cat.ShowLegs();
            cat.Eat();
       
            Console.WriteLine(cat.Legs); // 4 nếu Legs khai báo public 
        }
    }
}
