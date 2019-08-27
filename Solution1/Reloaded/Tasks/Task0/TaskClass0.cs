using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.Task0
{
    public class TaskClass0
    {
        public void Test()
        {
            var numberOfElements = 10;
            int[] taskTable = new int[numberOfElements];

            for (int i = 0; i < numberOfElements; i++)
            {
                taskTable[i] = i;
            }
        }

    }
}
