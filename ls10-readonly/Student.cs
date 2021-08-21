/**

-  Biến readonly có nghĩa là chỉ đọc, không sửa đổi được nữa. Tuy nhiên so với hằng số const thì có mấy điểm khác như sau:
 Hằng số thì phải khởi tạo ngay giá trị cho nó khi khởi tạo, biến readonly thì không khởi tạo ngay cũng được.
 Biến readonnly có thể gán giá trị cho nó trong hàm khởi tạo ( và giá trị gán theo biểu thức nào đó).
**/

namespace Readonly
{
    public class Student
    {
        // Khai bao biến readonly

        public readonly string name;

        public Student(string name){
            this.name = name;
        }
        
    }
}