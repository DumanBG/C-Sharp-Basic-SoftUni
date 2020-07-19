using System;

namespace GreatingbyName
{
    class Program
    {
        static void Main(string[] args)
        {
       
            int days = int.Parse(Console.ReadLine());
            int coockers = int.Parse(Console.ReadLine());
            int cakes = int.Parse(Console.ReadLine());
            int waffles = int.Parse(Console.ReadLine());
            int pancakes = int.Parse(Console.ReadLine());
            double cakesPrice = cakes * coockers * days * 45.00;
            double wafflesPrice =waffles * coockers * days * 5.8;
            double pancakesPrice = pancakes * coockers * days * 3.2;
            double totalMoney = (wafflesPrice + cakesPrice + pancakesPrice );
            totalMoney = totalMoney - totalMoney *0.125;


            Console.WriteLine($"{totalMoney:F2}");


        }

    }
}
