using System;

namespace _06._Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Ако фигурата е квадрат, на следващия ред се чете едно число -дължина на страната му.
            // Ако фигурата е правоъгълник, на следващите два реда четат две числа -дължините на страните му.
            // Ако фигурата е кръг, на следващия ред чете едно число - радиусът на кръга.
            // Ако фигурата е триъгълник, на следващите два реда четат две числа -дължината на страната му и
            //дължината на височината към нея.
            string geometricShape = Console.ReadLine();
            double area = 0;
            if (geometricShape == "rectangle")
            {
                double width = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                area = width * height;
     
                Console.WriteLine($"{area:F3}");

            } else if (geometricShape == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                area = Math.PI * radius * radius;

                Console.WriteLine($"{area:F3}");
            }
            else if (geometricShape == "triangle")
            {

                double width = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                area = width * height / 2;

                Console.WriteLine($"{area:F3}");
            } else if (geometricShape == "square")
            {
                double width = double.Parse(Console.ReadLine());
                area = width * width;

                Console.WriteLine($"{area:F3}");
            }
           
         
        }
    }
}
