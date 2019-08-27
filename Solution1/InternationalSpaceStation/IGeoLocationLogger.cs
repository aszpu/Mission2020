using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternationalSpaceStation
{
    public interface IGeoLocationLogger
    {
        void CleanUp();
        void LogLocation(Coordinates coordinates);
    }
}