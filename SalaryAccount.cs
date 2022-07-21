using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTaskModule._17
{
    public class SalaryAccount : IAccount
    {
        public double Balance { get ; set ; }
        public double Interest { get ; set ; }

        public SalaryAccount(double balance) 
        { 
            Balance = balance;
        }

        public void CalculateInterest()
        {
            Interest = Balance * 0.5;

            Console.WriteLine($"Процентная ставка составляет:{Interest} %");
        }
    }
}
