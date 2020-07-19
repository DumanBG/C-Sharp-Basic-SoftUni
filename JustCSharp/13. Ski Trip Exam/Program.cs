using System;

namespace _13._Ski_Trip_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string room = Console.ReadLine();
            string grade = Console.ReadLine();
            double roomOne = 18;
            double apartmentTwo = 25;
            double president = 35;
            if (grade == "positive")
            {
                if (days < 10)
                {
                    switch (room)
                    {
                        case "room for one person":
                            Console.WriteLine($"{18 * (days - 1) * 1.25:F2}");
                            break;
                        case "apartment":
                            Console.WriteLine($"{25 * (days - 1) * 0.7 * 1.25:F2}");

                            break;
                        case "president apartment":
                            Console.WriteLine($"{35 * (days - 1) * 0.9 * 1.25:F2}");

                            break;
                    }
                }
                else if (days <= 15)
                {
                    switch (room)
                    {
                        case "room for one person":
                          
                            Console.WriteLine($"{18 * (days - 1) * 1.25:F2}");
                            break;
                        case "apartment":
                            Console.WriteLine($"{25 * (days - 1) * 0.65 * 1.25:F2}");

                            break;
                        case "president apartment":
                            Console.WriteLine($"{35 * (days - 1) * 0.85 * 1.25:F2}");

                            break;
                    }
                }
                else if (days > 15)
                {
                    switch (room)
                    {
                        case "room for one person":
                            Console.WriteLine($"{18 * (days - 1) * 1.25:F2}");

                            break;
                        case "apartment":
                            Console.WriteLine($"{25 * (days - 1) * 0.5 * 1.25:F2}");

                            break;
                        case "president apartment":
                            Console.WriteLine($"{35 * (days - 1) * 0.8 * 1.25:F2}");

                            break;
                    }
                }
            }
            else if (grade == "negative")
            {
                if (days < 10)
                {
                    switch (room)
                    {
                        case "room for one person":
                            Console.WriteLine($"{18 * (days - 1) * 0.9:F2}");

                            break;
                        case "apartment":
                            Console.WriteLine($"{25 * (days - 1) * 0.7 * 0.9:F2}");

                            break;
                        case "president apartment":
                            Console.WriteLine($"{35 * (days - 1) * 0.9 * 0.9:F2}");

                            break;
                    }
                }
                else if (days <= 15)
                {
                    switch (room)
                    {
                        case "room for one person":
                            Console.WriteLine($"{18 * (days - 1) * 0.9:F2}");

                            break;
                        case "apartment":
                            Console.WriteLine($"{25 * (days - 1) * 0.65 * 0.9:F2}");

                            break;
                        case "president apartment":
                            Console.WriteLine($"{35 * (days - 1) * 0.85 * 0.9:F2}");

                            break;
                    }
                }
                else if (days > 15)
                {
                    switch (room)
                    {
                        case "room for one person":
                            Console.WriteLine($"{18 * (days - 1) * 0.9:F2}");

                            break;
                        case "apartment":
                            Console.WriteLine($"{25 * (days - 1) * 0.5 * 0.9:F2}");

                            break;
                        case "president apartment":
                            Console.WriteLine($"{35 * (days - 1) * 0.8 * 0.9:F2}");

                            break;
                    }
                }
            }
        }
    }
}