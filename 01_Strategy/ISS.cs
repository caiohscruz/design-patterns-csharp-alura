using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._01_Strategy
{
    public class ISS : ITax
    {
        private readonly double percentage = 0.06;
        public double CalculateTax(Budget budget)
        {
            return budget.Value * percentage;
        }
    }
}
