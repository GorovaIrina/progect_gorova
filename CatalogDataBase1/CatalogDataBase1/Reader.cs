using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogDataBase1
{
    class Reader
    {
        private static string path = "option.ini";
        public static void ReadPath()
        {
        try
                {
                    string tmp;
                    using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
                    {
                        tmp = sr.ReadToEnd().ToUpper().Trim();
                    }
                  
                    if (tmp == "BIN")
                    {
                        BinarySerialise bs = new BinarySerialise();
                        MainMenu mm = new MainMenu(bs);
                        mm.ShowMainManu();
                    }
                    else if (tmp == "XML")
                    {
                        XMLSerialize xs = new XMLSerialize();
                        MainMenu mm = new MainMenu(xs);
                        mm.ShowMainManu();
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Mistake " +e.Message); 
                }
          }
      }
}
