using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHouse
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
            if (State == true)
            {
                vent = EnumeRegimeMinMax.Max;
            }
            else
            {
                throw new Exception("для выбора режима необходимо включить вытяжку");
            }

        }
        public void SetNorm()
        {
            if (State == true)
            {
                vent = EnumeRegimeMinMax.Norm;
            }
            else
            {
                throw new Exception("для выбора режима необходимо включить вытяжку");
            }
        }
        public void SetMin()
        {
            if (State == true)
            {
                vent = EnumeRegimeMinMax.Min;
            }
            else
            {
                throw new Exception("для выбора режима необходимо включить вытяжку");
            }
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
