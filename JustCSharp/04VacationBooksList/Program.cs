using System;

namespace JustCShardConsole1
{
    class Program
    {
        static void Main(string[] args)
        {
            int pagesCount = int.Parse(Console.ReadLine());
            double pagesHour = double.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            double totalTimeNeeded = pagesCount / pagesHour;
            double daysNeed = totalTimeNeeded / days;
            Console.WriteLine(daysNeed);


        }
    }
}
