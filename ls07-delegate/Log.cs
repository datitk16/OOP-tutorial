using System;

namespace Delegate
{
    public class Log
    {
        // khai báo một delegate 
        public delegate void ShowLog(string message);

        // phương thức tương đồ với ShowLog (tham số, kiểu trả về)
        static public void Info(string s)
        {
            Console.WriteLine(string.Format("Info: {0}", s));
        }

        static public void Warning(string s)
        {
            Console.WriteLine(string.Format("Waring: {0}", s));
        }

        public static void TestShowLog()
        {
            ShowLog showLog;
            showLog = Info;// showlog được gán bằng phương thức Info
            showLog("Thông báo info"); // thi hành delegate chính là thi hành Info

            showLog = Warning;
            showLog("Thông báo warning");

        }


        /// Gán nhiều phương thức vào delegate
        public static void TestShowLogMulti()
        {
            ShowLog showLog;

            showLog = null;

            showLog += Warning; // nối thêm warning vào delegate 
            showLog += Info; // nối thêm Info vào delegate 
            showLog += Warning; // Nối thêm Warning vào delegate 

            // Mỗi lần gọi thi hành tất cả các phương thức trong chuỗi delegate
            showLog("TestLog");
        }


        // Các delegate cùng kiểu có thể kết hợp lại với nhau 

        public static void TestShowLogPlus()
        {
            ShowLog log = (x) => { Console.WriteLine($"------{x}--------"); };
            ShowLog log1 = Warning;
            ShowLog log2 = Info;

            var all = log + log1 + log2;

            all("Xin chào");
        }

        // Function và Action là hai delegate định nghĩa sẵn, giúp bạn nhanh chóng tạo ta kiểu delegate mà không mất thời gian khai báo

        public class FuncAction
        {
            static int Sum(int x, int y)
            {
                return x + y;
            }

            public static void TestFunc(int x, int y)
            {
                Func<int, int, int> tinhtong;
                tinhtong = Sum;
                var ketqua = tinhtong(x, y);
                Console.WriteLine(ketqua);
            }
        }

    }
}