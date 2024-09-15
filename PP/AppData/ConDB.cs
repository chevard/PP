using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP.AppData
{
    internal class ConDB
    {
        public static school5Entities2 c;
        public static school5Entities2 context
        {
            get
            {
                if(c==null)
                c = new school5Entities2 ();
                return c;
            }
        }

    }
}
