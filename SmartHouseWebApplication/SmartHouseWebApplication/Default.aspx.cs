using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SmartHouseWebApplication
{
    public partial class Default : System.Web.UI.Page
    {
        ObjEquip objEq;
        Equipment d;
        Stove f;
        protected void Page_Init(object sender, EventArgs e)
        {

            // ListUpDate();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                objEq = new ObjEquip();
                Session["eqKey"] = objEq;
                AllInfo(objEq);
                FormDroplist();
            }
            else
            {
                
                Choose_split.Click += Choose_Equip;
                Choose_heating.Click += Choose_Equip;
                Choose_kitch_hood.Click += Choose_Equip;
                Choose_lamp.Click += Choose_Equip;
                Choose_stove.Click += Choose_Equip;
                heatTempMin.Click += ForIRegulator;
                heatTempPlus.Click += ForIRegulator;
                splitTempMin.Click += ForIRegulator;
                splitTempPlus.Click += ForIRegulator;
                ovenTempPlus.Click += OvenIRegulator;
                OvenTempMin.Click += OvenIRegulator;
                buttonSetHeating.Click += ForISetTemp;
                buttonSetSplit.Click += ForISetTemp;
                button_set_oven.Click += OvenISetTemp;
                error.Text = "";
                            
            }
        }
        protected void Form_Menu_Stove(object sender, EventArgs e)
        {
            d = (Equipment)Session["d"];
            ObjEquip objEq = (ObjEquip)Session["eqKey"];
            string selected = null;
            for (int i = 0; i < list_stove2.Items.Count; i++)
            {
                if (list_stove2.Items[i].Selected)
                {
                    selected = list_stove2.Items[i].Value;
                }
            }

            if (selected.Contains("topLeftBurner"))
            {
               burnertl.Visible = true;
               burnerbl.Visible = false;
               burnertr.Visible = false;
               burnerbr.Visible = false;
               menu_oven.Visible = false;
            }
            if (selected.Contains("topRightBurner"))
            {
               burnertr.Visible = true;
               burnertl.Visible = false;
               burnerbl.Visible = false;
               burnerbr.Visible = false;
               menu_oven.Visible = false;
            }
            if (selected.Contains("buttomRightBurner"))
            {
                burnertr.Visible = false;
                burnertl.Visible = false;
                burnerbl.Visible = false;
                burnerbr.Visible = true;
                menu_oven.Visible = false;
            }
            if (selected.Contains("buttomLeftBurner"))
            {
                burnertr.Visible = false;
                burnertl.Visible = false;
                burnerbl.Visible = true;
                burnerbr.Visible = false;
                menu_oven.Visible = false;
            }
            if (selected.Contains("oven"))
            {
                burnerbl.Visible = false;
                burnertl.Visible = false;
                burnertr.Visible = false;
                burnerbr.Visible = false;
                menu_oven.Visible = true;
            }
          
             Session["d"] = d;
             Session["s"] = d;
            Session["eqKey"] = objEq;

        }
        protected void TopLeftBurnerISwitch(object sender, EventArgs e)
        {
          ObjEquip objEq = (ObjEquip)Session["eqKey"];
          Stove d = (Stove)Session["s"]; 
            if(d!=null)
            {
                if (d.State == true)
                {
                     switch (((RadioButtonList)sender).SelectedValue)
                    {
                        case "вкл":
                            d.SwitchOnTopLeftBurner();
                            Label_stove.Text = d.ToString();
                            break;
                        case "выкл":
                            d.SwitchOffTopLeftBurner();
                            Label_stove.Text = d.ToString();
                            break;
                    }
                }
                else
                {
                    Label_stove.Text = "плита не включена. управление не доступно";
                }
            }
            else
            {
                Label_stove.Text = "плита не включена. управление не доступно";
            }
            Session["d"] = d;
            Session["eqKey"] = objEq;
        }
        protected void TopRigthBurnerISwitch(object sender, EventArgs e)
        {
            ObjEquip objEq = (ObjEquip)Session["eqKey"];
            Stove d = (Stove)Session["s"];
            if(d!=null)
            {
                if (d.State == true)
                {
                    switch (((RadioButtonList)sender).SelectedValue)
                    {
                        case "вкл":
                            d.SwitchOnTopRightBurner();
                            Label_stove.Text = d.ToString();
                            break;
                        case "выкл":
                            d.SwitchOffTopRightBurner();
                            Label_stove.Text = d.ToString();
                            break;
                    }
                }
                else
                {
                    Label_stove.Text = "плита не включена. управление не доступно";
                }
            }
            else
            {
                Label_stove.Text = "плита не включена. управление не доступно";
            }
            Session["d"] = d;
            Session["eqKey"] = objEq;
        }
        protected void BottLeftBurnerISwitch(object sender, EventArgs e)
        {
            ObjEquip objEq = (ObjEquip)Session["eqKey"];
            Stove d = (Stove)Session["s"];
            if(d!=null)
            {
                if(d.State==true)
             {
            switch (((RadioButtonList)sender).SelectedValue)
            {
                case "вкл":
                    d.SwitchOnButtomLeftBurner();
                    Label_stove.Text = d.ToString();
                    break;
                case "выкл":
                    d.SwitchOffButtomLeftBurner();
                    Label_stove.Text = d.ToString();
                    break;
                  }
            }
            else
                    {
                        Label_stove.Text = "плита не включена. управление не доступно";
                    }
            }
            else
            {
                Label_stove.Text = "плита не включена. управление не доступно";
            }
            Session["d"] = d;
            Session["eqKey"] = objEq;
        }

       
        protected void BotRigthBurnerISwitch(object sender, EventArgs e)
        {
            ObjEquip objEq = (ObjEquip)Session["eqKey"];
            Stove d = (Stove)Session["s"];
            if (d != null)
            {
                if (d.State == true)
                {
                    switch (((RadioButtonList)sender).SelectedValue)
                    {
                        case "вкл":
                            d.SwitchOnButtomRightBurner();
                            Label_stove.Text = d.ToString();
                            break;
                        case "выкл":
                            d.SwitchOffTopRightBurner();
                            Label_stove.Text = d.ToString();
                            break;
                    }
                }
                else
                {
                    Label_stove.Text = "плита не включена. управление не доступно";
                }
            }
            else
            {
                Label_stove.Text = "плита не включена. управление не доступно";
            }
            Session["d"] = d;
            Session["eqKey"] = objEq;
        }

        protected void MenuForOvenISwitch(object sender, EventArgs e)
        {
            ObjEquip objEq = (ObjEquip)Session["eqKey"];
            Stove d = (Stove)Session["s"];
            if (d != null)
            {
                if (d.State == true)
                {
                    switch (((RadioButtonList)sender).SelectedValue)
                    {
                        case "вкл":
                            d.SwitchOnOven();
                            Label_stove.Text = d.ToString();
                            break;
                        case "выкл":
                            d.SwitchOffOven();
                            Label_stove.Text = d.ToString();
                            break;
                    }
                }
                else
                {
                    Label_stove.Text = "плита не включена. управление не доступно";
                }
            }
            else
            {
                Label_stove.Text = "плита не включена. управление не доступно";
            }
            Session["d"] = d;
            Session["eqKey"] = objEq;
        }

        protected void TopLeftBurnerIMinMax(object sender, EventArgs e)
        {
            ObjEquip objEq = (ObjEquip)Session["eqKey"];
            Stove d = (Stove)Session["s"];
            if (d != null)
            {
                if (d.State == true)
                {
                    if (d.TopLeftBurner.State == true)
                    {
                        switch (((RadioButtonList)sender).SelectedValue)
                        {
                            case "режим min":
                                d.MinRegTopLeftBurner();
                                Label_stove.Text = d.ToString();
                                break;
                            case "режим norm":
                                d.NormRegTopLeftBurner();
                                Label_stove.Text = d.ToString();
                                break;
                            case "режим max":
                                d.MaxRegTopLeftBurner();
                                Label_stove.Text = d.ToString();
                                break;
                        }
                    }
                    else
                    {
                        Label_stove.Text = "Ошибка прибор выключен! управление не доступно!";
                    }
                }
                else
                {
                    Label_stove.Text = "Ошибка прибор выключен! управление не доступно!";
                }
            }
            else
            {
                Label_stove.Text = "Ошибка не выбрана плита! управление не доступно!";
            }
            Session["d"] = d;
            Session["eqKey"] = objEq;
        }
        
        protected void TopRigthBurnerIMinMax(object sender, EventArgs e)
        {
            ObjEquip objEq = (ObjEquip)Session["eqKey"];
            Stove d = (Stove)Session["s"];
            if (d != null)
            {
                if (d.State == true)
                {
                    if (d.TopRightBurner.State == true)
                    {
                        switch (((RadioButtonList)sender).SelectedValue)
                        {
                            case "режим min":
                                d.MinRegTopRightBurner();
                                Label_stove.Text = d.ToString();
                                break;
                            case "режим norm":
                                d.NormRegTopRightBurner();
                                Label_stove.Text = d.ToString();
                                break;
                            case "режим max":
                                d.MaxRegTopRightBurner();
                                Label_stove.Text = d.ToString();
                                break;
                        }
                    }
                    else
                    {
                        Label_stove.Text = "Ошибка прибор выключен! управление не доступно!";
                    }
                }
                else
                {
                    Label_stove.Text = "Ошибка прибор выключен! управление не доступно!";
                }
            }
            else
            {
                Label_stove.Text = "Ошибка не выбрана плита! управление не доступно!";
            }

            Session["d"] = d;
            Session["eqKey"] = objEq;
        }
        
        protected void BotLeftBurnerIMinMax(object sender, EventArgs e)
        {
            ObjEquip objEq = (ObjEquip)Session["eqKey"];
            Stove d = (Stove)Session["s"];
            if (d != null)
            {
                if (d.State == true)
                {
                    if (d.ButtomLeftBurner.State == true)
                    {
                        switch (((RadioButtonList)sender).SelectedValue)
                        {
                            case "режим min":
                                d.MinRegButtomLeftBurner();
                                Label_stove.Text = d.ToString();
                                break;
                            case "режим norm":
                                d.NormRegButtomLeftBurner();
                                Label_stove.Text = d.ToString();
                                break;
                            case "режим max":
                                d.MaxRegTopLeftBurner();
                                Label_stove.Text = d.ToString();
                                break;
                        }
                    }
                    else
                    {
                        Label_stove.Text = "Ошибка прибор выключен! управление не доступно!";
                    }
                }
                else
                {
                    Label_stove.Text = "Ошибка прибор выключен! управление не доступно!";
                }
            }
            else
            {
                Label_stove.Text = "Ошибка не выбрана плита! управление не доступно!";
            }
            Session["d"] = d;
            Session["eqKey"] = objEq;
        }
       
        protected void BotRigthBurnerIMinMax(object sender, EventArgs e)
        {
            ObjEquip objEq = (ObjEquip)Session["eqKey"];
            Stove d = (Stove)Session["s"];
            if (d != null)
            {
                if (d.State == true)
                {
                    if (d.ButtomRightBurner.State == true)
                    {
                        switch (((RadioButtonList)sender).SelectedValue)
                        {
                            case "режим min":
                                d.MinRegButtomRightBurner();
                                Label_stove.Text = d.ToString();
                                break;
                            case "режим norm":
                                d.NormRegButtomRightBurner();
                                Label_stove.Text = d.ToString();
                                break;
                            case "режим max":
                                d.MaxRegButtomRightBurner();
                                Label_stove.Text = d.ToString();
                                break;
                        }
                    }
                    else
                    {
                        Label_stove.Text = "Ошибка прибор выключен! управление не доступно!";
                    }

                }
                else
                {
                    Label_stove.Text = "Ошибка прибор выключен! управление не доступно!";
                }
            }
            else
            {
                Label_stove.Text = "Ошибка не выбрана плита! управление не доступно!";
            }
            Session["d"] = d;
            Session["eqKey"] = objEq;
        }
       
        protected void MenuForOvenRegime(object sender, EventArgs e)
        {
            ObjEquip objEq = (ObjEquip)Session["eqKey"];
            Stove d = (Stove)Session["s"];
            if(d !=null)
            {
                if (d.State == true)
                {
                    if (d.Oven.State == true)
                    {
                        switch (((RadioButtonList)sender).SelectedValue)
                        {
                            case "режим 0":
                                d.SetOvenRegimNul();
                                break;
                            case "класическое запекание":
                                d.SetOvenClassic_heating();
                                break;
                            case "вентилятор + запекание":
                                d.SetOvenVentilating_heating();
                                break;
                            case "нижний подогрев":
                                d.SetOvenBottom_heat_fan_operation();
                                break;
                            case "гриль":
                                d.SetOvenGrill();
                                break;
                            case "турбо гриль":
                                d.SetOvenTurbo_grill();
                                break;
                            case "умный повар":
                                d.SetOvenSmart_chef();
                                break;
                            case "пицца":
                                d.SetOvenPizza();
                                break;
                        }
                        Label_stove.Text = d.ToString();
                    }
                    else
                    {
                        Label_stove.Text = "Ошибка прибор выключен! управление не доступно!";
                    }
                }
                else
                {
                    Label_stove.Text = "Ошибка не выбрана плита! управление не доступно!";
                }

            }
            else
            {
                 Label_stove.Text = "Ошибка прибор выключен! управление не доступно!";
             }
           
            Session["d"] = d;
            Session["eqKey"] = objEq;
        }

        protected void ForISwich(object sender, EventArgs e)
        {
            objEq = (ObjEquip)Session["eqKey"];
            d = (Equipment)Session["d"]; 
            if( d != null)
            {
               string k = d.Name;
               switch (k)
                {
                    case "лампа":
                        if (RadioButtonLampOnOff.SelectedItem.Value == "вкл")
                        {
                            ((ISwitch)d).SwitchOn();
                        }
                        else
                        {
                            ((ISwitch)d).SwitchOff();
                        }
                        Label_lamp.Text = d.ToString();
                        break;
                    case "котел":
                        if (RadioButtonHeatingOnOff.SelectedItem.Value == "вкл")
                        {
                            ((ISwitch)d).SwitchOn();
                        }
                        else
                        {
                            ((ISwitch)d).SwitchOff();
                        }
                        Label_heating.Text = d.ToString();
                        break;
                    case "кондиционер":
                        if (RadioButtonSplitOnOff.SelectedItem.Value == "вкл")
                        {
                            ((ISwitch)d).SwitchOn();
                        }
                        else
                        {
                            ((ISwitch)d).SwitchOff();
                        }
                        Label_split.Text = d.ToString();
                        break;
                    case "вытяжка":
                        if (RadioButtonKHOnOff.SelectedItem.Value == "вкл")
                        {
                            ((ISwitch)d).SwitchOn();
                        }
                        else
                        {
                            ((ISwitch)d).SwitchOff();
                        }
                        Label_kitch_hood.Text = d.ToString();
                        break;
                    case "плита":
                        if (RadioButtonStoveOnOff.SelectedItem.Value == "вкл")
                        {
                            ((ISwitch)d).SwitchOn();
                        }
                        else
                        {
                            ((ISwitch)d).SwitchOff();
                        }
                        Label_stove.Text = d.ToString();
                        break;
                }
            }
            else
            {
                error.Text = "ВЫ НЕ ВЫБРАЛИ ЭЛЕМЕНТ УПРАВЛЕНИЕ НЕ ДОСТУПНО";
            }
           
            Session["d"] = d;
            Session["eqKey"] = objEq;
        }
        protected void ForIMode(object sender, EventArgs e)
        {
            objEq = (ObjEquip)Session["eqKey"];
            d = (Equipment)Session["d"];
           
            if (d!= null)
            {
                string k = d.Name;
               if(d.State == true)
               {  
                   switch (k)
                   {
                        case "котел":
                        if (RadioButtonHeatingImode.SelectedItem.Value == "режим Зима" )
                        {
                            ((IMode)d).WinterMode();
                        }
                        else
                        {
                            ((IMode)d).SummerMode();
                        }
                        Label_heating.Text = d.ToString();
                        break;
                    case "кондиционер":
                        if (RadioButtonSplitIMode.SelectedItem.Value == "режим Зима")
                        {
                            ((IMode)d).WinterMode();
                        }
                        else
                        {
                            ((IMode)d).SummerMode();
                        }
                        Label_split.Text = d.ToString();
                        break;
                }
             }
               else
               {
                   error.Text = "Ошибка прибор выключен или  не выбран из списка! управление не доступно!";

               }
           }
            else
            {
               error.Text = "Ошибка прибор выключен или  не выбран из списка! управление не доступно!";
               
            }
            Session["d"] = d;
            Session["eqKey"] = objEq;
        }
        protected void ForIMinMax(object sender, EventArgs e)
        {
            objEq = (ObjEquip)Session["eqKey"];
            d = (Equipment)Session["d"];
            
            if ( d!= null)
            {
                string k = null;
                k = RadioButtonKHMinMax.SelectedItem.Value;
               if(d.State == true)
             { 
                   switch(k)
                {
                    case"режим min":
                        ((IRegimeMinMax)d).SetMin();
                 Label_kitch_hood.Text = d.ToString();
                        break;
                    case"режим norm":
                        ((IRegimeMinMax)d).SetNorm();
                  Label_kitch_hood.Text = d.ToString();
                        break;
                    case"режим max":
                        ((IRegimeMinMax)d).SetMax();
                   Label_kitch_hood.Text = d.ToString();
                        break;
                        }
                   }
               else
               {
                   error.Text = "Ошибка прибор выключен или  не выбран из списка! управление не доступно!";
               }
            }
              else
            {
                error.Text = "Ошибка прибор выключен или  не выбран из списка! управление не доступно!";
            }
            
            Session["d"] = d;
            Session["eqKey"] = objEq;
        }

        protected void ForISetTemp(object sender, EventArgs e)
        {
            objEq = (ObjEquip)Session["eqKey"];
            d = (Equipment)Session["d"];

            if ( d != null)
            {
                string k = d.Name;
                if(d.State == true)
                {
                    switch (k)
                {
                    case "кондиционер":
                        SetTempSplit((ISettingTemperature)d);
                        Label_split.Text = d.ToString();
                        break;
                    case "котел":
                        SetTempHeating((ISettingTemperature)d);
                        Label_heating.Text = d.ToString();
                        break;
                 }
                }
                else
                {
                    error.Text = "Ошибка прибор выключен или  не выбран из списка! управление не доступно!";
                }
             }
            else
            {
                error.Text = "Ошибка прибор выключен или  не выбран из списка! управление не доступно!";
            }
            Session["d"] = d;
            Session["eqKey"] = objEq;
        }

        protected void OvenISetTemp(object sender, EventArgs e)
        {
            objEq = (ObjEquip)Session["eqKey"];
            Stove d = (Stove)Session["s"];
            if (d != null)
            {
                if (d.State == true)
                {
                    if(d.Oven.State== true)
                    { 
                    int t;
                    t = Convert.ToInt32(boxSetOven.Text);
                    ((Stove)d).Oven.Temperature = t;
                    Label_stove.Text = d.ToString();
                }
                    else
                    {
                        Label_stove.Text = "прибор выключен. управление не доступно!";
                    }
                }
                else
                {
                    Label_stove.Text = "прибор выключен. управление не доступно!";
                }
                Session["d"] = d;
                Session["eqKey"] = objEq;
            }
            else
            {
                Label_stove.Text = "прибор выключен. управление не доступно!";
            }
        }
        private void SetTempHeating(ISettingTemperature comp)
        {
            int t;
            t = Convert.ToInt32(boxSetHeating.Text);
            ((ISettingTemperature)comp).Temperature = t;
        }
        private void SetTempSplit(ISettingTemperature comp)
        {
            int t;
            t = Convert.ToInt32(boxSetSplit.Text);
            ((ISettingTemperature)comp).Temperature = t;

        }
       
        protected void ForIRegulator(object sender, EventArgs e)
        {
            objEq = (ObjEquip)Session["eqKey"];
            d = (Equipment)Session["d"];
            if(d!= null)
            { 
                string k = d.Name;
                if(d.State==true)
                {
                    switch (k)
                    {
                        case "котел":
                            switch (((Button)sender).ID)
                            {
                                case "heatTempPlus":
                                    ((IRegulator)d).NextPoint();
                                    Label_heating.Text = d.ToString();
                                    break;
                                case "heatTempMin":
                                    ((IRegulator)d).PrevPoint();
                                    Label_heating.Text = d.ToString();
                                    break;
                            }
                            break;
                        case "кондиционер":
                            switch (((Button)sender).ID)
                            {
                                case "splitTempPlus":
                                    ((IRegulator)d).NextPoint();
                                    Label_split.Text = d.ToString();
                                    break;
                                case "splitTempMin":
                                    ((IRegulator)d).PrevPoint();
                                    Label_split.Text = d.ToString();
                                    break;
                            }
                            break;
                    }
                }
                else
                {
                    error.Text = "Ошибка прибор выключен или  не выбран из списка! управление не доступно!";
                }
            }
            else
            {
                error.Text = "Ошибка прибор выключен или  не выбран из списка! управление не доступно!";
            }
        }
        protected void OvenIRegulator(object sender, EventArgs e)
        {
            objEq = (ObjEquip)Session["eqKey"];
            Stove d = (Stove)Session["s"];
            if(d !=null)
            { 
             if (d.State == true)
            {
                if (d.Oven.State == true)
                {
                    switch (((Button)sender).ID)
                    {
                        case "ovenTempPlus":
                            d.SetOvenNextPoint();
                            break;
                        case "OvenTempMin":
                            d.SetOvenPrevPoint();
                            break;
                    }
                    Label_stove.Text = d.ToString();
                }
                else
                {
                    Label_stove.Text = "прибор выключен. управление не доступно!";
                }     
              }
            else
            {
                         Label_stove.Text = "прибор выключен. управление не доступно!";
            }
       }
            else
            {
                Label_stove.Text = "прибор не выбран. управление не доступно!";
            }
      }

        protected void Form_Menu_Equip(object sender, EventArgs e)
        {
            int c = 0;
            ObjEquip objEq = (ObjEquip)Session["eqKey"];
            switch (((DropDownList)sender).ClientID)
            {
                case "list_lamp":
                    for (int i = 0; i < list_lamp.Items.Count; i++)
                    {
                        if (list_lamp.Items[i].Selected)
                        {
                            string a = list_lamp.Items[i].Text;
                            string[] b = a.Split('-');
                            c = Convert.ToInt32(b[1]);
                            Label_lamp.Text = "id: " + c.ToString() + "\n" + objEq.Eq[c].ToString();
                        }
                    }
                    break;
                case "list_heating":
                    for (int i = 0; i < list_heating.Items.Count; i++)
                    {
                        if (list_heating.Items[i].Selected)
                        {
                            string a = list_heating.Items[i].Text;
                            string[] b = a.Split('-');
                            c = Convert.ToInt32(b[1]);
                            Label_heating.Text = "id: " + c.ToString() + "\n" + objEq.Eq[c].ToString();
                        }
                    }
                    break;
                case "list_splits":
                    for (int i = 0; i < list_splits.Items.Count; i++)
                    {
                        if (list_splits.Items[i].Selected)
                        {
                            string a = list_splits.Items[i].Text;
                            string[] b = a.Split('-');
                            c = Convert.ToInt32(b[1]);
                            Label_split.Text = "id: " + c.ToString() + "\n" + objEq.Eq[c].ToString();
                        }
                    }
                    break;
                case "list_kitch_hood":
                    for (int i = 0; i < list_kitch_hood.Items.Count; i++)
                    {
                        if (list_kitch_hood.Items[i].Selected)
                        {
                            string a = list_kitch_hood.Items[i].Text;
                            string[] b = a.Split('-');
                            c = Convert.ToInt32(b[1]);
                            Label_kitch_hood.Text = "id: " + c.ToString() + "\n" + objEq.Eq[c].ToString();
                        }
                    }
                    break;
                case "list_stove":
                    for (int i = 0; i < list_stove.Items.Count; i++)
                    {
                        if (list_stove.Items[i].Selected)
                        {
                            string a = list_stove.Items[i].Text;
                            string[] b = a.Split('-');
                            c = Convert.ToInt32(b[1]);
                            Label_stove.Text = "id: " + c.ToString() + "\n" + objEq.Eq[c].ToString() + "id: " + c.ToString();
                        }
                    }
                    break;
             }
            d = objEq.Eq[c];
            Session["d"] = d;
            Session["eqKey"] = objEq;
            }

        protected void FormAddDropList(object sender, EventArgs e)
        {
            ObjEquip objEq = (ObjEquip)Session["eqKey"];
            string selected = null;
            for (int i = 0; i < DropDownList.Items.Count; i++)
            {
                if (DropDownList.Items[i].Selected)
                {
                    selected = DropDownList.Items[i].Value;
                    break;
                }
            }
            info.Text = objEq.MenuForCreating(objEq.Eq, selected);
            FormDroplist();
            Session["eqKey"] = objEq;
         }
      
        private void FormDroplist()
        {
            DropDownList1.Items.Clear();
            DropDownList2.Items.Clear();
            ObjEquip objEq = (ObjEquip)Session["eqKey"];
             foreach (KeyValuePair<int, Equipment> d in objEq.Eq)
            {
                ListItem item = new ListItem(d.Value.Name + "-" + d.Key.ToString());
                DropDownList1.Items.Add(item);
                DropDownList2.Items.Add(item);
            }
            Session["eqKey"] = objEq;
        }
        public void FormDelDropList(object sender, EventArgs e)
        {
            ObjEquip objEq = (ObjEquip)Session["eqKey"];
            string selected = "";
            int key = 0;
            for (int i = 0; i < DropDownList1.Items.Count; i++)
            {
                if (DropDownList1.Items[i].Selected)
                {
                    selected = DropDownList1.Items[i].Value;
                    string[] selected2 = selected.Split(new char[] { '-' });
                    key = Convert.ToInt32(selected2[1]);
                    info.Text = "Удален элемент: " + objEq.Eq[key].ToString() + "id: " + key.ToString();
                    objEq.MenuForDelatin(objEq.Eq, key);
                }
            }
            DropDownList1.Items.Remove(DropDownList1.SelectedItem);
            FormDroplist();
            Session["eqKey"] = objEq;
        }

        public void FormViewDropList(object sender, EventArgs e)
        {
            ObjEquip objEq = (ObjEquip)Session["eqKey"];
            string selected = null;
            int key = 0;
            for (int i = 0; i < DropDownList2.Items.Count; i++)
            {
                if (DropDownList2.Items[i].Selected)
                {
                    selected = DropDownList2.Items[i].Value;
                    string[] selected2 = selected.Split(new char[] { '-' });
                    key = Convert.ToInt32(selected2[1]);
                }
            }
            info.Text = objEq.Eq[key].ToString() + "id: " + key.ToString();
            Session["eqKey"] = objEq;
        }
        public void Choose_Equip(object sender, EventArgs e)
        {
            ObjEquip objEq = (ObjEquip)Session["eqKey"];
            list_splits.Items.Clear();
            list_stove.Items.Clear();
            list_lamp.Items.Clear();
            list_kitch_hood.Items.Clear();
            list_heating.Items.Clear();
            list_splits.Items.Add(" ");
            list_heating.Items.Add(" ");
            list_kitch_hood.Items.Add(" ");
            list_lamp.Items.Add(" ");
            list_stove.Items.Add(" ");
            foreach (var d in objEq.Eq)
            {
                ListItem item = new ListItem(d.Value.Name + "-" + Convert.ToString(d.Key), Convert.ToString(d.Key));
                if (d.Value.Name == "кондиционер")
                {
                    list_splits.Visible = true;
                    list_splits.Items.Add(item);
                 
                }
                if (d.Value.Name == "лампа")
                {
                    list_lamp.Visible = true;
                    list_lamp.Items.Add(item);
                  
                }
                if (d.Value.Name == "вытяжка")
                {
                   list_kitch_hood.Visible = true;
                    list_kitch_hood.Items.Add(item);
                    
                }
                if (d.Value.Name == "котел")
                {
                    list_heating.Visible = true;
                    list_heating.Items.Add(item);
                    
                }
                if (d.Value.Name == "плита")
                {
                    list_stove.Visible = true;
                    list_stove.Items.Add(item);
                   
                }

                Session["eqKey"] = objEq;
            }
        }

        public void AllInfo(ObjEquip c)
        {
            foreach (Equipment d in c.Eq.Values)
            {
                if (d is Light)
                {
                    Label_lamp.Text = "<br />" + d.ToString();
                }
                if (d is Split)
                {
                    Label_split.Text = "<br />" + d.ToString();
                }
                if (d is Heating)
                {
                    Label_heating.Text = "<br />" + d.ToString();
                }
                if (d is Stove)
                {
                    Label_stove.Text = "<br />" + d.ToString();
                }
                if (d is KitchenHood)
                {
                    Label_kitch_hood.Text = "<br />" + d.ToString();
                }
            }
        }
    }
}

