using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._01_Strategy
{
    public class _StrategyExample
    {
        public static void Execute()
        {
            Budget budget = new Budget(5000);

            ICMS icms = new ICMS();

            ISS iss = new ISS();

            /* DOWN HERE IS WHERE THE MAGIC HAPPENS */

            double icmsValue = TaxCalculator.Calculate(budget, icms);

            double issValue = TaxCalculator.Calculate(budget, iss);

            Console.WriteLine($"ICMS = {icmsValue}");

            Console.WriteLine($"ISS = {issValue}");

            Console.ReadKey();

            /* O Strategy é um padrão de projeto comportamental que permite que você defina uma família de algoritmos, 
            coloque-os em classes separadas, e faça os objetos deles intercambiáveis. */
        }
    }
}
