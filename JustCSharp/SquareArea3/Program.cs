using System;

namespace JustCShardConsole1
{
    class Program
    {
        static void Main(string[] args)
        {
            double depositSum = double.Parse(Console.ReadLine());

            var sum = depositSum * depositSum;
            Console.WriteLine(sum);

        }
    }
}
