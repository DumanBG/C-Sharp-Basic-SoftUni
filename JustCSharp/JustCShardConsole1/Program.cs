using System;

namespace JustCShardConsole1
{
    class Program
    {
        static void Main(string[] args)
        {
            double depositSum = double.Parse(Console.ReadLine());

            var sum = depositSum * 2.54;
            Console.WriteLine(sum);

        }
    }
}
