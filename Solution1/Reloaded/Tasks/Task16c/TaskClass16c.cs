using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.Task16c
{
    public class TaskClass16c
    {
        public void Test()
        {
            var f1 = new FunkcjaLiniowa(0, 0);
            var wartoscF1 = f1.ObliczWartosc(3);
            double miejsceZeroweF1;
            try { miejsceZeroweF1 = f1.ObliczMiejsceZerowe(); } catch (Exception ex) { Console.WriteLine(ex.Message); }
            
            Console.ReadKey();
        }
    }
}
