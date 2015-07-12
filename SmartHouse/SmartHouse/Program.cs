using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SmartHouse;

namespace SmartHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Handle();
            MenuConfiguration menuConfiguration = new MenuConfiguration();
        }
    }
}
