
using System;

namespace KeThua
{
    public class Cat : Animal
    {
        public string food;

        public Cat(){
            Legs = 4;
            food = "Mouse";
        }

        public void Eat(){
            Console.WriteLine(food);
        }

    }
}