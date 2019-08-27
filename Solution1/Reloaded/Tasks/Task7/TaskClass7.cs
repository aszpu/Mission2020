using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.Task7
{
    class TaskClass7
    {
        public void Test()
        {
            var tab1 = new int[20];
            var tab2 = new int[20];

            for (int i = 0; i < tab1.Length; i++)
            {
                tab1[i] = 10 + (i * 2);
            }

            for (int i = 0; i < tab2.Length; i++)
            {
                tab2[i] = tab1[tab1.Length - 1 - i];
            }
        }
    }
}
