using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.Task16d
{
    public class TextOrderReverser
    {
        public string TextOrderReverse(string text)
        {
            //var textAfterOrderReversing = text[text.Length - 1].ToString();
            string textAfterOrderReversing = "";
            for (int i = text.Length - 1; i > -1; i--)
            {
                textAfterOrderReversing = textAfterOrderReversing + text[i];
            }
            return textAfterOrderReversing;
        }
    }
}
