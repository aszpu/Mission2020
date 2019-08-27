using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallTasks.OperationOnNumbers
{
    public class OperationsRunner
    {
        public void Run()
        {
            Console.WriteLine("Podaj ile liczb?");
            bool numbersOfElementsParsed = int.TryParse(Console.ReadLine(), out int numbersOfElements);
            var getNumbers = new NumbersGet();
            var numbersTable = getNumbers.GetNumbers(numbersOfElements);

            Console.WriteLine("Podane liczby:");
            var writeNumbers = new TableConsoleWriter();
            writeNumbers.ConsoleWrite(numbersTable);

            double data;

            var mathematics = new Mathematics();

            data = mathematics.GetSum(numbersTable);
            Console.WriteLine(data);

            data = mathematics.GetAverage(numbersTable);
            Console.WriteLine(data);

            double[] oppDataTable = mathematics.GetOpposite(numbersTable);
            writeNumbers.ConsoleWrite(oppDataTable);

            double[] invDataTable = mathematics.GetInverted(numbersTable);
            writeNumbers.ConsoleWrite(invDataTable);

            data = mathematics.GetSum(oppDataTable);
            Console.WriteLine(data);

            var invSum = mathematics.GetSum(invDataTable);
            Console.WriteLine(invSum);

            var oppAvg = mathematics.GetAverage(oppDataTable);
            Console.WriteLine(oppAvg);

            data = mathematics.GetAverage(invDataTable);
            Console.WriteLine(data);

            data = mathematics.GetOpposite(invSum);
            Console.WriteLine(data);

            data = mathematics.GetInverted(oppAvg);
            Console.WriteLine(data);

            Console.ReadKey();
        }
    }
}
