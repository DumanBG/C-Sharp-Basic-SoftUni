using System;

namespace _07FruitMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Цена на ягодите в лева – реално число в интервала[0.00 … 10000.00]
            //2.Количество на бананите в килограми – реално число в интервала[0.00 … 1 0000.00]
            //3.Количество на портокалите в килограми – реално число в интервала[0.00 … 10000.00]
            //4.Количество на малините в килограми – реално число в интервала[0.00 … 10000.00]
            //5.Количество на ягодите в килограми – реално число в интервала[0.00 … 10000.00]
            //        }
            double strawberryPrice = double.Parse(Console.ReadLine());
            double bananaKg = double.Parse(Console.ReadLine());
            double orangeKg = double.Parse(Console.ReadLine());
            double raspberryKg = double.Parse(Console.ReadLine());
            double strawberryKg = double.Parse(Console.ReadLine());
            //            цената на малините е на половина по - ниска от тази на ягодите;
            // цената на портокалите е с 40 % по - ниска от цената на малините;
            // цената на бананите е с 80 % по - ниска от цената на малините.
            double rasberryPrice = strawberryPrice / 2;
            double orangePrice = rasberryPrice * 0.6;
            double bananaPrice = rasberryPrice * 0.2;

            double moneyNeed = strawberryKg * strawberryPrice + bananaKg * bananaPrice + raspberryKg * rasberryPrice + orangeKg * orangePrice;
            Console.WriteLine($"{moneyNeed:f2}");
        }

    }
}
