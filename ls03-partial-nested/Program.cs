using System;
using Mobile;

using ls03_partial_nested;

namespace ls03_partial_nested
{
    class Program
    {
        static void Main(string[] args)
        {
            //   Sanpham.Product product = new Sanpham.Product();
              
            //   product.Name = "Dien thoai samsung";

            //   Console.WriteLine(product.getInfo());

              Mobile.MobileProduct mobileProduct = new MobileProduct();
              mobileProduct.manufactory = new MobileProduct.Manufactory("Test");
              mobileProduct.ProductInfo();


        }
    }
}
