using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968_WGU_TallisJordan.Classes
{
    public class OutsourcedPart : Part
    {
        public string CompName { get; set; }

        public OutsourcedPart() { }

        public OutsourcedPart(int partID, string name, int inventory, decimal price, int min, int max, string compName = "")
            : base(partID, name, inventory, price, min, max)
        {
            CompName = compName;
        }
    }
}
