using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartHouseWebApplication
{
    interface IRegulator
    {
        void NextPoint();
        void PrevPoint();
    }
}