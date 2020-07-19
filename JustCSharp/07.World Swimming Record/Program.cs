using System;

namespace _07.World_Swimming_Record
{
    class Program
    {
        static void Main(string[] args)
        {
            double time = double.Parse(Console.ReadLine()); //секунди

            double distance = double.Parse(Console.ReadLine()); //метри
            double speed = double.Parse(Console.ReadLine()); // секунди за метър

            double resistance = (Math.Floor(distance / 15)) * 12.5; // тотал секунди забавяне
            double totalTimeSwim = distance * speed + resistance;

            if (totalTimeSwim < time)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {totalTimeSwim:F2} seconds.");


            }
            else
            {
                double delay = (totalTimeSwim - time);
                Console.WriteLine($"No, he failed! He was {delay:F2} seconds slower.");
            }
        }
    }
}
