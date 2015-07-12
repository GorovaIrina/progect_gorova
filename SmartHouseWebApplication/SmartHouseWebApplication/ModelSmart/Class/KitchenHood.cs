using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartHouseWebApplication
{
    class KitchenHood : Equipment, ISwitch, IRegimeMinMax
    {
        public void SwitchOn()
        {
            State = true;
        }
        public void SwitchOff()
        {
            State = false;
        }
        private EnumeRegimeMinMax vent;
        public EnumeRegimeMinMax Vent
        {
            get { return vent; }
            set { vent = value; }
        }
        public KitchenHood() { }
        public KitchenHood(string name, bool state, EnumeRegimeMinMax vent)
            : base(name, state)
        {
            this.vent = vent;
        }
        public void SetMax()
        {
            vent = EnumeRegimeMinMax.Max;
        }
        public void SetNorm()
        {           
                vent = EnumeRegimeMinMax.Norm;
                    
        }
        public void SetMin()
        {
             vent = EnumeRegimeMinMax.Min;
       }
        public override string ToString()
        {
            string onOff;
            if (State)
                onOff = "Включен";
            else
                onOff = "Выключен";
            return "\n прибор: " + Name + " в состоянии: " + onOff + " \n режим работы вытяжки: " + vent + "\n";
        }
    }
}