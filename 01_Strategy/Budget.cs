using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._01_Strategy
{
    public class Budget
    {
        public double Value { get; private set; }

        public Budget(double value)
        {
            this.Value = value;
        }
    }
}
