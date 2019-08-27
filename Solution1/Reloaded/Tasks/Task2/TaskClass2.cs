using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.Task2
{
    class TaskClass2
    {
        public void Test()
        {
            var numberOfElements = 1000;
            var j = -4;

            int[] taskTable = new int[numberOfElements]; 
            
            for (int i = 0; i < numberOfElements; i++)
            {
                taskTable[i] = j;
                j = j + 2;
            }
        }

        public void TestAlt1()
        {
            var tab = new int[1000]; // Zapis skrócony z var, ale na początek przygody możesz sobie dla wprawy deklarować typ, może nawet lepiej.

            var elementValue = -4;

            for (int i = 0; i < tab.Length; i++) // Alternatywnie w warunku trwania pętli można polegać bezpośrednio na rozmiarze tablicy. Jeszcze inną alternatywą może być const zadeklarowany w klasie.
            {
                tab[i] = elementValue;
                elementValue += 2; // skrótowy zapis powiększenia o liczbę: x = x + y; to jest to samo co x += y;
            }
        }

        private const int SomeConst = 123; // Przykład deklaracji jakiegoś consta.

        public void TestAlt2()
        {
            var tab = new int[1000];

            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] = -4 + i * 2; // alternatywny sposób bez dodatkowej zmiennej, a jedynie z wykorzystaniem i.
            }
        }
    }
}
