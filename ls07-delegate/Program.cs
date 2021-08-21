using System;
using Delegate;
// - Delegate(hàm ủy quyền) là một kiểu dữ liệu, nó dùng để tham chiếu (trỏ đến) đến các hàm (phương thức) có tham số và kiểu trả về phù hợp với khai báo kiểu
// khi dùng đến delegate bạn có thể gán vào nó một, nhiều hàm (phương thức) có sự tương thích về tham số,kiểu trả về, sau đó dùng nó để gọi
namespace ls07_delegate
{
    class Program
    {
        public delegate void ShowLog(string message);
        static void Main(string[] args)
        {
            //    Log.TestShowLog();
            // Log.TestShowLogMulti();
            // Log.TestShowLogPlus();
            Log.FuncAction.TestFunc(3,4);
        }
    }
}
