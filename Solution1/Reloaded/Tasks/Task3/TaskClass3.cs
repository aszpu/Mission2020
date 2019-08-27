using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.Task3
{
    class TaskClass3
    {
        public void Test()
        {
            int[] tab = new int[10000];

            for (int i=0; i < tab.Length; i++)
            {
                tab[i] = 50 + i * 10;
            }
        }
    }
}
