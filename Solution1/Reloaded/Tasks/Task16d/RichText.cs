using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.Task16d
{
    public class RichText
    {
        private readonly LetterCaseChanger _letterCaseChanger;
        private readonly TextOrderReverser _textOrderReverser;
        private readonly TextSeparator _textSeparator;

        public RichText()
        {

        }

        public RichText(string text)
        {
            Text = text;

            _letterCaseChanger = new LetterCaseChanger();
            _textOrderReverser = new TextOrderReverser();
            _textSeparator = new TextSeparator();
        }

        public string Text { get; set; }
        public string LetterSeparator { get; set; }
        public LetterCaseType LetterCase { get; set; }
        public bool Underline { get; set; }
        public bool ReverseOrder { get; set; }
        public ConsoleColor Color { get; set; }

        public void Show()
        {
            var t = Text;

            t = _letterCaseChanger.LetterCaseChange(t, LetterCase);

            if (ReverseOrder)
            {
                
                t = _textOrderReverser.TextOrderReverse(t);
            }

            t = _textSeparator.Separate(t, LetterSeparator);

            Console.ForegroundColor = Color;
            Console.WriteLine(t);

            if (Underline)
            {
                for (int i = 0; i < t.Length; i++)
                {
                    Console.Write("-");
                }
            }

            Console.ReadKey();
        }
    }
}
