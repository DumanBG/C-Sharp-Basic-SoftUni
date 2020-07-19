using System;

namespace _05._Time___15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minute = int.Parse(Console.ReadLine());
            int timeInMinute = hour * 60 + minute + 15;
            int timeHour = timeInMinute / 60;
            int timeMinute = timeInMinute % 60;
            if (timeHour >= 24)
            {
                timeHour -= 24;
            }
            if (timeMinute <= 9)
            {
                Console.WriteLine($"{timeHour}:0{timeMinute}");
             
            }
            else
            {
                Console.WriteLine($"{timeHour}:{timeMinute}");
               
            }
        }
    }
}

