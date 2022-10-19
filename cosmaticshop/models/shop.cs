using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cosmaticshop.models
{
    public class shop
    {
        //[jsonpropertyname(anthing)]
        public int id { get; set; }

        //[jsonpropertyname(anthing)]
        public int name { get; set; }

        //[jsonpropertyname(anthing)]
        public int image { get; set; }


        //convert all data into string format (json string)

        public override string ToString()
        {
         //   return base.ToString(); by default
        //  return jsonserializer.serialize<shop>(this)    for converting into json format string
        }
    }
}
