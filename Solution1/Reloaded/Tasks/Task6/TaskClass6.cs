using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.Task6
{
    class TaskClass6
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
                if (tab1[i]%2 == 0) // "zero" traktuję jako parzystą ;D
                {
                    tab2[i] = tab1[i] * 3;
                }
                else
                {
                    tab2[i] = -tab1[i];
                }
            }
        }
    }
}
