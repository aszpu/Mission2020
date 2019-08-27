using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie2.Validation.Reporting
{
    public class Reporter
    {
        private Generator generator;
        private IPublisher[] publishers;

        public Reporter(Generator g, IPublisher[] p)
        {
            generator = g;
            publishers = p;
        }

        public void Report(List<PeselValidationResult> peselValidations)
        {
            Report rep = generator.Generate(peselValidations);
            for (int i = 0; i < publishers.Length; ++i)
                publishers[i].PublishReport(rep);
        }
    }
}
