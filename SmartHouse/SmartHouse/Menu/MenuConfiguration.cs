using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHouse
{
    class MenuConfiguration
    {
        public MenuConfiguration() { }
        public void Configuration()
        {
            Console.Clear();
            string s = " Доступные операции ";
            Console.WriteLine("\n " + s.ToUpper() + "\n");
            Console.WriteLine("1.Создать компонент \n ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\n для созааниянеоходимо указать 'создать лампа, \n кондиционер(компонент с списка)'"); 
            Console.WriteLine(" задавая имя компонента, имя должно отличаться дополнительным знаком, \n например: лампа1, лампа2 и т.д");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\n2.Удалить компонент ");
            Console.WriteLine("3.Отобразить компонент");
            Console.WriteLine("4.Bернуться в главное меню");

        }
        public string DelatingComponent()
        {
            Console.WriteLine(" Введите название устройство которое необходимо удалить");
            string del = Console.ReadLine();
            return del;
        }

        public void CreateaComponent(Equipment component)
        {
            Console.WriteLine(" \n Введите имя компонента ");
            component.Name = Console.ReadLine();
            Console.WriteLine(" \n Выберите состояние: включен, выключен");
            string state = Console.ReadLine();
            if (state.StartsWith("вкл") || state.StartsWith("Вкл"))
            {
                component.State = true;
            }
            else
            {
                component.State = false;
            }

        }
        public void MenuForCreateTemperatureControl(TemperatureControl comp)
        {
            Console.WriteLine(" Настройка данных");
            Console.WriteLine(" Укажите максимально возможную температуру для работы устройства");
            comp.MaxTemperature = Int32.Parse(Console.ReadLine());
            Console.WriteLine(" Укажите минимально возможную температуру для работы устройства");
            comp.MinTemperatire = Int32.Parse(Console.ReadLine());
        }

        public void MenuForStove(Stove comp)
        {
            while(true)
            {
                Console.Clear();
                Console.WriteLine("\nВыберие компонент для управления : ");
                Console.WriteLine("1 - Верхняя правая комфорка");
                Console.WriteLine("2 - Верхняя левая комфорка");
                Console.WriteLine("3 - Нижняя правая комфорка");
                Console.WriteLine("4 - Нижняя левая комфорка");
                Console.WriteLine("5 - Духовка");
                Console.WriteLine("6 - Вернуться в главное меню");
                int st = Int32.Parse(Console.ReadLine());
                switch (st)
                {
                case 1:
                    MenuForTopRightBurner(comp);
                    break;
                case 2:
                    MenuForTopLeftBurner(comp);
                    break;
                case 3:
                    MenuForButtomRightBurner(comp);
                    break;
                case 4:
                    MenuForButtomLeftBurner(comp);
                    break;
                case 5:
                    MenuForOven(comp.Oven);
                    break;
                case 6:
                return;
                }
             }
          }
        public void MenuForTopRightBurner(Stove comp)
        {
            while(true)
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("для дальнейшего управления введите '1' ");
                Console.WriteLine("для возврата в меню ПЛИТЫ нажмите '0' ");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                char a = Console.ReadKey().KeyChar;
                switch(a)
                {
                case'1':
                Console.Clear();
                Console.WriteLine("\n1 - Включить устройство");
                Console.WriteLine("2 - Выключить устройство");
                Console.WriteLine("3 - Установить режим огня Min");
                Console.WriteLine("4 - Установить режим огня Norm");
                Console.WriteLine("5 - Установить режим огня Max ");
                int str2 = Int32.Parse(Console.ReadLine());
                switch (str2)
                    {
                    case 1:
                        comp.SwitchOnTopRightBurner();
                        break;
                    case 2:
                        comp.SwitchOffTopRightBurner();
                        break;
                    case 3:
                        comp.MinRegTopRightBurner();
                        break;
                    case 4:
                        comp.NormRegTopRightBurner();
                        break;
                    case 5:
                        comp.MaxRegTopRightBurner();
                        break;
                   }
                break;
                case '0':
                return;
                }
                string s = new String('-', 50);
                Console.WriteLine(s);
                Console.WriteLine(comp.TopRightBurner.ToString());
                Console.WriteLine(s);
            }
      }

        public void MenuForTopLeftBurner(Stove comp)
        {
            while(true)
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("для дальнейшего управления введите '1' ");
                Console.WriteLine("для возврата в меню ПЛИТЫ нажмите '0' ");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                char a = Console.ReadKey().KeyChar;
                int str2;
                switch(a)
                {
                case '1':
                Console.Clear();
                Console.WriteLine("\n1 - Включить устройство");
                Console.WriteLine("2 - Выключить устройство");
                Console.WriteLine("3 - Установить режим огня Min");
                Console.WriteLine("4 - Установить режим огня Norm");
                Console.WriteLine("5 - Установить режим огня Max ");
                str2 = Int32.Parse(Console.ReadLine());
                switch (str2)
                {
                    case 1:
                        comp.SwitchOnTopLeftBurner();
                        break;
                    case 2:
                        comp.SwitchOffTopLeftBurner();
                        break;
                    case 3:
                        comp.MinRegTopLeftBurner();
                        break;
                    case 4:
                        comp.NormRegTopLeftBurner();
                        break;
                    case 5:
                        comp.MaxRegTopLeftBurner();
                        break;
                }
                break;
                case '0':
                return;
                }
                string s = new String('-', 50);
                Console.WriteLine(s);
                Console.WriteLine(comp.TopLeftBurner.ToString());
                Console.WriteLine(s);
            }
         }
        public void MenuForButtomRightBurner(Stove comp)
        {
            while(true)
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("для дальнейшего управления введите '1' ");
                Console.WriteLine("для возврата в меню ПЛИТЫ нажмите '0' ");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                char a = Console.ReadKey().KeyChar;
                int str2;
                switch(a)
                {
                case '1':
                Console.Clear();
                Console.WriteLine("\n1 - Включить устройство");
                Console.WriteLine("2 - Выключить устройство");
                Console.WriteLine("3 - Установить режим огня Min");
                Console.WriteLine("4 - Установить режим огня Norm");
                Console.WriteLine("5 - Установить режим огня Max ");
                str2 = Int32.Parse(Console.ReadLine());
                switch (str2)
                {
                    case 1:
                        comp.SwitchOnButtomRightBurner();
                        break;
                    case 2:
                        comp.SwitchOffButtomRightBurner();
                        break;
                    case 3:
                        comp.MinRegButtomRightBurner();
                        break;
                    case 4:
                        comp.NormRegButtomRightBurner();
                        break;
                    case 5:
                        comp.MaxRegButtomRightBurner();
                        break;
               }
               break;
               case '0':
               return;
                }
                string s = new String('-', 50);
                Console.WriteLine(s);
                Console.WriteLine(comp.ButtomRightBurner.ToString());
                Console.WriteLine(s);
            }
          }
        public void MenuForButtomLeftBurner(Stove comp)
        {
            while(true)
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("для дальнейшего управления введите '1' ");
                Console.WriteLine("для возврата в меню ПЛИТЫ нажмите '0' ");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                char a = Console.ReadKey().KeyChar;
                int str2;
                switch(a)
                {
                case '1':
                Console.Clear();
                Console.WriteLine("\n1 - Включить устройство");
                Console.WriteLine("2 - Выключить устройство");
                Console.WriteLine("3 - Установить режим огня Min");
                Console.WriteLine("4 - Установить режим огня Norm");
                Console.WriteLine("5 - Установить режим огня Max ");
                str2 = Int32.Parse(Console.ReadLine());
                switch (str2)
                {
                    case 1:
                        comp.SwitchOnButtomLeftBurner();
                        break;
                    case 2:
                        comp.SwitchOffButtomLeftBurner();
                        break;
                    case 3:
                        comp.MinRegButtomLeftBurner();
                        break;
                    case 4:
                        comp.NormRegButtomLeftBurner();
                        break;
                    case 5:
                        comp.MaxRegButtomLeftBurner();
                        break;
                }
                break;
                case '0':
                return;
                }
                string s = new String('-', 50);
                Console.WriteLine(s);
                Console.WriteLine(comp.ButtomLeftBurner.ToString());
                Console.WriteLine(s);
                }
              }

        public void MenuForOven(Oven comp)
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("для дальнейшего управления введите '1' ");
                Console.WriteLine("для возврата в меню ПЛИТЫ нажмите '0' ");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                char a = Console.ReadKey().KeyChar;
                switch(a)
                {
                case '1':
                Console.Clear();
                Console.WriteLine("\n1 - Включить духовку");
                Console.WriteLine("2 - Выключить духовку");
                Console.WriteLine("3 - выбрать режим 'Классическое запекание'");
                Console.WriteLine("4 - выбрать режим 'Подогрев вентиляционный '");
                Console.WriteLine("5 - выбрать режим 'Нижний нагрев'");
                Console.WriteLine("6 - выбрать режим 'Гриль'");
                Console.WriteLine("7 - выбрать режим 'Турбо гриль'");
                Console.WriteLine("8 - выбрать режим 'Умный повар'");
                Console.WriteLine("9 - выбрать режим 'Пицца'");
                Console.WriteLine("10 - выбрать режим 'Нулевой режим - ожидания'");
                Console.WriteLine("11 - Установить температуру");
                Console.WriteLine("12 - Увеличить температуру приготовления");
                Console.WriteLine("13 - Снизить температуру приготовления");
                int str2 = Int32.Parse(Console.ReadLine());
                switch (str2)
                {
                    case 1:
                        comp.SwitchOn();
                        break;
                    case 2:
                        comp.SwitchOff();
                        break;
                    case 3:
                        comp.SetClassic_heating();
                        break;
                    case 4:
                        comp.SetVentilating_heating();
                        break;
                    case 5:
                        comp.SetBottom_heat_fan_operation();
                        break;
                    case 6:
                        comp.SetGrill();
                        break;
                    case 7:
                        comp.SetTurbo_grill();
                        break;
                    case 8:
                        comp.SetSmart_chef();
                        break;
                    case 9:
                        comp.SetPizza();
                        break;
                    case 10:
                        comp.SetRegimNul();
                        break;
                    case 11:
                        Console.WriteLine("11 - Установить температуру");
                        int t = Int32.Parse(Console.ReadLine());
                        comp.Temperature = t;
                        break;
                    case 12:
                        comp.NextPoint();
                        break;
                    case 13:
                        comp.PrevPoint();
                        break;
                }
                break;
                case '0':
                return;
                }
                string s = new String('-', 50);
                Console.WriteLine(s);
                Console.WriteLine(comp.ToString());
                Console.WriteLine(s);
            }
        }
        public void SubMenuForISwitch(ISwitch comp)
        {
            Console.WriteLine("\n1 - Включить устройство");
            Console.WriteLine("2 - Выключить устройство");

        }
        public void SubMenuForIRegulator(IRegulator comp)
        {
            Console.WriteLine("\n3 - Увеличить температуру");
            Console.WriteLine("4 - Снизить температуру");
        }

        public void SubMenuForIMode(IMode comp)
        {
            Console.WriteLine("5 - Установить режим лето");
            Console.WriteLine("6 - Установить режим зима");

        }
        public void SubMenuForISettingTemperature(ISettingTemperature comp)
        {
            Console.WriteLine("7 - Установить комфортную температуру");
            int t = Int32.Parse(Console.ReadLine());
            ((ISettingTemperature)comp).Temperature = t;
        }
        public void SubMenuForIRegimeMinMax(IRegimeMinMax comp)
        {
            Console.WriteLine("\n8 - Установить режим  Min");
            Console.WriteLine("9 - Установить режим  Norm");
            Console.WriteLine("10 - Установить режим Max ");
        }


        public string SubMenuForManagment()
        {
            Console.Clear();
            Console.WriteLine(" \n Bведите имя устройства \n");
            string tmp = Console.ReadLine();
            return tmp;
        }
        
    }
}
