using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartHouseWebApplication
{
    class Oven : Equipment, ISwitch, ISettingTemperature, IRegulator
    {
        private int temperature;
        public Oven() { }

        public int Temperature
        {
            get { return temperature; }
            set
            {
                if (value > 0 && value <= 250)
                    temperature = value;
            }
        }
        private EnumRegimeOven ovenregime;

        internal EnumRegimeOven Ovenregime
        {
            get { return ovenregime; }
            set { ovenregime = value; }
        }

        public Oven(string name, bool state, EnumRegimeOven ovenregime, int temperature)
            : base(name, state)
        {
            this.temperature = temperature;
            this.ovenregime = ovenregime;
        }
        public void SetRegimNul()
        {
            ovenregime = EnumRegimeOven.regimNul;
        }
        public void SetClassic_heating()
        {
            ovenregime = EnumRegimeOven.classic_heating;
        }
        public void SetVentilating_heating()
        {
            ovenregime = EnumRegimeOven.ventilating_heating;
        }
        public void SetBottom_heat_fan_operation()
        {
            ovenregime = EnumRegimeOven.Bottom_heat_fan_operation;
        }
        public void SetGrill()
        {
            ovenregime = EnumRegimeOven.grill;
        }
        public void SetTurbo_grill()
        {
            ovenregime = EnumRegimeOven.turbo_grill;
        }
        public void SetSmart_chef()
        {
            ovenregime = EnumRegimeOven.smart_chef;
        }
        public void SetPizza()
        {
            ovenregime = EnumRegimeOven.pizza;
        }
        public void SwitchOn()
        {
            State = true;
        }
        public void SwitchOff()
        {
            State = false;
        }
        public void NextPoint()
        {
            if (temperature <= 248)
            {
                temperature += 2;
            }
        }
        public void PrevPoint()
        {
            if (temperature >= 2)
            {
                temperature -= 2;
            }
        }
        public override string ToString()
        {
            string onOff;
            if (State)
                onOff = "Включен";
            else
                onOff = "Выключен";
            return "\n прибор: " + Name + "в состонии: " + onOff + "\n режим приготовления: " + ovenregime +
                "\n температура: " + temperature + "\n";
        }
    }
}