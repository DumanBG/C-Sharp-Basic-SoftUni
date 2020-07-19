using System;

namespace _07._Projects_Creation
{
    class Program
    {
        static void Main(string[] args)
        {
            string architectName = Console.ReadLine();
            int projectCount = int.Parse(Console.ReadLine());
            int timeForAllProjects = projectCount * 3;

            Console.WriteLine($"The architect {architectName} will need {timeForAllProjects} hours to complete {projectCount} project/s.");
        }
    }
}
