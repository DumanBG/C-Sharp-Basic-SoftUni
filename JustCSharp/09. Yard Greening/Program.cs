using System;

namespace _09._Yard_Greening
{
    class Program
    {
        static void Main(string[] args)
        {
            double meters = Double.Parse(Console.ReadLine());
            //Цената на един кв. м. е 7.61лв със ДДС.
            //18% отстъпка от крайната цена.
            var sumDiscount = meters * 7.61 * 0.82;
            var discount = meters * 7.61*0.18;
            Console.WriteLine($"{sumDiscount} lv.");
            Console.WriteLine($"{discount} lv.");
        }
    }
}
