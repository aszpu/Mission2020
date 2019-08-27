using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallTasks.OperationOnNumbers
{
    public class TableConsoleWriter
    {
        public void ConsoleWrite(double[] elementsTable)
        {
            string elementsTableString = "";
            for (int i = 0; i < elementsTable.Length; i++)
            {
                elementsTableString += "[" + elementsTable[i] + "]";
                if (i != elementsTable.Length) { elementsTableString += " "; };
            }
            Console.WriteLine(elementsTableString);
        }
    }
}        