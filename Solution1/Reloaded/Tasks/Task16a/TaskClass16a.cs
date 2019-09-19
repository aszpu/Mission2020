using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.Task16a
{
    public class TaskClass16a
    {
        public void Test()
        {
            var autorList = new List<AutorKsiazki>
            {
                new AutorKsiazki("Marian", "Książkowy"),
                new AutorKsiazki("Zdzisław", "Powieściopisarz"),
                new AutorKsiazki("Wojciech", "Autorski"),
            };

            var gatunekList = new List<GatunekKsiazki>
            {
                new GatunekKsiazki("powieść"),
                new GatunekKsiazki("nowela"),
                new GatunekKsiazki("opowiadanie"),
            };

            var ksiazkaList = new List<Ksiazka>
            {
                new Ksiazka("Pierwsza książka", 1983, gatunekList[0], autorList[0], 999),
                new Ksiazka("Druga książka", 2018, gatunekList[1], autorList[1], 123),
                new Ksiazka("Trzecia książka", 2001, gatunekList[2], autorList[2], 777),
                new Ksiazka("Czwarta książka", 2019, gatunekList[0], autorList[0], 333),
            };

            try { ksiazkaList[0].Wypozycz(); } catch (Exception ex) { Console.WriteLine(ex.Message); }
            try { ksiazkaList[0].Wypozycz(); } catch (Exception ex) { Console.WriteLine(ex.Message); }

            try { ksiazkaList[0].Oddaj(); } catch (Exception ex) { Console.WriteLine(ex.Message); }
            try { ksiazkaList[0].Oddaj(); } catch (Exception ex) { Console.WriteLine(ex.Message); }
        }
    }
}
