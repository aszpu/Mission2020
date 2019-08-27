using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallTasks.TaxOperations
{
    public class TaxRunner
    {        
        public void Run()
        {
            Console.WriteLine("Podaj typ podatku: [1] liniowy, [2] progresywny");
            var choiceKey = Console.ReadKey();

            ITaxCalculator taxCalculator = null;
            string taxName = null;

            switch (choiceKey.KeyChar)
            {
                case '1':
                    taxCalculator = new LinearTaxCalculator();
                    taxName = "liniowy";
                    break;
                case '2':
                    taxCalculator = new ProgressiveTaxCalculator();
                    taxName = "progresywny";
                    break;
                default:
                    Console.WriteLine(" Nieprawidłowy wybór!");
                    break;
            }

            if (taxCalculator != null)
            {
                var getRevenue = new RevenueGet();
                double revenue = getRevenue.GetRevenue();
                int tax = taxCalculator.CalculateTax(revenue);
                Console.WriteLine("Podatek {0} za rok: {1}", taxName, tax);
            }

            Console.ReadKey();
        }
    }
}
