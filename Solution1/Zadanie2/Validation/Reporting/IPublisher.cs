using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie2.Validation.Reporting
{
    public interface IPublisher
    {
        void PublishReport(Report report);
    }
}
