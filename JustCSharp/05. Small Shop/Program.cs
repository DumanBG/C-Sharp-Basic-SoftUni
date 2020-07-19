using System;

namespace _05._Small_Shop
{
    class Program
    {
        static void Main(string[] args)
        {

            string product = Console.ReadLine();
            string city = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            if (product=="coffee")
            {
                switch (city)
                {

                    case "Sofia":
                        Console.WriteLine(quantity * 0.5);
                        break;
                    case "Plovdiv":
                        Console.WriteLine(quantity * 0.4);
                        break;
                    case "Varna":
                        Console.WriteLine(quantity * 0.45);
                        break;

                }
            }
            else if (product == "water")
            {
                switch (city)
                {

                    case "Sofia":
                        Console.WriteLine(quantity * 0.8);
                        break;
                    case "Plovdiv":
                        Console.WriteLine(quantity * 0.7);
                        break;
                    case "Varna":
                        Console.WriteLine(quantity * 0.7);
                        break;
                }
            }
            else if (product == "beer")
            {
                switch (city)
                {

                    case "Sofia":
                        Console.WriteLine(quantity * 1.2);
                        break;
                    case "Plovdiv":
                        Console.WriteLine(quantity * 1.15);
                        break;
                    case "Varna":
                        Console.WriteLine(quantity * 1.10);
                        break;
                }

            }
            else if (product == "sweets")
            {
                switch (city)
                {

                    case "Sofia":
                        Console.WriteLine(quantity * 1.45);
                        break;
                    case "Plovdiv":
                        Console.WriteLine(quantity * 1.3);
                        break;
                    case "Varna":
                        Console.WriteLine(quantity * 1.35);
                        break;
                }
            }
            else if (product == "peanuts")
            {
                switch (city)
                {

                    case "Sofia":
                        Console.WriteLine(quantity * 1.6);
                        break;
                    case "Plovdiv":
                        Console.WriteLine(quantity * 1.5);
                        break;
                    case "Varna":
                        Console.WriteLine(quantity * 1.55);
                        break;
                }
            }
        }
    }

}