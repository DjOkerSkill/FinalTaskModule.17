using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTaskModule._17
{
    public interface IAccount
    {
        // баланс учетной записи
         double Balance { get; set; }

        // процентная ставка
         double Interest { get; set; }

         void CalculateInterest();
    }
}
