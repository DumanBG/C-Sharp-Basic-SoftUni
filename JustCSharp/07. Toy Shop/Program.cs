using System;

namespace _07._Toy_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Пъзел - 2.60 лв.
            // Говореща кукла -3 лв.
            // Плюшено мече -4.10 лв.
            // Миньон - 8.20 лв.
            // Камионче - 2 лв.

            //            Цена на екскурзията - реално число в интервала[1.00 … 10000.00]
            //2.Брой пъзели - цяло число в интервала[0… 1000]
            //3.Брой говорещи кукли -цяло число в интервала[0 … 1000]
            //4.Брой плюшени мечета -цяло число в интервала[0 … 1000]
            //5.Брой миньони - цяло число в интервала[0 … 1000]
            //6.Брой камиончета - цяло число в интервала[0 … 1000]
            double excursionPrice = double.Parse(Console.ReadLine());
            int puzzleCount = int.Parse(Console.ReadLine());
            int dollsCount = int.Parse(Console.ReadLine());
            int bearsCount = int.Parse(Console.ReadLine());
            int minionsCount = int.Parse(Console.ReadLine());
            int trucksCount = int.Parse(Console.ReadLine());
            double sum = puzzleCount * 2.6 + dollsCount * 3 + bearsCount * 4.1 + minionsCount * 8.2 + trucksCount * 2;
            int countAllToys= puzzleCount + dollsCount + bearsCount + minionsCount + trucksCount;
            if (countAllToys >= 50)
            {
                sum = sum * 0.75;
            }
            sum = sum - sum * 0.1;
            double moneyNeed = sum - excursionPrice;
            double moneyLeft = excursionPrice - sum;
            if (excursionPrice <= sum)
            {
                Console.WriteLine($"Yes! {moneyNeed:F2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {moneyLeft:F2} lv needed.");
            }






            
        }
    }
}
