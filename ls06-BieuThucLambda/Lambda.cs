using System;

namespace BieuThucLambda
{
    public class Lambda
    {
        public delegate int TinhTong(int x, int y);

        public static void TestBieuThucLambda()
        {
            TinhTong tinhTong;

            tinhTong = (int x, int y) =>
            {
                return x + y;
            };


            int ketqua = tinhTong(10, 15);
            Console.WriteLine(ketqua);

        }
    }
}