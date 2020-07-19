using System;

namespace JustCShardConsole1
{
    class Program
    {
        static void Main(string[] args)
        {
            double fromInchesToCentimeters = double.Parse(Console.ReadLine());

            var sum = fromInchesToCentimeters * 2.54;
            Console.WriteLine(sum);

        }
    }
}
