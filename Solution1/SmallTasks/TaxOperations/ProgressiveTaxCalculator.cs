using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallTasks.TaxOperations
{
    public class ProgressiveTaxCalculator : ITaxCalculator
    {

        private const double Threshold = 85528.00; // Consty nazywamy camel casem (nie ważne czy publiczne czy prywatne) czyli Threshold, Reduction. Za to bardzo dobrze, że wyciągnąłeś to do constów. Jeszcze 0.18 i 0.32 też można by wyciągnąć do constów.
        private const double Reduction = 556.02;

        public int CalculateTax(double revenue)
        {
            double tax;

            if (revenue <= Threshold)
            {
                tax = FirstLevelTax(revenue);
            }
            else
            {
                double revenueAboveThreshold = revenue - Threshold;
                tax = FirstLevelTax(Threshold) + SecondLevelTax(revenueAboveThreshold);
            }

            return (int)Math.Round(tax, 0);
        }

        private double FirstLevelTax(double firstLevelRevenue)
        {
            return firstLevelRevenue * .18 - Reduction;
        }

        private double SecondLevelTax(double secondLevelRevenue)
        {
            return secondLevelRevenue * .32;
        }
    }
}
