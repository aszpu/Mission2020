using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zadanie2.Validation;
using Zadanie2.FileOperations;
using Zadanie2.Validation.Reporting;
using Zadanie2.Sciaga;

namespace Zadanie2
{

    class Program
    {
        static void Main(string[] args)
        {
            var shapePlayground = new TotalAreaCalculator();

            SquareShape square = new SquareShape(10);
            var circle = new CircleShape(1);

            Console.WriteLine("Square x = " + square.X + " / area = " + square.Area);
            Console.WriteLine("Circle radius = " + circle.Radius + " / area = " + circle.Area);
            Console.WriteLine("Total Area = " + shapePlayground.CalculateTotalArea(new IShape[] { square, circle }));

            shapePlayground.RescaleAllShapes(new IShape[] { square, circle }, 2.5);

            Console.WriteLine("Square x = " + square.X + " / area = " + square.Area);
            Console.WriteLine("Circle radius = " + circle.Radius + " / area = " + circle.Area);
            Console.WriteLine("Total Area = " + shapePlayground.CalculateTotalArea(new IShape[] { square, circle }));

            // ------------------------------------

            bool done = false;
            do
            {
                Console.Clear();
                Console.WriteLine("MENU (wybierz nr zadania)");
                Console.WriteLine();
                Console.WriteLine("(1) Weryfikacja numerów PESEL");
                Console.WriteLine("(2) Wczytywanie określonej linijki pliku TXT");
                Console.WriteLine();
                Console.WriteLine("(0) Wyjście z programu");
                Console.WriteLine();
                var choiceKey = Console.ReadKey();
                int choice;
                bool choiseParsed = int.TryParse(choiceKey.KeyChar.ToString(), out choice);

                if (choiseParsed)
                {
                    if (choice == 1)// Weryfikacja numerów PESEL
                    {
                        done = true;
                        PeselValidationChoice();
                    }

                    else if (choice == 2)// Wczytywanie określonej linijki pliku TXT
                    {
                        done = true;
                        FileReadingChoice();
                    }

                    else if (choice == 0)// Zakończenie programu
                    {
                        done = true;
                    }

                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Niepoprawny wybór! Naciśnij ENTER i spróbuj ponownie.");
                        Console.ReadKey();
                    }

                }
            }
            while (!done);

        }

        private static void PeselValidationChoice()
        {
            int licznik = 0;
            string p;

            //tworzenie listy numerów PESEL
            List<string> pesels = new List<string>();

            do
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Proszę, podaj " + (licznik + 1) + " numer PESEL lub STOP aby zakończyć:");
                p = Console.ReadLine();
                if (String.Compare(p, "stop", true) != 0)
                {
                    pesels.Add(p);
                }
                licznik++;
            }
            while (String.Compare(p, "stop", true) != 0);

            //tworzenie listy wyników "walidacji"
            List<PeselValidationResult> peselValidations = new List<PeselValidationResult>();

            for (int i = 0; i < pesels.Count; i++)
            {

                PeselValidator validator = new PeselValidator(pesels[i]);
                PeselValidationResult peselValidation = validator.SprawdzPesel();

                peselValidations.Add(peselValidation);
            }

            //agregacja danych z listy z rezultatami walidacji... zliczanie błędnych i wyświetlanie błędnych oraz zawartości listy
            bool choiceReportParsed;
            int choiceReport;

            do
            {
                Console.Clear();
                Console.WriteLine("Wybierz typ raportu: (1) na konsolę, (2) do pliku TXT");
                Console.WriteLine();
                var choiceReportKey = Console.ReadKey();

                choiceReportParsed = int.TryParse(choiceReportKey.KeyChar.ToString(), out choiceReport);
            }
            while (!choiceReportParsed);

            IPublisher publisher = null;
            switch (choiceReport)
            {
                case 1:
                    publisher = new ConsolePublisher();
                    break;

                case 2:
                    publisher = new FilePublisher();
                    break;

                default:
                    publisher = new PublisherKtoryNicNieRobieZebySieNieWysypalo();
                    break;
            }

            Generator generator = new Generator();
            Reporter validationsReporter = new Reporter(generator, new IPublisher[] { publisher });
            validationsReporter.Report(peselValidations);

            Console.ReadKey();
        }

        private static void FileReadingChoice()
        {
            string path;
            int line;

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Podaj ścieżkę dostępu do pliku:");
            path = Console.ReadLine();

            bool lineParsed = false;
            do
            {
                Console.WriteLine("Określ nr linii w pliku do odczytania:");
                lineParsed = int.TryParse(Console.ReadLine(), out line);
            }
            while (!lineParsed);

            FileReading reading = new FileReading(path, line, true);
            String fileread = reading.LineReading();

            Console.WriteLine(fileread);

            Console.ReadKey();
        }
        
        // I może jeszcze małe zadanko dodatkowe na potem, ale to już po sekcji II - programowanie obiektowe
        // Napisz sobie interfejs IPeselValidationResultFormatter z jedną metodą:
        // string Format(PeselValidationResult result);
        // Nazwy interfejsów zaczynamy od dużej litery i.
        // Metody interfejsów nie specyfikują public/protected/private... zawsze są public.
        // Do tego napisz sobie jedną implementację tego interfejsu: ConsolePeselValidationResultFormatter, która w konstruktorze przyjmuje CultureInfo określające język (narazie możemy obsłużyć tylko polski ;), a w innych przypadkach rzucić błędem "Language no supported), a w metodze Format loguje na konsolę,
        // informacje o rezultacie walidacji w określonym języku.
        // Ale to mówię - nie na teraz.
    }
}
