using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._01_Strategy
{
    public class TaxCalculator
    {
        public static double Calculate(Budget budget, ITax tax)
        {
            return tax.CalculateTax(budget);
        }
    }
}
