using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogDataBase1
{
    class MainMenu
    {
        private ISerialize sr;
        public ISerialize Sr
        {
            get { return sr; }
            set { sr = value; }
        }
        private List<Employee> emp;
        public List<Employee> Emp
        {
            get { return emp; }
            set { emp = value; }
        }

        public MainMenu() { }
        public MainMenu(ISerialize sr)
        {
            this.Sr = sr;
            this.Emp = Sr.DeserializeObj();
        }

        public void ShowMainManu()
        {
            while (true)
            {
             try
                {
                Console.Clear();
                string a = "Base with staff 'Green Planet'";
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("\n" + a.ToUpper() + "\n\n");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("1. Add to the base a new employee");
                Console.WriteLine("2. View employee data ");
                Console.WriteLine("3. View the entire database");
                Console.WriteLine("4. Remove from the base");
                Console.WriteLine("5. Exit");
                char b = Console.ReadKey().KeyChar;
                switch (b)
                {
                    case '1':
                        Emp.Add(RegistrationEmployee());
                        Console.WriteLine("Entry is added! Click 'ENTER' to continue");
                        Console.ReadKey();
                        break;
                    case '2':
                        try
                        {
                            ShowEmployee();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        Console.ReadKey();
                        break;
                    case '3':
                        ShowAllList();
                        Console.ReadKey();
                        break;
                    case '4':
                        Delating();
                        Console.WriteLine("Employee removed");
                        Console.ReadKey();
                        break;
                    case '5':
                        Sr.SerializeObj(Emp);
                        Environment.Exit(0);
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Uncorrect command. Please, try again");
                        break;
                }
             }
                catch(FormatException e)
             {
                 Console.WriteLine(e.Message);
             }
       }
    }

        public void ShowAllList()
        {
            foreach (Employee p in Emp)
            {
                Console.WriteLine(p.ToString());
            }
        }

        public void ShowEmployee()
        {
            Console.WriteLine(" Enter ID employee ");
            int tmp = Int32.Parse(Console.ReadLine());

            if (Emp.Exists(i => i.My_iD == tmp))
            {
                Employee e = Emp.Find(i => i.My_iD == tmp);
                Console.WriteLine(e.ToString());
            }
            else
            {
                throw new Exception("Mistake: employee with such ID does not exist");
            }
        }

        public void Delating()
        {
            Console.WriteLine(" enter ID employee ");
            int tmp = Int32.Parse(Console.ReadLine());

            if (Emp.Exists(i => i.My_iD == tmp))

            {
                Employee e = Emp.Find(i => i.My_iD == tmp);
                Emp.Remove(e);
            }
            else
            {
                Console.WriteLine(" Mistake: employee with such ID does not exist");
                Console.ReadKey();
                ShowMainManu();
            }
        }
        public Employee RegistrationEmployee()
        {
                int age;
                Console.WriteLine("\nEnter name of employee");
                string strName= Console.ReadLine();
                Console.WriteLine("Enter surname of employee");
                string surName = Console.ReadLine();
                Console.WriteLine("Enter age of employee");
                string tmp = Console.ReadLine();
                if(Int32.TryParse(tmp, out age))
                {
                    age = Int32.Parse(tmp);
                }
                else
                {
                    Console.WriteLine("Uncorrect data of age");
                    Console.ReadKey();
                    ShowMainManu();
                }
                Console.WriteLine("Enter position held of employee");
                string prof = Console.ReadLine();
                Employee obj = new Employee();
                obj.Name = strName;
                obj.SurName = surName;
                obj.Age = age;
                obj.Profession = prof;
                return obj;
            }
        }
    }
