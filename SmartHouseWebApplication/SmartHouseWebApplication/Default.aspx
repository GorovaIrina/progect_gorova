<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SmartHouseWebApplication.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="Style.css" type="text/css" media="screen"/>
    <script type="text/javascript" src="JavaScript1.js"></script>
    <title> </title>
    <style type="text/css">
      
       #cell_stove{
           height:400px;
       }
       .top_button
       {
           border-bottom-width: thick;
           background-color: white;
          
       }
       #information{
           width:554px;
       }
      #section_heating{
  margin-left: 50px;
  float:left;
  width:220px;
}
#section_heating2{
        width:200px;
        margin-left: 320px;
    }
    
    #section_split{
        margin-left: 50px;
        float:left;
        width:260px;
    }
     #section_split2{
       width:200px;
      margin-left: 350px;
    }
     #section_kitch_hood{
          margin-left: 50px;
          float:left;
        width: 270px;
     }
     section_kitch_hood2{
         width:200px;
         margin-left: 340px;
     }
     #section_stove{
         padding-left: 50px;
        float:left;
        width:400px;
     }
     #section_stove2{
       padding-left:90px;
       width:250px;
       float: left
     }
     #section_stove3{
         width:300px;
       float: left
     }
    #Table2{
         height:54px;
     }
    #section_lamp {
        margin-left: 50px;
            float:left;
            width: 270px;
        }
#section_lamp2{
margin-left:340px;
width:220px;
}
#button_menuStov{
    width:209px;
}
#error{
      padding-left: 375px;
}
      </style>
    </head>
<body>
    <form id="form1" runat="server">
         <asp:Label ID="Label11" runat="server" Text="SMART HOUSE"></asp:Label> <br />
        <asp:Table ID="Table2" CssClass="tabl" runat="server" GridLines="Both" ForeColor="White" BorderColor="White" BorderWidth="10">  
          <asp:TableRow> 
              <asp:TableCell Width ="200" BorderWidth="0">
                  <input id ="add" class="top_button" type="button" value ="Дабавить компонент" onclick ="hide_show('chois_add');"/> 
                   <div id ="chois_add" style ="display:none">
                   <asp:DropDownList id="DropDownList" runat="server" AutoPostBack="true" OnSelectedIndexChanged="FormAddDropList" Width="141">
                        <asp:ListItem Value =" "> </asp:ListItem>
                        <asp:ListItem Value ="Split">Кондиционер </asp:ListItem>
                       <asp:ListItem Value ="Light"> Лампа </asp:ListItem>
                        <asp:ListItem Value ="Heating">Котел </asp:ListItem>
                        <asp:ListItem Value ="Kitch_hood">Вытяжка </asp:ListItem>
                        <asp:ListItem Value ="Stove"> Плита</asp:ListItem>
                </asp:DropDownList></div>
              </asp:TableCell>
              <asp:TableCell Width ="200">
                <input id="del" class="top_button" type ="button" value="Удалить компонент" onclick ="hide_show('chois_del');"/>
                <div id ="chois_del" style ="display:none"> 
                <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="true" Width="135" OnSelectedIndexChanged="FormDelDropList">
                 </asp:DropDownList>
                </div>
              </asp:TableCell>
              <asp:TableCell Width ="200">
                 <input id="show" type ="button" class="top_button" value="Отобразить компонент" onclick ="hide_show('chois_show');"/>
                <div id ="chois_show" style ="display:none"> 
                <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="true" OnSelectedIndexChanged="FormViewDropList" Width="154">
                </asp:DropDownList>
                 </div>
              </asp:TableCell>
              <asp:TableCell Width ="250">
                <div id="information">
                <asp:Label ID="info" runat="server" Text="" ForeColor="White"></asp:Label><br />
                </div>
              </asp:TableCell>
          </asp:TableRow>
        </asp:Table>
         <asp:Panel runat="server" ID="Panel_a" > <br />
             <asp:Label ID="error" runat="server" Text="" ForeColor ="Red" ></asp:Label>
        <asp:Table ID="Table1" CssClass="tabl" runat="server" GridLines="Both" BorderColor="White" ForeColor="White" BorderWidth="10">
           
        <asp:TableRow BorderWidth="10">
            <asp:TableCell Width="580" Height="300" BorderWidth="10">
               <div class="comp" id="section_lamp" runat="server" > <br />
               <asp:Label ID="Label1" runat="server" Text="Лампа"></asp:Label><br />
               <asp:Label ID="Label_lamp" runat="server" Text="Label"></asp:Label> <br />
               <div id="Div2" class="comp" runat="server" > <br />
               <asp:Button ID="Choose_lamp" runat="server" Text="выбрать лампу для управления" BackColor="White" BorderStyle="Outset" /><br />
              <asp:DropDownList ID="list_lamp" runat="server" Width="211" AutoPostBack="true" OnSelectedIndexChanged="Form_Menu_Equip" Visible="false"></asp:DropDownList>
               </div>
                </div> <br /><br />
                <div id="section_lamp2">
                <input id="button_menuL" class="top_button" type ="button" value="меню лампы" onclick ="hide_show('menu_lamp');"/>
                <div id="menu_lamp"  runat="server" style="display:none"><br />
                    <asp:RadioButtonList ID="RadioButtonLampOnOff" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ForISwich">
                        <asp:ListItem Value ="вкл"> </asp:ListItem>
                        <asp:ListItem Value ="выкл"> </asp:ListItem>
                    </asp:RadioButtonList>
                    </div>
               </div>
            </asp:TableCell>
            <asp:TableCell Width="580" Height="300">
                 <div id="section_heating" class="comp" runat="server"> <br />
                    <asp:Label ID="Label3" runat="server" Text="котел"></asp:Label> <br />
                    <asp:Label ID="Label_heating" runat="server" Text="Label"></asp:Label> <br />
                    <div id="Div3" class="comp" runat="server" > <br />
                    <asp:Button ID="Choose_heating" runat="server" Text="выбрать котел для управления" BackColor="White" BorderStyle="Outset" /><br />
                   <asp:DropDownList ID="list_heating" runat="server" Width="208" AutoPostBack="true" OnSelectedIndexChanged="Form_Menu_Equip" Visible="false"></asp:DropDownList>
                 </div>
                 </div> <br />
                <div id="section_heating2">
                <input id="button_menuH" class="top_button" type ="button" value="меню котла" onclick ="hide_show('menu_heating');"/>
                <div id="menu_heating" style="display:none" runat="server" ><br />
                    <asp:RadioButtonList ID="RadioButtonHeatingOnOff" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ForISwich">
                        <asp:ListItem Value ="вкл"> </asp:ListItem>
                        <asp:ListItem Value ="выкл"> </asp:ListItem>
                    </asp:RadioButtonList>
                    <asp:RadioButtonList ID="RadioButtonHeatingImode" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ForIMode"> 
                        <asp:ListItem Value ="режим Зима"> </asp:ListItem>
                        <asp:ListItem Value ="режим Лето"> </asp:ListItem>
                    </asp:RadioButtonList>
                    <asp:Button ID="heatTempPlus" runat="server" Text="t++" BorderWidth="2" BackColor="White"/><br />
                    <asp:Button ID="heatTempMin" runat="server" Text="t--  " BorderWidth="2" BackColor="White" /><br />
                    <asp:Label ID="setTemp" runat="server" Text="установить температуру"></asp:Label><br />
                    <asp:TextBox ID="boxSetHeating" runat="server"></asp:TextBox>
                    <asp:Button ID="buttonSetHeating" Width="173" runat="server" Text="установить" BorderWidth="2" BackColor="White"/>
               </div>
                    </div>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow BorderWidth ="10">
            <asp:TableCell Width="580" Height="300" BorderWidth="10">
                  <div id="section_split" class="comp" runat="server" > <br />
                 <asp:Label ID="Label5" runat="server"  Text="кондиционер"></asp:Label><br />
                 <asp:Label ID="Label_split" runat="server" Text="Label"></asp:Label><br />
                    <div id="Div1" class="comp" runat="server" > <br />
                    <asp:Button ID="Choose_split" runat="server" Text="выбрать кондиционер для управления" BackColor="White" BorderStyle="Outset" /><br />
                   <asp:DropDownList ID="list_splits" runat="server" Width="252" AutoPostBack="true" OnSelectedIndexChanged="Form_Menu_Equip" Visible="false"></asp:DropDownList>
                  </div>
                 </div> 
                <div id="section_split2">
               <input id="button_menuS" class="top_button" type ="button" value="меню кондиционера" onclick ="hide_show('menu_split');"/> 
                <div id="menu_split" style="display:none" runat="server"  ><br />
                     <asp:RadioButtonList ID="RadioButtonSplitOnOff" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ForISwich">
                        <asp:ListItem Value ="вкл"> </asp:ListItem>
                        <asp:ListItem Value ="выкл"> </asp:ListItem>
                    </asp:RadioButtonList>
                    <asp:RadioButtonList ID="RadioButtonSplitIMode" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ForIMode">
                        <asp:ListItem Value ="режим Зима"> </asp:ListItem>
                        <asp:ListItem Value ="режим Лето"> </asp:ListItem>
                    </asp:RadioButtonList>
                    <asp:Button ID="splitTempPlus" runat="server" Text="t++" BorderWidth="2" BackColor="White" /><br />
                    <asp:Button ID="splitTempMin" runat="server" Text="t--  " BorderWidth="2" BackColor="White"/><br />
                    <asp:Label ID="setTempsp" runat="server" Text="установить температуру"></asp:Label><br />
                    <asp:TextBox ID="boxSetSplit" runat="server"></asp:TextBox>
                    <asp:Button ID="buttonSetSplit" runat="server" Width="173" Text="установить" BorderWidth="2" BackColor="White"/>
                 </div>
                  </div>
            </asp:TableCell>
            <asp:TableCell Width="580" Height="300">
               <div id="section_kitch_hood" class="comp" runat="server" > <br />
                <asp:Label ID="Label7" runat="server" Text="вытяжка"></asp:Label><br />
               <asp:Label ID="Label_kitch_hood" runat="server" Text="Label"></asp:Label> <br />
               <div id="Div4" class="comp" runat="server" > <br />
                  <asp:Button ID="Choose_kitch_hood" runat="server" Text="выбрать вытяжку для управления" BackColor="White" BorderStyle="Outset" /><br />
                  <asp:DropDownList ID="list_kitch_hood" Width="226" runat="server" AutoPostBack="true" OnSelectedIndexChanged="Form_Menu_Equip" Visible="false"></asp:DropDownList>
                 </div>
               </div>
                <div id="section_kitch_hood2">
                <br /> <input id="button_menuKH" class="top_button" type ="button" value="меню вытяжки" onclick ="hide_show('menu_kitch_hood');"/> 
                <div id="menu_kitch_hood" style="display:none" runat="server" > <br />
                     <asp:RadioButtonList ID="RadioButtonKHOnOff" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ForISwich">
                        <asp:ListItem Value ="вкл"> </asp:ListItem>
                        <asp:ListItem Value ="выкл"> </asp:ListItem>
                    </asp:RadioButtonList>
                     <asp:RadioButtonList ID="RadioButtonKHMinMax" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ForIMinMax">
                         <asp:ListItem Value ="режим min"> </asp:ListItem>
                        <asp:ListItem Value ="режим norm"> </asp:ListItem>
                        <asp:ListItem Value ="режим max"> </asp:ListItem>
                     </asp:RadioButtonList>
                <asp:Panel ID="Panel_kh" runat="server" ForeColor="white"></asp:Panel>
                </div>
                </div>
          </asp:TableCell>
        </asp:TableRow>
            <asp:TableRow ID="cell_stove">
            <asp:TableCell ColumnSpan="2">
                <div id="section_stove" class="comp" runat="server" >   <br />
               <asp:Label ID="Label9" runat="server" Text="плита"></asp:Label><br />
               <asp:Label ID="Label_stove" runat="server" Text="Label"></asp:Label> <br />
               </div>
                <div id="section_stove2"  runat="server" ><br />
                <div id="Div5"  runat="server" > <br />
                   <asp:Button ID="Choose_stove" runat="server" Text="выбрать плиту для управления" BackColor="White" BorderStyle="Outset"/><br />
                   <asp:DropDownList ID="list_stove" Width="209" runat="server" AutoPostBack="true" OnSelectedIndexChanged="Form_Menu_Equip" Visible="false"></asp:DropDownList>
                 </div>
                <div id="stovOnOff">
                <br /> <input id="button_menuStov" class="top_button" type ="button" value="меню плиты" onclick ="hide_show('menu_stove');"/> 
                <div id="menu_stove" style="display:none" runat="server" > <br />
                     <asp:RadioButtonList ID="RadioButtonStoveOnOff" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ForISwich">
                        <asp:ListItem Value ="вкл"> </asp:ListItem>
                        <asp:ListItem Value ="выкл"> </asp:ListItem>
                    </asp:RadioButtonList>
                    </div>
                    </div>
                </div> <br /> <br />
                <div id ="section_stove3" runat="server">
                 <input id ="stov_equip2" class="top_button" type="button" value ="выбрать элемент управления плиты" onclick="hide_show('chois_stove_elem');"/> 
                  <div id ="chois_stove_elem" style ="display:none">
                    <asp:DropDownList ID="list_stove2" runat="server" Width="240" AutoPostBack ="true" OnSelectedIndexChanged="Form_Menu_Stove"> 
                        <asp:ListItem Value =""> </asp:ListItem>
                        <asp:ListItem Value ="topLeftBurner"> верхняя левая комфорка </asp:ListItem>
                        <asp:ListItem Value ="topRightBurner">верхняя правая комфорка </asp:ListItem>
                        <asp:ListItem Value ="buttomLeftBurner"> нижняя левая комфорка </asp:ListItem>
                        <asp:ListItem Value ="buttomRightBurner">нижняя правая комфрка </asp:ListItem>
                        <asp:ListItem Value ="oven">духовка</asp:ListItem>
                     </asp:DropDownList>
                </div>
                <div id ="burnertl" runat="server" visible ="false">
                 <asp:Label ID="Label2" runat="server" Text="управление комфоркой"></asp:Label>
                <asp:RadioButtonList ID="menu_burner" runat="server" AutoPostBack="true" OnSelectedIndexChanged="TopLeftBurnerISwitch">
                        <asp:ListItem Value ="вкл"> </asp:ListItem>
                        <asp:ListItem Value ="выкл"> </asp:ListItem>
                   </asp:RadioButtonList>
                     <asp:RadioButtonList ID="RadioButtonBurnerMinMax" runat="server" AutoPostBack="true" OnSelectedIndexChanged="TopLeftBurnerIMinMax">
                         <asp:ListItem Value ="режим min"> </asp:ListItem>
                        <asp:ListItem Value ="режим norm"> </asp:ListItem>
                        <asp:ListItem Value ="режим max"> </asp:ListItem>
                     </asp:RadioButtonList>
                </div>
                      <div id ="burnertr" runat="server" visible ="false">
                 <asp:Label ID="Label6" runat="server" Text="управление комфоркой"></asp:Label>
                <asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="true" OnSelectedIndexChanged="TopRigthBurnerISwitch">
                        <asp:ListItem Value ="вкл"> </asp:ListItem>
                        <asp:ListItem Value ="выкл"> </asp:ListItem>
                   </asp:RadioButtonList>
                     <asp:RadioButtonList ID="RadioButtonList2" runat="server" AutoPostBack="true" OnSelectedIndexChanged="TopRigthBurnerIMinMax">
                         <asp:ListItem Value ="режим min"> </asp:ListItem>
                        <asp:ListItem Value ="режим norm"> </asp:ListItem>
                        <asp:ListItem Value ="режим max"> </asp:ListItem>
                     </asp:RadioButtonList>
                </div>
                      <div id ="burnerbl" runat="server" visible ="false">
                 <asp:Label ID="Label8" runat="server" Text="управление комфоркой"></asp:Label>
                <asp:RadioButtonList ID="RadioButtonList3" runat="server" AutoPostBack="true" OnSelectedIndexChanged="BottLeftBurnerISwitch">
                        <asp:ListItem Value ="вкл"> </asp:ListItem>
                        <asp:ListItem Value ="выкл"> </asp:ListItem>
                   </asp:RadioButtonList>
                     <asp:RadioButtonList ID="RadioButtonList4" runat="server" AutoPostBack="true" OnSelectedIndexChanged="BotLeftBurnerIMinMax">
                         <asp:ListItem Value ="режим min"> </asp:ListItem>
                        <asp:ListItem Value ="режим norm"> </asp:ListItem>
                        <asp:ListItem Value ="режим max"> </asp:ListItem>
                     </asp:RadioButtonList>
                </div>
                      <div id ="burnerbr" runat="server" visible ="false">
                 <asp:Label ID="Label10" runat="server" Text="управление комфоркой"></asp:Label>
                <asp:RadioButtonList ID="RadioButtonList5" runat="server" AutoPostBack="true" OnSelectedIndexChanged="BotRigthBurnerISwitch">
                        <asp:ListItem Value ="вкл"> </asp:ListItem>
                        <asp:ListItem Value ="выкл"> </asp:ListItem>
                   </asp:RadioButtonList>
                     <asp:RadioButtonList ID="RadioButtonList6" runat="server" AutoPostBack="true" OnSelectedIndexChanged="BotRigthBurnerIMinMax"
                         >
                         <asp:ListItem Value ="режим min"> </asp:ListItem>
                        <asp:ListItem Value ="режим norm"> </asp:ListItem>
                        <asp:ListItem Value ="режим max"> </asp:ListItem>
                     </asp:RadioButtonList>
                </div>
                <div id="menu_oven" runat="server" visible="false">
                    <asp:Label ID="Label4" runat="server" Text="управление плитой"></asp:Label><br />
                    <asp:RadioButtonList ID="RadioButtonOvenSwitch" runat="server" AutoPostBack="true" OnSelectedIndexChanged="MenuForOvenISwitch">
                         <asp:ListItem Value ="вкл"> </asp:ListItem>
                        <asp:ListItem Value ="выкл"> </asp:ListItem>
                    </asp:RadioButtonList>
                    <asp:Button ID="ovenTempPlus" runat="server" Text="t++" BorderWidth="2" BackColor="White"/><br/>
                    <asp:Button ID="OvenTempMin" runat="server" Text="t--  " BorderWidth="2" BackColor="White" /><br />
                    <asp:Label ID="set_temp" runat="server" Text="установить температуру"></asp:Label><br />
                    <asp:TextBox ID="boxSetOven" runat="server"></asp:TextBox>
                    <asp:Button ID="button_set_oven" runat="server" Text="установить" BackColor="White" BorderWidth="2"/>
                    <asp:RadioButtonList ID="RadioButtonOvenRegime" runat="server" AutoPostBack="true" OnSelectedIndexChanged="MenuForOvenRegime">
                    <asp:ListItem Value ="режим 0"> </asp:ListItem>
                    <asp:ListItem Value ="класическое запекание"> </asp:ListItem>
                    <asp:ListItem Value ="вентилятор + запекание"> </asp:ListItem>
                    <asp:ListItem Value ="нижний подогрев"> </asp:ListItem>
                    <asp:ListItem Value ="гриль"> </asp:ListItem>
                    <asp:ListItem Value ="турбо гриль"> </asp:ListItem>
                    <asp:ListItem Value ="умный повар"> </asp:ListItem>
                    <asp:ListItem Value ="пицца"> </asp:ListItem>
                    </asp:RadioButtonList>
                    </div>
                    </div>
                 </asp:TableCell>
           
        </asp:TableRow>
        </asp:Table>
         </asp:Panel>
            
         
       </form>
</body>
</html>
