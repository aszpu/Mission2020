using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Zadanie2.FileOperations
{
    public class FileReading
    {
        private string path;
        private int lineNo;
        private bool isLine;

        private string line;
        private int lineCount;

        public FileReading(string p, int l, bool iL)
        {
            if (string.IsNullOrWhiteSpace(p)) throw new ArgumentNullException(nameof(p));

            path = p;
            lineNo = l;
            isLine = iL;
        }

        public string LineReading()
        {
            lineCount = 0;
            StreamReader file = null;
            
            try
            {
                 file = new StreamReader(path);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            if (file == null)
                return "Nie ma takiego pliku.";

            var fileRead = "W pliku nie ma linii o takim numerze!";

            while ((line = file.ReadLine()) != null)
            {
                lineCount++;
                if (lineCount == lineNo)
                {
                    fileRead = line;
                    break;
                }
            }

            return fileRead;
        }
    }
}
