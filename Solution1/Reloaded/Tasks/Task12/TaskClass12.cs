using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.Task12
{
    class TaskClass12
    {
        public void Test()
        {
            var BadWords = new string[] { "nosz kurła", "kurczę mać", "jasny gwint", "do piernika", "do licha"};

            Console.WriteLine("");
            Console.WriteLine("Task 12");
            Console.WriteLine("Podaj słowo!");
            var wordToCheck = Console.ReadLine();

            var isBadWord = false;
            for(int i = 0; i < BadWords.Length; i++)
            {
                if (wordToCheck.ToLower().Equals(BadWords[i].ToLower()))
                {
                    isBadWord = true;
                }
            }

            if(!isBadWord && !wordToCheck.ToLower().Equals("komunizm"))
            {
                Console.WriteLine(wordToCheck.ToLower());
                Console.ReadKey();
            }

        }

        // Uwagi:
        // - jak tablica tabBadWords ma wszystko w małych literach to ten fragment:
        //   tabBadWords[i].ToLower() nie jest potrzebny, tzn. nie jest potzrebne ToLower.
        //   Aczkolwiek patrząc na realny kejs gdyby tę tablicę wypełniał jakiś użtykownik administrujący,
        //   który mógłby się machnąć jeżeli chodzi o wielkość liter to w takim przypadku Twój kod miałby dużo sensu. Wszystko zależy od sytuacji.
        // - ja bym zmienną tabBadWords nazwał po prostu badWords bo sam faktu użycia liczby mnogiej w nazwie zmiennej sugeruje, że jest to tablica, lista bądź jakakolwiek inna kolekcja.
        //   jak kiedyś zechcesz jednak zamiast tablicy dać listę to Twoja nazwa zmiennej będzie do zmiany czyli masz dodatkowy koszt, a jak będzie to nazwa uniwersalna badWords to nie będzie tych kosztów.
        // - zamiast
        //   isBadWord == false
        //   można napisać
        //   !isBadWord
        // - użyłeś operatora &, zamiast niego powienieś użyć operatora &&
        //   https://docs.microsoft.com/en-US/dotnet/csharp/language-reference/operators/boolean-logical-operators - tutaj jest wyjaśnienie czyli:
        //   a == b & c == d ewaluuje oba porównania a następnie zwraca wynik AND na obu tych boolach
        //   a == b && c == d ewaluuje drugie porównanie tylko wtedy gdy pierwsze zwróciło true, no bo jeżeli zwróciło false to nie ma sensu sprawdzać kolejnego operandu skoro i tak wiadomo, że wynik będzie false, skolei przy operatorze || drugi operand będzie sprawdzany tylko gdy pierwszy jest true

    }
}
