using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHouse
{
    public class MainMenu
    {
        private Dictionary<string, Equipment> eq;
        private MenuConfiguration menuConfiguration;
        private string key;

        public MainMenu()
        {
            eq = new Dictionary<string, Equipment>();
            menuConfiguration = new MenuConfiguration();
        }
        public void Handle()
        {
            eq.Add("вытяжка", new KitchenHood("вытяжка", false, EnumeRegimeMinMax.Min));
            eq.Add("котел", new Heating("котел", false, 0, EnumClimatRegime.summer, 0, 40));
            eq.Add("кондиционер", new Split("кондиционер", false, 0, EnumClimatRegime.summer, 0, 40));
            eq.Add("лампа", new Light("лампа", false));
            Oven o1 = new Oven("духовка", false, EnumRegimeOven.regimNul, 0);
            Burner b1 = new Burner("верхняя левая комфорка", false,EnumeRegimeMinMax.Min);
            Burner b2 = new Burner("верхняя правая комфорка", false,EnumeRegimeMinMax.Min);
            Burner b3 = new Burner("нижняя левая комфорка", false, EnumeRegimeMinMax.Min);
            Burner b4 = new Burner("нижняя правая комфорка", false, EnumeRegimeMinMax.Min);
            eq.Add("плита", new Stove("плита", false, b1, b2, b3, b4, o1));
            
                while(true)
                {
                ShowHeaderMainMenu();
                Console.WriteLine("\n" + "Введите команду" + "\n");
                string command = Console.ReadLine();
                string[] c1 = command.Split(' ');
                ShowMainMenu(c1[0]);
                }
          }
        private void ShowHeaderMainMenu()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            string header = "Умный дом";
            string h2 = "Список доступных компонентов:";
            Console.WriteLine(header.ToUpper() + "\n" + "\n" + h2.ToUpper() + "\n");
            string[] b = new string[5] { "1. Лампа", "2. Плита", "3. Кондиционер", "4. Котел", "5. Кухонная вытяжка" };
            foreach (string c in b)
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine(c);
                }
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            string s = "Команды";
            Console.WriteLine("\n" + s.ToUpper() + "\n");
            string[] sm = new string[4] { "Конфигурация", "Управление", "Отображение состояния устройств", "Выход" };
                foreach (string s1 in sm)
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine(s1);
                }
         }
  
        private void ShowMainMenu(string comp)
        {
           switch (comp)
           {
           case "конфигурация":
           bool isBack = false;
           while(!isBack)
             { 
             menuConfiguration.Configuration();
             string command2 = Console.ReadLine();
             string[] c2 = command2.Split(' ');
             isBack = ShowMenuConfiguration(c2);
             }
             Console.Clear();
           break;
           case "управление":
             SubMenuForMainManagment();
             Console.Clear();
           break;
           case "отображение":
             ShowAllEquipments();
             Console.Clear();
           break;
           case "выход":
           Environment.Exit(0);
           Console.ReadKey();
           break;
             }
           }
       
        private bool ShowMenuConfiguration(string[] comp)
        {
           bool isBack = false;
           switch (comp[0])
           {
           case "создать":
             CreateComponent2(comp[1]);
           break;
           case "удалить":
             MenuForDeleting();
           break;
           case "отобразить":
             ShowComponent();
           break;
           case "вернуться":
           isBack = true;
           break;
           }
       return isBack;
      }
        
        private void CreateComponent2(string comp)
        {
            while(true)
            { 
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("введите '1' чтобы создать компонент");
            Console.WriteLine("введите '0' что бы вернуться");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            char a = Console.ReadKey().KeyChar;
            switch (a)
            {
                case '1':
                    switch (comp)
                    {
                        case "лампа":
                            Light light = new Light();
                            menuConfiguration.CreateaComponent(light);
                            key = light.Name;
                            eq.Add(key, light);
                            Console.Clear();
                            Console.WriteLine("\n Создано устройство:\n" + "\n" + light.ToString());
                            break;
                        case "кондиционер":
                            Split split = new Split();
                            menuConfiguration.CreateaComponent(split);
                            menuConfiguration.MenuForCreateTemperatureControl(split);
                            key = split.Name;
                            eq.Add(key, split);
                            Console.Clear();
                            string onOff;
                            if (split.State)
                            {
                                onOff = "включен";
                            }
                            else
                            {
                                onOff = "выключен";
                            }
                            Console.WriteLine("\n Создано устройство:\n" + "\n" + split.Name +
                                " в состоянии: " + onOff + "\n минимальная температура: " + split.MinTemperatire +
        "\n максимальная темпертура: " + split.MaxTemperature);
                            break;
                        case "котел":
                            Heating heating = new Heating();
                            menuConfiguration.CreateaComponent(heating);
                            menuConfiguration.MenuForCreateTemperatureControl(heating);
                            key = heating.Name;
                            eq.Add(key, heating);
                            Console.Clear();
                            if (heating.State)
                            {
                                onOff = "включен";
                            }
                            else
                            {
                                onOff = "выключен";
                            }
                            Console.WriteLine("\n Создано устройство:\n" + "\n" + heating.Name +
                                " в состоянии: " + onOff + "\n минимальная температура: " + heating.MinTemperatire +
        "\n максимальная темпертура: " + heating.MaxTemperature);
                            break;
                        case "плита":
                            Oven O = new Oven();
                            Burner B1 = new Burner();
                            Burner B2 = new Burner();
                            Burner B3 = new Burner();
                            Burner B4 = new Burner();
                            Stove stove = new Stove("плита", false, B1, B2, B3, B4, O);
                            menuConfiguration.CreateaComponent(stove);
                            key = stove.Name;
                            eq.Add(key, stove);
                            Console.Clear();
                            if (stove.State)
                            {
                                onOff = "включен";
                            }
                            else
                            {
                                onOff = "выключен";
                            }
                            Console.WriteLine("\n Создано устройство:\n" + "\n" + stove.Name + " в состоянии: " + onOff);
                            break;
                        case "вытяжка":
                            KitchenHood kitchenHood = new KitchenHood();
                            menuConfiguration.CreateaComponent(kitchenHood);
                            key = kitchenHood.Name;
                            eq.Add(key, kitchenHood);
                            Console.Clear();
                            if (kitchenHood.State)
                            {
                                onOff = "включен";
                            }
                            else
                            {
                                onOff = "выключен";
                            }
                            Console.WriteLine("\n Создано устройство:\n" + "\n" + kitchenHood.Name +
                                " в состоянии: " + onOff);
                            break;
                        case "вернуться":

                            break;
                     }
                    break;
                case '0':
                    return;
                }
            }
         }
       
        public void MenuForDeleting()
        {
            while(true)
            { 
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("введите '1' чтобы удалить компонент ");
            Console.WriteLine("введите '0' что бы вернуться");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            char a = Console.ReadKey().KeyChar;
            switch (a)
            {
                case '1':
                string del = menuConfiguration.DelatingComponent();
                if (eq.ContainsKey(del))
                {
                     eq.Remove(del);
                }
                Console.WriteLine("компонент " + del + " удален");
                break;
                case '0':
                return;
                }
            }
        }
        public void ShowComponent()
        {
            while(true)
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("введите '1' чтобы отобразить компонент ");
                Console.WriteLine("введите '0' что бы вернуться");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                char a = Console.ReadKey().KeyChar;
                switch(a)
                {
                case '1':
                Console.WriteLine("\nBведите название компонента который нужно отобразить");
                string show = Console.ReadLine();
                Equipment c = null;
                if (eq.ContainsKey(show))
                   {
                   c = eq[show];
                   string onOff;
                   if (c.State)
                   {
                      onOff = "включен";
                   }
                   else
                   {
                      onOff = "выключен";
                   }
                      Console.WriteLine("\n Устройство:\n" + "\n" + c.ToString());
                   }
                   break;
                   case '0':
                   return;
                }
            }
        }
        public void SubMenuForMainManagment()
        {
            string tmp = menuConfiguration.SubMenuForManagment();
            Console.WriteLine(" \n Для дальнейшего управления компонентами \n необходимо набирать цифру соответственного пункта");
            Equipment e = null;
            int d = 0;
            menuConfiguration.SubMenuForISwitch((ISwitch)e);
            int n = Int32.Parse(Console.ReadLine());
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("для дальнейшего управления введите '1' ");
                Console.WriteLine("для возврата в главное меню введите'0' ");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                char a = Console.ReadKey().KeyChar;
                switch(a)
                {
                    case '1':
                        if (eq.ContainsKey(tmp))
                        {
                            e = eq[tmp];
                            if (n == 1)
                            {
                                e.State = true;
                                switch (tmp)
                                {
                                case "плита":
                                menuConfiguration.MenuForStove((Stove)e);
                                if (e is Stove)
                                {
                                   Console.WriteLine(e.ToString());
                                }
                                break;
                                case "лампа":
                                case "кондиционер":
                                case "котел":
                                case "вытяжка":
                                if (e is ISwitch)
                                {
                                   menuConfiguration.SubMenuForISwitch((ISwitch)e);
                                }
                                if (e is IRegulator)
                                {
                                   menuConfiguration.SubMenuForIRegulator((IRegulator)e);
                                }
                                if (e is IMode)
                                {
                                   menuConfiguration.SubMenuForIMode((IMode)e);
                                }
                                   if (e is ISettingTemperature)
                                {
                                     Console.WriteLine("7 - Установить комфортную температуру");
                                }
                                   if (e is IRegimeMinMax)
                                {
                                    menuConfiguration.SubMenuForIRegimeMinMax((IRegimeMinMax)e);
                                }
                                d = Int32.Parse(Console.ReadLine());
                                switch (d)
                                 {
                                 case 1: 
                                    ((ISwitch)e).SwitchOn();
                                 break;
                                 case 2: 
                                    ((ISwitch)e).SwitchOff();
                                 break;
                                 case 3:
                                    ((IRegulator)e).NextPoint();
                                 break;
                                 case 4:
                                    ((IRegulator)e).PrevPoint();
                                 break;
                                 case 5:
                                    ((IMode)e).SummerMode();
                                 break;
                                 case 6:
                                    ((IMode)e).WinterMode();
                                 break;
                                 case 7:
                                    menuConfiguration.SubMenuForISettingTemperature((ISettingTemperature)e);
                                 break;
                                 case 8:
                                    ((IRegimeMinMax)e).SetMin();
                                 break;
                                 case 9:
                                    ((IRegimeMinMax)e).SetNorm();
                                 break;
                                 case 10:
                                    ((IRegimeMinMax)e).SetMax();
                                 break;
                                 }
                                Console.Clear();
                                 if (e is Light)
                                  {
                                     Console.WriteLine(e.ToString());
                                  }
                                 if (e is KitchenHood)
                                  {
                                     Console.WriteLine(e.ToString());
                                  }
                                 if (e is Heating)
                                  {
                                     Console.WriteLine(e.ToString());
                                  }
                                 if (e is Split)
                                  {
                                     Console.WriteLine(e.ToString());
                                  }
                                 if (e is Stove)
                                  {
                                    Console.WriteLine(e.ToString()+ "\n");
                                  }
                                break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Для упрвление необходимо включить устройство");
                                Console.ReadKey();
                            }
                        }
                        break;
                    case '0':
                        return;
                }
            }
        }
        public void ShowAllEquipments()
        {
            while(true)
            {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("введите '1' для отображения всех устройств умного дома");
            Console.WriteLine("введите '0' что бы вернуться");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            char a = Console.ReadKey().KeyChar;
            switch(a)
            {
            case '1':
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            string inf = "Состояние всех устройств Умного дома";
            Console.WriteLine("\n" + inf.ToUpper() + "\n" );
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            foreach (Equipment f in eq.Values)
             {
            string s = new String('-', 50);
            Console.WriteLine("\n" + s);
            Console.WriteLine(f.ToString());
            Console.WriteLine(s);
              }
            break;
            case '0':
            return;
            }
         }
      }
   }
 }
       
      
           
          
    
