using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallTasks.TaxOperations
{
    public class RevenueGet
    {
        double _revenue;
        string _revenueString;
        bool _revenueParsed;

        public double GetRevenue()
        {
            Console.Clear();
            Console.WriteLine("Podaj swój roczny dochód:");
            _revenueString = Console.ReadLine();
            _revenueString = _revenueString.Replace(".", ","); // hehe, nieładnie ;) double.TryParse korzysta z ustawień systemowych. Jak ktoś ma system po polsku to separatorem jest przecinek. Jak po angielsku to kropka. I niczego nie trzeba konwertować. A jak zakładasz, że separatorem jest kropka...
            // to powinieneś wywołać double.TryParse z przekazaniem kultury (kultura - czytaj to jako ustawienia językowe ;) hehe):
            //double.TryParse(_revenueString, NumberStyles.Any, CultureInfo.InvariantCulture, out _revenue); // -- CultureInfo.InvariantCulture - kultura niezależna od kultury w systemie
            _revenueParsed = double.TryParse(_revenueString, out _revenue);

            return _revenue;
        }
    }
}
