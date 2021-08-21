using System;
using HamHuy;

namespace ls08_HamHuy
{
    class Program
    {

        static void TestConstructor()
        {
           Product p = new Product("ABC");// Tạo biến p tham chiếu đến đối tượng 
           p = null;
           // biến p gán bằng null, đối tượng tạo ở phía trên 
           // không còn biến nòa tham chiếu đến=> nó được đánh giấu
           // sẽ bị thu hồi GC, lúc nào GC chạy do .Net quyết định
        }
        static void Main(string[] args)
        {
            TestConstructor();

            // Ép hệ thống thu hồi bộ nhớ (thực tế không cần ép, nó sẽ chạy khi cần);

            GC.Collect();
        }
    }
}
