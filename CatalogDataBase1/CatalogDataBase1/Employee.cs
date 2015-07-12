using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogDataBase1
{
    [Serializable]
    public class Employee:GivingUniqueNumber
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string surName;

        public string SurName
        {
            get { return surName; }
            set { surName = value; }
        }
        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        private string profession;

        public string Profession
        {
            get { return profession; }
            set { profession = value; }
        }
        public Employee() { }
        public Employee(string name, string surName, int age, string profession):base()
        {
            ++My_iD;
            this.Name = name;
            this.SurName = surName;
            this.Age = age;
            this.Profession = profession;
        }
        public override string ToString()
        {
            return " Сотрудник: " + Name + " " + SurName +
           "\n занимаемая должность: " + Profession + "\n  возраст: " + Age + "\nID " + My_iD;
        }
    }
}
