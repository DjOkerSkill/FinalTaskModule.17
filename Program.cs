using System;

namespace FinalTaskModule._17
{
    public class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            calculator.Calculate(new OrdinaryAccount(100));

            calculator.Calculate(new SalaryAccount(10000));
        }
    }
}
