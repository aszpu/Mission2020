using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.Task16a
{
    public class AutorKsiazki
    {
        public AutorKsiazki()
        {

        }

        public AutorKsiazki(string imie, string nazwisko)
        {
            Imie = imie;
            Nazwisko = nazwisko;
        }

        public string Imie { get; set; }
        public string Nazwisko { get; set; }
    }
}
