using SmallTasks.OperationOnNumbers;
using SmallTasks.TaxOperations;
using SmallTasks.WordDecorations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            //var taxRunner = new TaxRunner();
            //taxRunner.Run();
            //var decorationRunner = new DecorationRunner();
            //decorationRunner.Run();
            var operationsOnNumbersRunner = new OperationsRunner();
            operationsOnNumbersRunner.Run(); 
        }
    }
}
