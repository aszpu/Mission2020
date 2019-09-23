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

        public RichText()
        {

        }

        public RichText(string text)
        {
            Text = text;

            _letterCaseChanger = new LetterCaseChanger();
        }

        public string Text { get; set; }
        public string LetterSeparator { get; set; }
        public LetterCaseType LetterCase { get; set; }
        public bool Underline { get; set; }
        public bool ReverseOrder { get; set; }
        public ConsoleColor Color { get; set; }

        public void Show()
        {
            Text = _letterCaseChanger.LetterCaseChange(Text, LetterCase);

            if (ReverseOrder)
            {
                var textReversedOrder = new TextOrderReverser();
                Text = textReversedOrder.TextOrderReverse(Text);
            }

            var textSeparated = new TextSeparator();
            Text = textSeparated.Separate(Text, LetterSeparator);

            Console.ForegroundColor = Color;
            Console.WriteLine(Text);

            if (Underline)
            {
                for (int i = 0; i < Text.Length; i++)
                {
                    Console.Write("-");
                }
            }

            Console.ReadKey();
        }
    }
}
