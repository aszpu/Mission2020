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
            var f1 = new FunkcjaLiniowa(10, -12);
            var wartoscF1 = f1.ObliczWartosc(3);
            var miejsceZeroweF1 = new Double();
            try { miejsceZeroweF1 = f1.ObliczMiejsceZerowe(); } catch (Exception ex) { Console.WriteLine(ex.Message); }
            
            Console.ReadKey();
        }
    }
}
