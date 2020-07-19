using System;

namespace _08FishTank
{
    class Program
    {
        static void Main(string[] args)
        {
            var length = double.Parse(Console.ReadLine());
            var width = double.Parse(Console.ReadLine());
            var hight = double.Parse(Console.ReadLine());
            var percent = double.Parse(Console.ReadLine());
            // 1 liter water = 1 dm3
            var volume = length * width * hight;
            volume = volume * 0.001;
            volume = volume - volume * percent/100;
        


            Console.WriteLine($"{volume}");
        }
    }
}
