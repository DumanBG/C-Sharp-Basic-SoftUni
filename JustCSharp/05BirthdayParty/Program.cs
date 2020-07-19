using System;

namespace JustCShardConsole1
{
    class Program
    {
        static void Main(string[] args)
        {
            double rent = double.Parse(Console.ReadLine());
            double cakePrice = rent * 0.2;
            double drinksPrice = 0.55 * cakePrice;
            double animatorPrice = rent / 3;
            double needMoney = rent + cakePrice + drinksPrice + animatorPrice;
            Console.WriteLine(needMoney);
        }
    }
}
