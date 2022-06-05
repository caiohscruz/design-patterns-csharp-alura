using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._01_Strategy
{
    public class ICMS : ITax
    {
        private readonly double percentage = 0.10;
        public double CalculateTax(Budget budget)
        {
            return budget.Value * percentage;
        }
    }
}
