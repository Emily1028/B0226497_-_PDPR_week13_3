using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B0226497_段昱如_PDPR_week13_3
{
    class PERSON
    {
        protected int ID { set; get; }
        protected string NAME { set; get; }
        public int getID()
        {
            return ID;
        }
        public string getNAME()
        {
            return NAME;
        }
    }
}
