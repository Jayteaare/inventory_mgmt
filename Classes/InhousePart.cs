using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968_WGU_TallisJordan.Classes
{
    public class InHousePart : Part
    {
        public int MachineID { get; set; }

        public InHousePart() { }

        public InHousePart(int partID, string name, int inventory, decimal price, int min, int max, int machID = 0)
            : base(partID, name, inventory, price, min, max)
        {
            MachineID = machID;
        }
    }
}
