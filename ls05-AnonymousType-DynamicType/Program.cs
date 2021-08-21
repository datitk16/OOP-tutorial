
// Kiểu vô danh C#
// Kiểu vô danh (Anonymous Type) - là kiểu không có tên. C# cho phép bạn tạo ra các đối tượng kiểu vô danh bằng từ khóa new,
//  cú pháp cơ bản để tạo ra đối tượng có kiểu vô danh như sau:

// var obj = new {
//     thuoctinh1 = giatri1,
//     thuoctinh2 = giatri2
// }

// Bằng cú pháp như vậy, tạo ra được đối tượng chứa các thuộc tính (chú ý - thuộc tính là chỉ đọc), bạn tạo ra đối tượng mà không cần phải khai báo lớp

// Ví dụ: tạo đối tượng có 3 thuộc tính

// var myProfile = new
//                 {
//                     name = "XuanThuLab",
//                     age = 20,
//                     skill = "ABC"
//                 };

// Để truy cập thuộc tính của toán tử vẫn dùng ký hiệu . và tên thuộc tính.

// Console.WriteLine(myProfile.name);
// Kiểu vô danh Anonymous Type - được dùng phổ biến trong LINQ (tìm hiểu phần sau)

// Khi có đối tượng kiểu vô danh, nếu dùng nó truyền như tham số cho các phương thức - coi nó như các object có thể gây lỗi khi buil ứng dụng - 
// trình biên dịch kiểm tra và báo lỗi. Để giải quyết vấn đề này có thể dùng đến khai báo kiểu dynamic

using System;

namespace ls05_AnonymousType_DynamicType
{
    class Program
    {
        static void Main(string[] args)
        {
            var myProfile = new
            {
                name = "XuanThuLab",
                age = 20,
                skill = "ABC"
            };
            TestDynamicType(myProfile); // In ra 20
            // phương thức trên ở thời điểm chạy mà đối tượng ở tham số có thuộc tính age thì sẽ không lỗi còn nếu không có thuộc tính age sẽ sinh ra ngoại lệ
        }

        static void TestDynamicType(dynamic dyn)
        {
            Console.WriteLine(dyn.age); // ở thời điểm biên dịch không biết dyn có thuộc tính age hay không nhưng nó vẫn biên dịch
        }
    }
}
