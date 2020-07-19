using System;

namespace _11._Fruit_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            if (fruit == "banana")
            {
                switch (day)
                {
                    case "Monday":
                    case "Tuesday":
                    case "Wednesday":
                    case "Thursday":
                    case "Friday":
                        Console.WriteLine($"{quantity * 2.5:F2}");
                        break;
                    case "Saturday":
                    case "Sunday":
                        Console.WriteLine($"{quantity * 2.7:F2}");
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else if (fruit == "apple")
            {
                switch (day)
                {
                    case "Monday":
                    case "Tuesday":
                    case "Wednesday":
                    case "Thursday":
                    case "Friday":
                        Console.WriteLine($"{quantity * 1.2:F2}");
                        break;
                    case "Saturday":
                    case "Sunday":
                        Console.WriteLine($"{quantity * 1.25:F2}");
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }

            }
            else if (fruit == "orange")
            {
                switch (day)
                {
                    case "Monday":
                    case "Tuesday":
                    case "Wednesday":
                    case "Thursday":
                    case "Friday":
                        Console.WriteLine($"{quantity * 0.85:F2}");
                        break;
                    case "Saturday":
                    case "Sunday":
                        Console.WriteLine($"{quantity * 0.9:F2}");
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else if (fruit == "grapefruit")
            {
                switch (day)
                {
                    case "Monday":
                    case "Tuesday":
                    case "Wednesday":
                    case "Thursday":
                    case "Friday":
                        Console.WriteLine($"{quantity * 1.45:F2}");
                        break;
                    case "Saturday":
                    case "Sunday":
                        Console.WriteLine($"{quantity * 1.6:F2}");
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else if (fruit == "kiwi")
            {
                switch (day)
                {
                    case "Monday":
                    case "Tuesday":
                    case "Wednesday":
                    case "Thursday":
                    case "Friday":
                        Console.WriteLine($"{quantity * 2.7:F2}");
                        break;
                    case "Saturday":
                    case "Sunday":
                        Console.WriteLine($"{quantity * 3:F2}");
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else if (fruit == "pineapple")
            {
                switch (day)
                {
                    case "Monday":
                    case "Tuesday":
                    case "Wednesday":
                    case "Thursday":
                    case "Friday":
                        Console.WriteLine($"{quantity * 5.5:F2}");
                        break;
                    case "Saturday":
                    case "Sunday":
                        Console.WriteLine($"{quantity * 5.6:F2}");
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else if (fruit == "grapes")
            {
                switch (day)
                {
                    case "Monday":
                    case "Tuesday":
                    case "Wednesday":
                    case "Thursday":
                    case "Friday":
                        Console.WriteLine($"{quantity * 3.85:F2}");
                        break;
                    case "Saturday":
                    case "Sunday":
                        Console.WriteLine($"{quantity * 4.2:F2}");
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }

            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}