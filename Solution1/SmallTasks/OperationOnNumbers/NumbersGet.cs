using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallTasks.OperationOnNumbers
{
    public class NumbersGet
    {
        public double[] GetNumbers (int numberOfElements)
        {
            double[] numbersTab = new double[numberOfElements];
            for (int i = 0; i < numberOfElements; ++i)
            {
                Console.WriteLine("Podaj liczbę (" + (i + 1) + "/" + numberOfElements + "): ");
                bool elementParsed = double.TryParse(Console.ReadLine(), out numbersTab[i]);
                if (!elementParsed)
                {
                    Console.WriteLine("Ponownie wprowadż wartość liczbową!");
                    --i;
                }
                Console.WriteLine();
            }
            return numbersTab;
        }
    }
}
