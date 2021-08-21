namespace ls01_class
{
    public class VuKhi
    {
        // tên vũ khí súng trường, lục, dao
        public string name = " Tên vũ khí";
        /// Độ sát thương 10 cấp độ
        int dosatthuong = 0;

        /// Phương thức khởi tạo được tạo khi toán tử new gọi đối tượng
        /// Tên phương thức, trường hợp này không tham số

        public VuKhi()
        {
            this.dosatthuong = 1;
        }

        /// Phương thức khởi tạo được tạo khi toán tử new gọi đối tượng
        /// Tên phương thức, trường hợp này có tham số

        public VuKhi(string name, int dosatthuong)
        {
            this.name = name;
            this.SetDoSatThuong(dosatthuong);
        }

        /// Hàm này thiết lập độ sát thương

        public void SetDoSatThuong(int mucdo)
        {
            this.dosatthuong = mucdo;
        }

        /// In ra tên vũ khí bằng độ sát thương

        public void TanCong(){
              Console.Write(name + ": \t");
            for (int i = 0; i < dosatthuong; i++)
            {
                Console.Write(" * ");
            }
            Console.WriteLine();
        }
    }
}