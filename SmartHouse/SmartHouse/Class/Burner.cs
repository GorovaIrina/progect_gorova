using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHouse
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
            if (State == true)
            {
                burnerregime = EnumeRegimeMinMax.Max;
            }
            else
            {
                throw new Exception("для выбора режимв необходимо включит комфорку");
            }

        }
        public void SetNorm()
        {
            if (State == true)
            {
                burnerregime = EnumeRegimeMinMax.Norm;
            }
            else
            {
                throw new Exception("для выбора режимa необходимо включить комфорку");
            }
        }
        public void SetMin()
        {
            if (State == true)
            {
                burnerregime = EnumeRegimeMinMax.Min;
            }
            else
            {
                throw new Exception("для выбора режимa необходимо включит комфорку");
            }
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
            return "прибор: " + Name + "в состонии: " + onOff +  "\nрежим комфорки " + burnerregime;
        }
    }
}
