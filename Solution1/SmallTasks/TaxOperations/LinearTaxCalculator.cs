using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallTasks.TaxOperations
{
    public class LinearTaxCalculator : ITaxCalculator
    {
        public int CalculateTax(double revenue)
        {
            double tax = revenue * 0.19;

            return (int)Math.Round(tax,0);
        }
    }
}
