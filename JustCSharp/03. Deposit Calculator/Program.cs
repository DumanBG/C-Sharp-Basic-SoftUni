using System;

namespace _03._Deposit_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double depositSum = double.Parse(Console.ReadLine());
            int depositTerm = int.Parse(Console.ReadLine());
            double annualInterestRate = double.Parse(Console.ReadLine());
            //сума = депозирана сума + срок на депозита * ((депозирана сума * годишен лихвен процент ) / 12)
            var interest = depositSum * annualInterestRate/100;
            var interestForMonth = interest / 12;
            var totalSum = depositSum +depositTerm*(interestForMonth);
            Console.WriteLine(totalSum);
        }
    }
}
