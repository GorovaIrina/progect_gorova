using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartHouseWebApplication
{
    abstract class Equipment
    {
        private string name;

        public Equipment() { }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private bool state;

        public bool State
        {
            get { return state; }
            set { state = value; }
        }

        public Equipment(string name, bool state)
        {
            this.name = name;
            this.state = state;
        }
        public abstract string ToString();
    }
}