using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.Task1
{
    class TaskClass1
    {
        public void Test()
        {
            var numberOfElements = 100;
            int[] taskTable = new int[numberOfElements];

            for (int i = 0; i < numberOfElements; i++)
            {
                taskTable[i] = 800+i;
            }
        }

    }
}
