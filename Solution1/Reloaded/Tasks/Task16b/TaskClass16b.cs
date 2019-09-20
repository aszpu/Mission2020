using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.Task16b
{
    public class TaskClass16b
    {
        public void Test()
        {
            var rozdzielczoscList = new List<Rozdzielczosc>
            {
                new Rozdzielczosc (1280, 720),
                new Rozdzielczosc (1440, 720),
                new Rozdzielczosc (1920, 1080)
            };

            var ekranList = new List<Ekran>
            {
                new Ekran (12, false, rozdzielczoscList[0]),
                new Ekran (15.4, true, rozdzielczoscList[1]),
                new Ekran (17, false, rozdzielczoscList[2])
            };

            var ramList = new List<Ram>
            {
                new Ram (TypRamu.DDR2, 2048),
                new Ram (TypRamu.DDR3, 4096),
                new Ram (TypRamu.DDR4, 8192)
            };

            var procesorList = new List<Procesor>
            {
                new Procesor ("AMD Ryzen 5", 4200, 6),
                new Procesor ("Intel Core i5", 4600, 6),
                new Procesor ("Intel Core i7", 4900, 8)
            };

            var laptopList = new List<Laptop>
            {
                new Laptop ("HP", "Pavilion", procesorList[2], ramList[2], ekranList[2]),
                new Laptop ("Asus", "VivoBook", procesorList[1], ramList[1], ekranList[1]),
                new Laptop ("Acer", "Aspire", procesorList[0], ramList[0], ekranList[0])
            };

            Console.ReadKey();
        }
    }
}
