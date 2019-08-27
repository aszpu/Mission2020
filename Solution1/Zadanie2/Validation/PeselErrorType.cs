using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie2.Validation
{
    public enum PeselErrorType
    {
        None = 0,
        InvalidLength = 1,
        DateParseError = 2,
        InvalidDate = 3,
        DigitsParseError = 4,
        InvalidDigits = 5
    }
}
