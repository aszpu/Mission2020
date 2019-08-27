using System;
using System.Collections.Generic;
using System.Linq;

namespace Reloaded.Tasks.Task9
{
    class TaskClass9
    {
        public void Test()
        {
            var tab1 = new int[20];

            for (int i = 0; i < tab1.Length; i++)
            {
                tab1[i] = i;
            }

            List<int> list1 = new List<int>();

            for (int i = 0; i < tab1.Length; i++)
            {
                if (tab1[i] % 2 == 0) { }
                else
                {
                    list1.Add(tab1[i]);
                }
            }

            for (int i = 0; i < list1.Count; i++)
            {
                Console.WriteLine("Index: " + i + " | Wartość: " + list1[i]);
            }

            Console.WriteLine("----------------------------------------------------");

            int j = 0;
            while (j < list1.Count)
            {
                Console.WriteLine("Index: " + j + " | Wartość: " + list1[j]);
                j++;
            }

            Console.WriteLine("----------------------------------------------------");

            List<int> indexList = new List<int>();
            for (int i = 0; i < list1.Count; i++)
            {
                indexList.Add(i);
            }

            foreach (int i in indexList)
            {
                Console.WriteLine("Index: " + i + " | Wartość: " + list1[i]);
            }
        }

        public void TestAlt_przepisanie_do_listy()
        {
            var tab1 = new int[20];

            for (int i = 0; i < tab1.Length; i++)
            {
                tab1[i] = i;
            }

            List<int> list1 = new List<int>();

            //for (int i = 0; i < tab1.Length; i++)
            //{
            //    if (tab1[i] % 2 == 0) { }
            //    else
            //    {
            //        list1.Add(tab1[i]);
            //    }
            //}

            // powyżej oryginał
            // poniżej zmiana porównania modulo do 0, na porównanie do 1 - dzięki temu mamy warunek na nieparzystość i nie trzeba robić else

            for (int i = 0; i < tab1.Length; i++)
            {
                if (tab1[i] % 2 == 1)
                {
                    list1.Add(tab1[i]);
                }
            }

            // jeszcze można zmienić minimalny detal i nie pobierać dwa razy wartości z tablicy tylko pobrać raz i zachować w zmiennej lokalnej, o tak:

            for (int i = 0; i < tab1.Length; i++)
            {
                var element = tab1[i];

                if (element % 2 == 1)
                {
                    list1.Add(element);
                }
            }
        }

        public void TestAlt_Foreach()
        {
            var tab1 = Enumerable.Range(0, 20).ToArray(); // tak w skócie bo nie chce mi się forów pisać ;)
            var list1 = tab1.Where(e => e % 2 == 1).ToList(); // tak w skócie bo nie chce mi się forów pisać ;)



            // i w foreachu iterację masz generalnie dobrze tylko, że iterujesz po nowopowstałej liście indexów. Trochę tu przerost formy nad treścią.
            // bardziej widział bym to tak:

            var index = 0;
            foreach (int value in list1)
            {
                Console.WriteLine("Index: " + index + " | Wartość: " + value); // czyli tutaj korzystamy z wartości value z naszej oryginalnej listy w sposób bezpośredni
                index++; // a tutaj tylko powiększamy index
            }

            // przewaga tego rozwiązania polega na oszczędności ramu bo nie tworzymy listy indeksów tylko jedną zmienną na aktualny index, który w każdym kroku pętli inkrementujemy
        }
    }
}
