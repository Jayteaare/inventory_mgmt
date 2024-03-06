using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968_WGU_TallisJordan.Classes
{
    public abstract class Part
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Inventory { get; set; }

        private decimal _price;
        public decimal Price
        {
            get => _price;
            set => _price = value;
        }
        public int Min { get; set; }
        public int Max { get; set; }

        protected Part(int partID, string name, int inventory, decimal price, int min, int max)
        {
            ID = partID;
            Name = name;
            Inventory = inventory;
            _price = price;
            Min = min;
            Max = max;
        }

        protected Part() { }

    }
}