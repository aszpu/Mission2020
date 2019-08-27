using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie2.Validation.Reporting
{
    public class Generator
    {
        public Report Generate(List<PeselValidationResult> peselValidationsResult)
        {
            string msg = null;
            int licznikNiepoprawne = 0;
            

            for (int i = 0; i < peselValidationsResult.Count; i++)
            {
                msg += peselValidationsResult[i].Pesel + " | " + peselValidationsResult[i].IsValid + " | " + peselValidationsResult[i].ErrorType + Environment.NewLine;
                if (peselValidationsResult[i].ErrorType != PeselErrorType.None) { licznikNiepoprawne++; };

            }

            double procentNiepoprawne = ((double)licznikNiepoprawne / (double)peselValidationsResult.Count) * 100;
            msg += Environment.NewLine + "Niepoprawnych numerów PESEL było: " + licznikNiepoprawne + " (" + procentNiepoprawne + " % wszystkich (" + peselValidationsResult.Count + ") wprowadzonych)";

            Report report = new Report();
            report.ReportMessage = msg;
            report.GenerateTime = DateTime.Now;
            return report;
        }
    }
}