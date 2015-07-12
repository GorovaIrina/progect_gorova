using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHouse
{
    class Heating : TemperatureControl
    {
        public Heating(string name, bool state, int temperature, EnumClimatRegime climatRegime, int minTemperatire, int maxTemperature)
            : base(name, state, temperature, climatRegime, minTemperatire, maxTemperature)
        { }
        public Heating() { }
        public override string ToString()
        {
            string onOff;
            if (State)
                onOff = "Включен";
            else
                onOff = "Выключен";
            return "\n прибор: " + Name + " в состонии: " + onOff + " \n установленная температура: " + Temperature
            + "\n режим эксплуатации(зима/лето): " + ClimatRegime + " \n минимальная температура: " + MinTemperatire +
            " \n максимальная темпертура: " + MaxTemperature + "\n";
        }
    }
}
