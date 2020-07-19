using System;
using System.Dynamic;
using System.Reflection;

namespace _08._Pet_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int dogCount = int.Parse(Console.ReadLine());
            int otherAnimalCount = int.Parse(Console.ReadLine());

            var dogFood = dogCount * 2.5;
            var foodOtherAnimal = otherAnimalCount * 4;
            var sum = dogFood + foodOtherAnimal;

            Console.WriteLine($"{sum} lv.");
          
        }
    }
}
