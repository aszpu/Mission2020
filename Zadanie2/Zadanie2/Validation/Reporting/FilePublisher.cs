using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Zadanie2.Validation.Reporting
{
    public class FilePublisher : IPublisher
    {
        private string path;
        
        public void PublishReport(Report report)
        {
            string reportMessage = report.ReportMessage;
            string generateTimeString = report.GenerateTime.ToString();
            string trimGenerateTimeString = generateTimeString.Replace(":", "");
            trimGenerateTimeString = trimGenerateTimeString.Replace(" ", "_");
            trimGenerateTimeString = trimGenerateTimeString.Replace("-", "");
            path = "D:\\Reports\\report_" + trimGenerateTimeString + ".txt";

            string reportMessageAndDate = "Poniższy raport wygenerowano w dniu: " + generateTimeString + Environment.NewLine + reportMessage;

            StreamWriter file = new StreamWriter(path);
            file.Write(reportMessageAndDate);
            file.Flush();
            file.Close();
        }
    }
}
