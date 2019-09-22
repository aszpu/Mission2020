using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.Task16c
{
    public class FunkcjaLiniowa
    {
        public FunkcjaLiniowa()
        {

        }

        public FunkcjaLiniowa(double a, double b)
        {
            A = a;
            B = b;
        }

        public double A { get; set; }
        public double B { get; set; }

        public bool CzyRosnaca {
            get
            {
                if (A > 0) { return true; } else { return false; }
            }
        }

        public bool CzyMalejaca {
            get
            {
                if (A < 0) { return true; } else { return false; }
            }
        }

        public bool CzyStala {
            get
            {
                if (A == 0) { return true; } else { return false; }
            }
        }

        public double ObliczWartosc(double x)
        {
            return A * x + B; 
        }

        public double ObliczMiejsceZerowe()
        {
            if (CzyStala)
            {
                if (B == 0)
                {
                    return 0;
                }
                else
                {
                    throw (new Exception("Funkcja stała! Nie ma miejsca zerowego."));
                }                
            }
            else
            {
                return -B / A;
            }
        }
    }
}
