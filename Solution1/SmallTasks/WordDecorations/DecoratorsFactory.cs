using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallTasks.WordDecorations
{
    public class DecoratorsFactory
    {
        public IDecorator[] CreateDecorators (DecorationType[] decorationTypes)
        {
            int decorationTypesLength = decorationTypes.Length;
            IDecorator[] tableDecorators = new IDecorator[decorationTypesLength];
            
            for (int i = 0; i < decorationTypesLength; i++)
            {
                switch (decorationTypes[i])
                {
                    case DecorationType.Frame:
                        tableDecorators[i] = new FrameDecorator('*');
                        break;
                    case DecorationType.Margin:
                        tableDecorators[i] = new FrameDecorator(' ');
                        break;
                    case DecorationType.Bracket:
                        tableDecorators[i] = new BracketDecorator();
                        break;
                    case DecorationType.Underline:
                        tableDecorators[i] = new UnderlineDecorator();
                        break;
                    default:
                        tableDecorators[i] = new NullDecorator();
                        break;
                }
            }
            return tableDecorators;
        }
    }
}
