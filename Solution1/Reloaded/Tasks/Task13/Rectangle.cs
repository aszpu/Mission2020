using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.Task13
{
    // uwagi:
    // - bardziej bym to nazwał Width i Height niż Width i Length
    // - w metodzie można zrobić bezpośrednio return Width * Height. Przypisanie wyniku do pola _area nic w tym konkretnym przypadku nie daje

    public class Rectangle
    {
        //private double _area;

        public double Width { get; set; }
        public double Height { get; set; }


        public double Area()
        {
            return Width * Height;
        
        }
    }


    // To nie jest alternatywne rozwiązanie zadania.
    // To jest tylko pokazanie, że mogli byśmy nie mieć metody Area tylko property Area wyłącznie z getterem, który w środku robi to samo co robi metoda.
    // Bo czym jest property? Niczym innym jak tak zwanym syntactic sugar - property to jest taki uproszczony zapis jednej lub dwóch metod.
    // Jak napiszesz takie coś:
    // public double Height { get; set; }
    // To kompilacja zamienia to na takie pole (tutaj kod będzie już w intermediate language czyli po zbuildowaniu):
    // .field private float64 '<Height>k__BackingField'
    // oraz na takie dwie metody:
    // .method public hidebysig specialname instance float64 get_Height() cil managed
    // oraz:
    // .method public hidebysig specialname instance void set_Height ( float64 'value'  ) cil managed
    // czyli backing filed typu double i dwie metody get_Height() i set_Height(float64 'value')
    // Ale nic nie stoi na przeszkodzie żeby getter i setter zrobić nie automatyczny, albo dać tylko jeden z nich.
    // Poniższy przykład pokazuje takie właśnie property ze zdefiniowanym nieautomatycznym getterem i bez settera.

    public class RectangleWithAreaProperty
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public double Area
        {
            get
            {
                return Width * Height;
            }
        }
    }

    // A ten przykład to jest dokładnie to samo co wyżej tylko zapisane krócej (kolejny syntactic sugar żeby życie było łatwiejsze)

    public class RectangleWithAreaPropertyShorter
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public double Area => Width * Height;
    }
}