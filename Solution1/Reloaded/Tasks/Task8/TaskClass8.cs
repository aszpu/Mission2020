using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.Task8
{
    class TaskClass8
    {
        public void Test()
        {
            var tab1 = new int[20];

            for (int i = 0; i < tab1.Length; i++)
            {
                tab1[i] = 10 + (i * 2);
            }

            List<int> list1 = new List<int>();

            for (int i = 0; i < tab1.Length; i++)
            {
                list1.Add(tab1[i]);
            }
        }
    }
}
