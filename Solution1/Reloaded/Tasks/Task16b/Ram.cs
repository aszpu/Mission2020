using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.Task16b
{
    public class Ram
    {
        public Ram()
        {

        }

        public Ram(TypRamu typ, int rozmiar)
        {
            Typ = typ;
            Rozmiar = rozmiar;
        }

        public TypRamu Typ { get; set; }
        public int Rozmiar { get; set; }
    }
}
