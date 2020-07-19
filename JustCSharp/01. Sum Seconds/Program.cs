using System;

namespace _01._Sum_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {

            int one = int.Parse(Console.ReadLine());
            int two = int.Parse(Console.ReadLine());
            int three = int.Parse(Console.ReadLine());
            int sum = two + three + one;
            int minute = sum / 60;
            int second = sum % 60;
            if (second < 10)
            {

                // 0-ла пред{}, докато при java 0%d
                Console.WriteLine($"{minute}:0{second}");

            }
            else
            {
                Console.WriteLine($"{minute}:{second}");

            }
        }
    }

}



        
  
