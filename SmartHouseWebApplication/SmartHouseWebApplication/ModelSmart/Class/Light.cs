using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartHouseWebApplication
{
    class Light : Equipment, ISwitch
    {
        public Light(string name, bool state)
            : base(name, state)
        { }
        public Light() { }
        public override string ToString()
        {
            string onOff;
            if (State)
                onOff = "Включен";
            else
                onOff = "Выключен";
            return " прибор: " + Name + " в состонии: " + onOff;
        }
        public void SwitchOn()
        {
            State = true;
        }
        public void SwitchOff()
        {
            State = false;
        }
    }
}