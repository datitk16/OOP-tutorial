
//public : không giới hạn phạm vi truy cập
//protected : chỉ truy cập trong nội bộ lớp hay các lớp kế thừa
//private : (mặc định) chỉ truy cập được từ các thành viên của lớp chứa nó
//internal : chỉ truy cập được trong cùng assembly (dll, exe)
//protected internal: truy cập được khi cùng assembly hoặc lớp kế thừa
//private protected: truy cập từ lớp chứa nó, lớp kế thừa nhưng phải cùng assembly
using System;
using System.Diagnostics;

namespace ls01_class
{
    class Program
    {
        static void Main(string[] args)
        {
            var sungluc = new VuKhi(); // khai báo và khởi tạo
            sungluc.name = "Súng lục";
            sungluc.SetDoSatThuong(5);

            VuKhi sungtruong = new VuKhi();
            sungtruong.name =" Súng trường";
            sungtruong.SetDoSatThuong(20);


            sungluc.TanCong();
            sungtruong.TanCong();
        }
    }
}