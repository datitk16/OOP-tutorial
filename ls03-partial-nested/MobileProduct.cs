using System;
namespace Mobile
{
    public class MobileProduct
    {
        public Manufactory manufactory { get; set; }

        public class Manufactory
        {
            string address;
            public Manufactory(string address){
                this.address = address;
            }

            public void ShowAddress(){
               Console.WriteLine(address);
            }

        }

        public void ProductInfo(){
            manufactory.ShowAddress();
        }
    }
}