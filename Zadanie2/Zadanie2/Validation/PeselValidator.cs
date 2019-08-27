using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie2.Validation
{
    public class PeselValidator
    {
        private string pesel;

        public PeselValidator(string p)
        {
            pesel = p;
        }

        public PeselValidationResult SprawdzPesel()
        {
            // --------------------------------------- I. Usunięcie białych znaków z przodu i z tyłu. ---------------------------------------
            pesel = pesel.Trim();

            // --------------------------------------- II. Walidacja długości. ---------------------------------------
            if (pesel.Length != 11)
            {
                // --- albo przekazując wartości przez konstruktor:
                // return new PeselValidationResult(pesel, false, PeselErrorType.InvalidLength);
                // --- albo przypisując property:
                // var result = new PeselValidationResult();
                // result.Pesel = pesel;
                // result.IsValid = false;
                // result.ErrorType = PeselErrorType.InvalidLength;
                // return result;
                // -- albo skrótowo przypisując property:
                // return new PeselValidationResult() { Pesel = pesel, IsValid = false, ErrorType = PeselErrorType.InvalidLength }

                var result = new PeselValidationResult(pesel, false, PeselErrorType.InvalidLength);
                return result;
            }

            // --------------------------------------- III. Walidacja daty - parsowanie. ---------------------------------------
            string rokStr = pesel.Substring(0, 2);
            string miesiacStr = pesel.Substring(2, 2);
            string dzienStr = pesel.Substring(4, 2);

            int rok;
            int miesiac;
            int dzien;

            // Używam TryParse zamiast Parse bo TryParse zwraca true/false gdy się udało / nie udało sparsować. A Parse po prostu sypie się błędem gdy np. zamiast cyfry "8" podamy literę "f", albo jakiś inny znak nie będący cyfrą "<"
            bool rokParsed = int.TryParse(rokStr, out rok);
            bool miesiacParsed = int.TryParse(miesiacStr, out miesiac);
            bool dzienParsed = int.TryParse(dzienStr, out dzien);

            if (!rokParsed || !miesiacParsed || !dzienParsed)
            {
                return new PeselValidationResult(pesel, false, PeselErrorType.DateParseError);
            }

            // --------------------------------------- III. Walidacja daty - sprawdzenie wartości. ---------------------------------------

            bool dataJestOk = false;
            if (rok >= 0 && rok <= 99 && miesiac >= 1 && miesiac <= 12 && dzien >= 1 && dzien <= 31)
            {
                dataJestOk = true;
            }

            if (!dataJestOk)
            {
                return new PeselValidationResult(pesel, false, PeselErrorType.InvalidDate);
            }

            // --------------------------------------- IV. Walidacja cyfr - parsowanie. ---------------------------------------

            int a, b, c, d, e, f, g, h, i, j, k; // Zwykle deklaruję zmienne w osobnych linijkach ale jest tego tyle, że nie ma sensu śmiecić to dałem w jednej.

            // Tu już nie chce mi się przypisywać prawdiłowości parsowania do zmiennych boolowskich więc wkładam te wszystkie TryParse w ifa... czyli ten warunek brzmi - jak nie udało się sparsować pierwszej cyfry lub jak nie udało się sparsować drugiej lub jak nie udało się sparsować trzeciej ......
            if (!int.TryParse(pesel.Substring(0, 1), out a)
                || !int.TryParse(pesel.Substring(1, 1), out b)
                || !int.TryParse(pesel.Substring(2, 1), out c)
                || !int.TryParse(pesel.Substring(3, 1), out d)
                || !int.TryParse(pesel.Substring(4, 1), out e)
                || !int.TryParse(pesel.Substring(5, 1), out f)
                || !int.TryParse(pesel.Substring(6, 1), out g)
                || !int.TryParse(pesel.Substring(7, 1), out h)
                || !int.TryParse(pesel.Substring(8, 1), out i)
                || !int.TryParse(pesel.Substring(9, 1), out j)
                || !int.TryParse(pesel.Substring(10, 1), out k))
            {
                return new PeselValidationResult(pesel, false, PeselErrorType.DigitsParseError);
            }

            // --------------------------------------- V. Walidacja cyfr - sprawdzenie wartości. ---------------------------------------

            int suma_cyfr_wagowo = 1 * a + 3 * b + 7 * c + 9 * d + 1 * e + 3 * f + 7 * g + 9 * h + 1 * i + 3 * j + 1 * k;
            int suma_mod_10 = suma_cyfr_wagowo % 10;

            if (suma_mod_10 != 0)
            {
                return new PeselValidationResult(pesel, false, PeselErrorType.InvalidDigits);
            }

            // --------------------------------------- VI. Jak program nigdzie powyżej nie zwrócił informacji o błędzie i nie poszedł żaden return to doszliśmy do tego miejsca i informujemy, że PESEL jest OK. ---------------------------------------

            return new PeselValidationResult(pesel, true, PeselErrorType.None);
        }
    }
}
