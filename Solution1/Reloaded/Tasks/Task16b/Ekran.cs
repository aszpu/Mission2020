﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.Task16b
{
    public class Ekran
    {
        public Ekran()
        {

        }

        public Ekran(double przekatna, bool czyPolysk, Rozdzielczosc rozdzielczosc)
        {
            Przekatna = przekatna;
            CzyPolysk = czyPolysk;
            Rozdzielczosc = rozdzielczosc;
        }

        public double Przekatna { get; set; }
        public bool CzyPolysk { get; set; }
        public Rozdzielczosc Rozdzielczosc { get; set; }
    }
}
