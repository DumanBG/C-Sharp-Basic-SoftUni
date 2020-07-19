using System;

namespace _08._Scholarshi
{
    class Program
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            double grade = double.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());
            double social = 0.35 * salary;
            double excellent = grade * 25;
            if (grade <= 4.5 || (grade < 5.5 && income > salary))
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
            else if (grade > 4.5 && grade < 5.5)
            {
                Console.WriteLine($"You get a Social scholarship {Math.Floor(social):F0} BGN");
            }
            else if ((grade >= 5.5 && social < excellent) || (grade >= 5.5 && income > salary))
            {
                Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(excellent):F0} BGN");
            }
            else
            {
                Console.WriteLine($"You get a Social scholarship {Math.Floor(social):F0} BGN");
            }
        }

    }
}
