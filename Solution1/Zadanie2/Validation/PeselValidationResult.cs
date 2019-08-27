using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie2.Validation
{

    public class PeselValidationResult
    {

        public string Pesel { get; set; }
        public bool IsValid { get; set; }
        public PeselErrorType ErrorType { get; set; }

        public PeselValidationResult(string p, bool iS, PeselErrorType eT)
        {
            Pesel = p;
            IsValid = iS;
            ErrorType = eT;
        }
    }


}
