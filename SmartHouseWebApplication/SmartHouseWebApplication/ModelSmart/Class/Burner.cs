using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartHouseWebApplication
{
    class Burner : Equipment, ISwitch, IRegimeMinMax
    {

        private EnumeRegimeMinMax burnerregime;

        public EnumeRegimeMinMax Burnerregime
        {
            get { return burnerregime; }
            set { burnerregime = value; }
        }
        public Burner() { }
        public Burner(string name, bool state, EnumeRegimeMinMax burnerregime)
            : base(name, state)
        {

            this.burnerregime = burnerregime;
        }
        public Burner(string name, bool state)
            : base(name, state)
        {
            this.State = false;
        }
        public void SetMax()
        {
              burnerregime = EnumeRegimeMinMax.Max;
           
        }
        public void SetNorm()
        {
            
                burnerregime = EnumeRegimeMinMax.Norm;
            
        }
        public void SetMin()
        {
            
                burnerregime = EnumeRegimeMinMax.Min;
          }
        public void SwitchOn()
        {
            State = true;
        }
        public void SwitchOff()
        {
            State = false;
        }
        public override string ToString()
        {
            string onOff;
            if (State)
                onOff = "Включен";
            else
                onOff = "Выключен";
            return "прибор: " + Name + "в состонии: " + onOff + "\nрежим комфорки " + burnerregime;
        }
    }
}