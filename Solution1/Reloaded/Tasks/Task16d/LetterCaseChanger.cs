using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.Task16d
{
    public class LetterCaseChanger
    {
        public string LetterCaseChange(string text, LetterCaseType letterCaseType)
        {
            switch (letterCaseType)
            {
                case LetterCaseType.Upper:
                    text = text.ToUpper();
                    break;

                case LetterCaseType.Lower:
                    text = text.ToLower();
                    break;
            }

            return text;
        }
    }
}
