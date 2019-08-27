using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallTasks.WordDecorations
{
    public class DecorationRunner
    {
        public void Run()
        {
            TextGet getText = new TextGet();
            string[] text = getText.GetText();
            
            DecorationStyleGet getStyles = new DecorationStyleGet();
            var decorationStyleSequence = getStyles.GetStyles();

            var factoryDecorator = new DecoratorsFactory();
            var decoratorsOrder = factoryDecorator.CreateDecorators(decorationStyleSequence);

            int decoratorsOrderLength = decoratorsOrder.Length;

            List<string> temporaryDecorationEffect = new List<string>();

            for (int i = 0; i < text.Length; i++)
            {
                temporaryDecorationEffect.Add(text[i]);
            }

            for (int i = 0; i < decoratorsOrderLength; i++)
            {
                temporaryDecorationEffect = decoratorsOrder[i].Decorate(temporaryDecorationEffect);
            }

            for (int i = 0; i < temporaryDecorationEffect.Count; i++)
            {
                Console.WriteLine(temporaryDecorationEffect[i]);
            }            
            Console.ReadKey();
        }
    }
}
