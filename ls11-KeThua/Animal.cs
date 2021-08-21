using System;
namespace KeThua
{
    public class Animal
    {
        public int Legs { get; set; }

        // protected int Legs {get;set;}
        public float Weigh { get; set; }

        public void ShowLegs()
        {
            Console.WriteLine($"Legs:{Legs}");
        }
    }
}