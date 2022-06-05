using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._01_Strategy
{
    public interface ITax
    {
        public double CalculateTax (Budget budget); 

    }
}
