using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTaskModule._17
{
        public class Calculator
        {
            // Метод для расчета процентной ставки
            public void Calculate(IAccount account)
            {
                 account.CalculateInterest();
            }
        }
    
}
