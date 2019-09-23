using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.Task16d
{
    public class TextSeparator
    {
        public string Separate(string text, string letterSeparator)
        {
            string textAfterSeparation = text[0].ToString();
            for (int i = 1; i < text.Length; i++)
            {
                textAfterSeparation = textAfterSeparation + letterSeparator + text[i];
            }
            return textAfterSeparation;
        }
    }
}
