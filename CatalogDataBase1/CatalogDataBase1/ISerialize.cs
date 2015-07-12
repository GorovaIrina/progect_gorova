using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogDataBase1
{
    interface ISerialize
    {
        void SerializeObj(object obj);
        List<Employee> DeserializeObj();
    }
}
