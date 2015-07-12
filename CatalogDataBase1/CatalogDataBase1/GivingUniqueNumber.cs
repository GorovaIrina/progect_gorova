using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogDataBase1
{
    [Serializable]
  public abstract class GivingUniqueNumber
    {

        private  int my_iD;
        public int My_iD
        {
            get 
            {
                return my_iD;
            }
            set
            {
                my_iD = value;
            }
        }
        public static int currentID;
        
        static int GetNextId()
        {
            return ++currentID;
        }
       
       static GivingUniqueNumber()
        {
            currentID = 0;
        }
        public GivingUniqueNumber()
        {
            this.My_iD = GetNextId();
        }
    }
}
