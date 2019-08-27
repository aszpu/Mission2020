using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.Task4
{
    class TaskClass4
    {
        public void Test()
        {
            int[] tab1 = new int[100];
            var tab2 = new int[100];

            for (int i = 0; i < tab1.Length; i++)
            {
                tab1[i] = 55 + i;
            }

            for (int i = 0; i < tab2.Length; i++)
            {
                tab2[i] = tab1[i];
            }
        }

    }
}
