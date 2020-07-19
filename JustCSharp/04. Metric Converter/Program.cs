using System;

namespace _04._Metric_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());

            string merge = Console.ReadLine();
            string finalMerge = Console.ReadLine();
            double mergeInMM = 0;
            if (merge == "m")
            {
                mergeInMM = number * 1000;
            }
            else if (merge == "cm")
            {
                mergeInMM = number * 10;
            }
            else if (merge == "mm")
            {
                mergeInMM = number;
            }
            if (finalMerge == "m")
            {
                Console.WriteLine($"{mergeInMM / 1000:F3}");
            }
            else if (finalMerge == "cm")
            {
                Console.WriteLine($"{mergeInMM / 10:F3}");
            }
            else if (finalMerge == "mm")
            {
                Console.WriteLine($"{mergeInMM:F3}");
            }




        }


        }
    }