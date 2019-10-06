using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.Task16fSandbox
{
    // konsolowy zapisywacz raportu wyszukiwania państw
    public class ConsoleCountriesSearchReportWriter
    {
        public void Write(CountryDto[] foundCountries) // zapis raportu na konsolę
        {
            Console.WriteLine("Odnaleziono następujące państwa:");

            foreach (var country in foundCountries)
            {
                Console.WriteLine($"- {country.Name.ToUpper()}");
                Console.WriteLine($"  - stolica: {country.Capital}");
                Console.WriteLine($"  - ludność: {country.Population / 1e6} milionów");
                Console.WriteLine($"  - powierzchnia: {country.Area} km^2");
                Console.WriteLine($"  - szerokość / długość geograficzna: {country.LatLng[0]} / {country.LatLng[1]}");
                Console.WriteLine($"  - gęstość zaludnienia: {country.Population/country.Area} mieszkańców / km^2");
                Console.WriteLine($"  - Kod Alpha-3 (zgodnie z ISO 3166): {country.Alpha3Code}");
            }
        }
    }
}
