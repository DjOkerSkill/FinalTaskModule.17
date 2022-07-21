using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTaskModule._17
{
    public class OrdinaryAccount : IAccount
    {
        public double Balance { get ; set ; }
        public double Interest { get ; set ; }

        public OrdinaryAccount(double balance) 
        {
            Balance = balance;
        }

        public void CalculateInterest()
        {
            Interest = Balance * 0.4;

            if (Balance < 1000)
                Interest -= Balance * 0.2;

            if (Balance < 50000)
                Interest -= Balance * 0.4;

            Console.WriteLine($"Процентная ставка составляет:{Interest} %");
        }
    }
}
