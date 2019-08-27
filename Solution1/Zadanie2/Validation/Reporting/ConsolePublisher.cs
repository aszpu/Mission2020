using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie2.Validation.Reporting
{
    public class ConsolePublisher : IPublisher
    {
        public void PublishReport(Report report)
        {
            string reportMessage = report.ReportMessage;
            string generateTimeString = report.GenerateTime.ToString();
            Console.Clear();
            Console.WriteLine("Poniższy raport wygenerowano w dniu: " + generateTimeString + Environment.NewLine);
            Console.WriteLine(reportMessage);
        }
    }
}