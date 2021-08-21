namespace Static
{

    /**
Thành viên tĩnh trong lớp C#

     - Các thành viên trong lớp (phương thức, biến, thuộc tính) khi khao báo có từ khóa static ở đầu thì nó là thành viên tĩnh. Thành viên tĩnh nó không thuộc đối tượng 
     củ thể nào. Có thể sử dụng mà không cần tạo đối tượng. Truy cập thành viên tĩnh thông qua TÊN-LỚP.tên-thành-viên-tĩnh.
     - Đối với biến tĩnh thì dùng cho mọi đối tượng thuộc lớp, được khởi tạo một lần duy nhất. Nếu muốn khởi tạo thành viên tĩnh của lớp khi lần đầu truy cập
     có thể dùng phương thức khởi tạo tĩnh.
    **/


    // Sử dụng biến tình
    public class BienTinh
    {
        public class CountNumber
        {
            // biến tĩnh
            public static int num = 0;

            public void count()
            {
                num++;
            }


            public int getNum()
            {
                return num;
            }

        }
    }

    // Sử dụng phương thức tĩnh

    public class PhuongThucTinh
    {
        public class MethodStatic
        {
            public static int Sum(int a, int b)
            {
                return a + b;
            }
        }
    }
}