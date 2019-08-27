using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallTasks.WordDecorations
{
    public class DecorationStyleGet
    {
        public DecorationType[] GetStyles()
        {
            Console.WriteLine("Wybierz kolejność dekoracji do zastosowania: [r]amka, [m]argines, [p]odkreślenie, [n]awiasy, [b]rak");

            var userStylesSequence = Console.ReadLine();
            int userStylesSequenceLength = userStylesSequence.Length;

            DecorationType[] tableStylesSequence = new DecorationType[userStylesSequenceLength];

            for (int i = 0; i < userStylesSequenceLength; i++)
            {
                switch (userStylesSequence.ElementAt(i))
                {
                    case 'r':
                        tableStylesSequence[i] = DecorationType.Frame;
                        break;
                    case 'm':
                        tableStylesSequence[i] = DecorationType.Margin;
                        break;
                    case 'p':
                        tableStylesSequence[i] = DecorationType.Underline;
                        break;
                    case 'n':
                        tableStylesSequence[i] = DecorationType.Bracket;
                        break;
                    default:
                        tableStylesSequence[i] = DecorationType.Null;
                        break;
                }                
            }

            return tableStylesSequence;
        }
    }
}
