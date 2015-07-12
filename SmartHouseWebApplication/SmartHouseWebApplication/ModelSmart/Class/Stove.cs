using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartHouseWebApplication
{
    class Stove : Equipment, ISwitch
    {
        private Burner topLeftBurner;

        public Burner TopLeftBurner
        {
            get { return topLeftBurner; }
            set { topLeftBurner = value; }
        }
        private Burner topRightBurner;

        public Burner TopRightBurner
        {
            get { return topRightBurner; }
            set { topRightBurner = value; }
        }
        private Burner buttomLeftBurner;

        public Burner ButtomLeftBurner
        {
            get { return buttomLeftBurner; }
            set { buttomLeftBurner = value; }
        }
        private Burner buttomRightBurner;

        public Burner ButtomRightBurner
        {
            get { return buttomRightBurner; }
            set { buttomRightBurner = value; }
        }
        private Oven oven;

        public Oven Oven
        {
            get { return oven; }
            set { oven = value; }
        }
        public Stove(string name, bool state, Burner topLeftBurner, Burner topRightBurner, Burner buttomLeftBurner,
            Burner buttomRightBurner, Oven oven)
            : base
                (name, state)
        {
            this.topLeftBurner = topLeftBurner;
            this.topRightBurner = topRightBurner;
            this.buttomLeftBurner = buttomLeftBurner;
            this.buttomRightBurner = buttomRightBurner;
            this.oven = oven;
        }

        public Stove() { }
        public void SwitchOn()
        {
            State = true;
        }
        public void SwitchOff()
        {
            State = false;
        }
        public void SwitchOnTopLeftBurner()
        {
            TopLeftBurner.SwitchOn();
        }

        public void SwitchOffTopLeftBurner()
        {
            TopLeftBurner.SwitchOff();
        }

        public void SwitchOnTopRightBurner()
        {
            TopRightBurner.SwitchOn();
        }

        public void SwitchOffTopRightBurner()
        {
            TopRightBurner.SwitchOff();
        }

        public void SwitchOnButtomLeftBurner()
        {
            buttomLeftBurner.SwitchOn();
        }

        public void SwitchOffButtomLeftBurner()
        {
            buttomLeftBurner.SwitchOff();
        }

        public void SwitchOnButtomRightBurner()
        {
            buttomRightBurner.SwitchOn();
        }

        public void SwitchOffButtomRightBurner()
        {
            buttomRightBurner.SwitchOff();
        }
        public void MinRegTopLeftBurner()
        {
            topLeftBurner.SetMin();
        }
        public void NormRegTopLeftBurner()
        {
            topLeftBurner.SetNorm();
        }
        public void MaxRegTopLeftBurner()
        {
            topLeftBurner.SetMax();
        }
        public void MinRegTopRightBurner()
        {
            topRightBurner.SetMin();
        }
        public void NormRegTopRightBurner()
        {
            topRightBurner.SetNorm();
        }
        public void MaxRegTopRightBurner()
        {
            topRightBurner.SetMax();
        }

        public void MinRegButtomLeftBurner()
        {
            buttomLeftBurner.SetMin();
        }

        public void NormRegButtomLeftBurner()
        {
            buttomLeftBurner.SetNorm();
        }

        public void MaxRegButtomLeftBurner()
        {
            buttomLeftBurner.SetMax();
        }

        public void MinRegButtomRightBurner()
        {
            buttomRightBurner.SetMin();
        }

        public void NormRegButtomRightBurner()
        {
            buttomRightBurner.SetNorm();
        }

        public void MaxRegButtomRightBurner()
        {
            buttomRightBurner.SetMax();
        }
        public void SetOvenRegimNul()
        {
            oven.SetRegimNul();
        }
        public void SetOvenClassic_heating()
        {
            oven.SetClassic_heating();
        }
        public void SetOvenVentilating_heating()
        {
            oven.SetVentilating_heating();
        }
        public void SetOvenBottom_heat_fan_operation()
        {
            oven.SetBottom_heat_fan_operation();
        }
        public void SetOvenGrill()
        {
            oven.SetGrill();
        }
        public void SetOvenTurbo_grill()
        {
            oven.SetTurbo_grill();
        }
        public void SetOvenSmart_chef()
        {
            oven.SetSmart_chef();
        }
        public void SetOvenPizza()
        {
            oven.SetPizza();
        }
        public void SwitchOnOven()
        {
            Oven.SwitchOn();
        }
        public void SwitchOffOven()
        {
            Oven.SwitchOff();
        }
        public void SetOvenNextPoint()
        {
            oven.NextPoint();
        }
        public void SetOvenPrevPoint()
        {
            oven.PrevPoint();
        }
       
        public override string ToString()
        {
            string onOff;
            if (State)
                onOff = "Включен";
            else
                onOff = "Выключен";
            return "\n прибор: " + Name + " в состонии: " + onOff +
                " \n Верхняя правая комфорка:\n состояние  верхней правой комфорки: " + topRightBurner.State +
                "\n режим верхней правой комфорки: " + topRightBurner.Burnerregime +
                " \n Верхняя левая комфорка:\n состояние  верхней левой комфорки: " + topLeftBurner.State +
                "\n режим верхней левой комфорки: " + topLeftBurner.Burnerregime +
                " \n Нижняя правая комфорка:\n состояние  нижней правой комфорки: " + topRightBurner.State +
                "\n режим нижней правой комфорки: " + buttomRightBurner.Burnerregime +
                " \n Нижняя левая комфорка:\n состояние  нижней левой комфорки: " + buttomLeftBurner.State +
                "\n режим нижней левой комфорки: " + buttomLeftBurner.Burnerregime +
                "\n Духовка\n:" + "\n состоние духовки: \n" + oven.State + "\n температура духовки " + oven.Temperature +
                "\n режим работы духовки" + oven.Ovenregime;
        }
    }
}