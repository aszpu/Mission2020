using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallTasks.OperationOnNumbers
{
    public class Mathematics
    {
        public double GetSum(double[] elementsTable)
        {
            double sum = 0;
            for (int i = 0; i < elementsTable.Length; ++i)
            {
                sum += elementsTable[i];
            }

            return sum;
        }

        public double GetAverage(double[] elementsTable)
        {
            return GetSum(elementsTable)/elementsTable.Length;

        }

        public double[] GetInverted(double[] elementsTable)
        {
            double[] invertedNumbers = new double[elementsTable.Length];
            for (int i = 0; i < elementsTable.Length; ++i)
            {
                invertedNumbers[i] = 1 / elementsTable[i];
            }

            return invertedNumbers;
        }

        public double GetInverted(double element)
        {
            return (1 / element);
        }

        public double[] GetOpposite(double[] elementsTable)
        {
            double[] oppositeNumbers = new double[elementsTable.Length];
            for (int i = 0; i < elementsTable.Length; ++i)
            {
                oppositeNumbers[i] = -elementsTable[i];
            }

            return oppositeNumbers;
        }

        public double GetOpposite(double element)
        {
            return -element;
        }
    }
}
