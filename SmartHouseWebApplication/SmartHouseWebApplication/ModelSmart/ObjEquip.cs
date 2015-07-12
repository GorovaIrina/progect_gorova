using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartHouseWebApplication
{
    public class ObjEquip 
    {

        private Dictionary<int, Equipment> eq;

        internal Dictionary<int, Equipment> Eq
        {
            get { return eq; }
            set { eq = value; }
        }
        public ObjEquip()
        {
            this.eq = new Dictionary<int,Equipment>();
            eq.Add(1, new Heating("котел", false, 0, EnumClimatRegime.summer, 0, 40));
            eq.Add(2, new Split("кондиционер", false, 0, EnumClimatRegime.summer, 0, 40));
            eq.Add(3, new Light("лампа", false));
            Oven o1 = new Oven("духовка", false, EnumRegimeOven.regimNul, 0);
            Burner b1 = new Burner("верхняя левая комфорка", false, EnumeRegimeMinMax.Min);
            Burner b2 = new Burner("верхняя правая комфорка", false, EnumeRegimeMinMax.Min);
            Burner b3 = new Burner("нижняя левая комфорка", false, EnumeRegimeMinMax.Min);
            Burner b4 = new Burner("нижняя правая комфорка", false, EnumeRegimeMinMax.Min);
            eq.Add(4, new Stove("плита", false, new Burner(), new Burner(),new Burner(),new Burner(), new Oven()));
            eq.Add(5, new KitchenHood("вытяжка", false, EnumeRegimeMinMax.Min));
        }
       internal string MenuForCreating(Dictionary<int, Equipment> comp, string compKey)
        {
           int i = comp.Keys.Max();
          
           int j = ++i; i = j;
           string s = null;
           switch(compKey)
           {
               case "Split":
                   Split split = new Split("кондиционер", false, 0, EnumClimatRegime.summer, 0, 40);
                   comp.Add(j, split);
                   s = split.ToString() + " id: " + j.ToString();
                   break;
               case "Light":
                   Light light = new Light("лампа", false);
                   comp.Add(j, light);
                   s = light.ToString() + " id: " + j.ToString();
                       break;
                   case"Heating":
                   Heating heating = new Heating("котел", false, 0, EnumClimatRegime.summer, 0, 40);
                   comp.Add(j, heating);
                   s = heating.ToString() + " id: " + j.ToString();
                       break;
                   case"Kitch_hood":
                       KitchenHood kitch_hood = new KitchenHood("вытяжка", false, EnumeRegimeMinMax.Min);
                   comp.Add(j, kitch_hood);
                   s = kitch_hood.ToString() + " id: " + j.ToString();
                       break;
                   case"Stove":
                   Stove stove = new Stove("плита", false, new Burner(), new Burner(),new Burner(),new Burner(), new Oven());
                   comp.Add(j, stove);
                   s = stove.ToString() + " id: " + j.ToString();
                       break;
           }
           return "вы добавили: " +s;
       }
        internal void MenuForDelatin(Dictionary<int, Equipment> comp, int key)
       {
           if (comp.ContainsKey(key))
           {
               comp.Remove(key);
           }
       }
       
              
        }

       
        
    }
