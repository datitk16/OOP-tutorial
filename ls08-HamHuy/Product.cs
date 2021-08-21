

/**
Hàm (phương thức) hủy của lớp Finalizer hoặc Destructor
Trong.Net có dịch vụ hệ thống tên GC (garbage collector) nó là dịch vụ chạy một cách chủ động nhằm thu hồi bộ nhớ do .Net cấp trên HEAP
GC được cấp thi hành tự động kh hệ thống thấy thiếu bộ nhớ - mặc dù bạn có thể yêu cầu .Net thu hồi bộ mjows không còn dùng đến bằng cách gọi GC.Collect();

Bộ nhớ HEAP là nơi lưu các đối tượng được tạo ra từ lớp (toán tử new) khi đối 
tượng đó không còn biến nào tham chiếu(trỏ) đến thì nó đeuọc đánh dấu thu hồi - và khi đó GC thu hồi
- phương thức hủy sẽ thi hành
**/

using System;

namespace HamHuy
{
    public class Product
    {
        private string product_name;
        public Product(string name){
            this.product_name = name;
            Console.WriteLine("Tao - ", product_name);
        }

        ~Product(){
            Console.WriteLine("Huy - " , product_name);
        }
        
    }
}