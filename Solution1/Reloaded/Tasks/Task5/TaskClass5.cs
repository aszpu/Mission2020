using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.Task5
{
    class TaskClass5
    {
        public void Test()
        {
            var tab1 = new int[999];
            var tab2 = new int[999];

            for (int i = 0; i < tab1.Length; i++)
            {
                tab1[i] = i;
            }

            for (int i = 0; i < tab2.Length; i++)
            {
                tab2[i] = tab1[i] * 15;
            }
        }
    }
}
