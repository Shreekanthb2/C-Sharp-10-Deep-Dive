using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_10_Deep_Dive.Source
{
    internal class NullParameterCheck
    {

        public string FormatName(string name!!)
        {
            return name;
        }

        public string StringifyCustomClass(Person customClass!!)
        {
            return $"{customClass.Id} - {customClass.Name}";
        }
    }
}
