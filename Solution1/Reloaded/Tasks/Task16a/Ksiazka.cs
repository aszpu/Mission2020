using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.Task16a
{
    public class Ksiazka
    {
        public Ksiazka()
        {

        }

        public Ksiazka(string tytul, int rokWydania, GatunekKsiazki gatunek, AutorKsiazki autor, int liczbaStron)
        {
            Tytul = tytul;
            RokWydania = rokWydania;
            Gatunek = gatunek;
            Autor = autor;
            LiczbaStron = liczbaStron;
        }

        public string Tytul { get; set; }
        public int RokWydania { get; set; }
        public GatunekKsiazki Gatunek { get; set; }
        public AutorKsiazki Autor { get; set; }
        public int LiczbaStron { get; set; }
        public bool CzyWypozyczona { get; private set; }

        public void Wypozycz()
        {
            if (CzyWypozyczona)
            {
                throw (new Exception("Nie można wypożyczyć książki. Książka jest aktualnie wypożyczona!"));
            }
            else
            {
                CzyWypozyczona = true;
            }
            
        }

        public void Oddaj()
        {
            if (!CzyWypozyczona)
            {
                throw (new Exception("Nie można oddać książki. Książka nie jest aktualnie wypożyczona!"));
            }
            else
            {
                CzyWypozyczona = false;
            }
        }
    }
}
