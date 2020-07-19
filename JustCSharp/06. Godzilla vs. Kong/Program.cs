using System;

namespace _06._Godzilla_vs._Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budjet = double.Parse(Console.ReadLine()); 
            int statistCOunt = int.Parse(Console.ReadLine());
            double clothPrice = double.Parse(Console.ReadLine());
            double dekor = budjet * 0.1;
            double costs = statistCOunt * clothPrice;
            if (statistCOunt >= 150)
            {
                costs = costs * 0.9;
            }
            double moneyLeft = budjet - costs - dekor;
            double moneyNeed = costs + dekor - budjet;
            if (budjet >= costs + dekor)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {moneyLeft:F2} leva left.");
                
            }
            else
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {moneyNeed:F2} leva more.");
            }
        }
    }
}
 