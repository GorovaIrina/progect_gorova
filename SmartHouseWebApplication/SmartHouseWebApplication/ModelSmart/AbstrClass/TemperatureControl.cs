using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartHouseWebApplication
{
    abstract class TemperatureControl : Equipment, ISwitch, IMode, ISettingTemperature, IRegulator
    {
        private int temperature;

        public int Temperature
        {
            get { return temperature; }
            set
            {
                // if (temperature <= MaxTemperature && temperature >= MinTemperatire)
                temperature = value;
            }
        }
        public int MinTemperatire { get; set; }
        public int MaxTemperature { get; set; }
        public void SwitchOn()
        {
            State = true;
        }
        public void SwitchOff()
        {
            State = false;
        }
        private EnumClimatRegime climatRegime;

        internal EnumClimatRegime ClimatRegime
        {
            get { return climatRegime; }
            set { climatRegime = value; }
        }
        public TemperatureControl(string name, bool state, int temperature, EnumClimatRegime climatRegime,
            int minTemperatire, int maxTemperature)
            : base(name, state)
        {
            this.MaxTemperature = maxTemperature;
            this.MinTemperatire = minTemperatire;
            this.climatRegime = climatRegime;
            this.temperature = temperature;
        }
        public TemperatureControl() { }
        public void SummerMode()
        {
            climatRegime = EnumClimatRegime.summer;
        }
        public void WinterMode()
        {
            climatRegime = EnumClimatRegime.winter;

        }
        public void NextPoint()
        {
            if (temperature < MaxTemperature)
            {
                temperature++;
            }
        }
        public void PrevPoint()
        {
            if (temperature > MinTemperatire)
            {
                temperature--;
            }
        }
    }
}