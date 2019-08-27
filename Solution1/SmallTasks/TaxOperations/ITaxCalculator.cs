using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallTasks.TaxOperations
{
    public interface ITaxCalculator
    {
        int CalculateTax(double revenue);
    }
}
