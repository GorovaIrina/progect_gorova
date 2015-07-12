using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartHouseWebApplication
{
    interface IRegimeMinMax
    {
        void SetNorm();
        void SetMin();
        void SetMax();
    }
}