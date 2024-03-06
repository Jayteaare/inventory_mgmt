using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968_WGU_TallisJordan.Classes
{
    public class Product
    {
        public BindingList<Part> AssociatedParts { get; private set; } = new BindingList<Part>();
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

        public Product() { }

        public Product(int prodID, string name, int inventory, decimal price, int min, int max)
        {
            ID = prodID;
            Name = name;
            Inventory = inventory;
            _price = price;
            Min = min;
            Max = max;
        }

        public void AddAssociatedPart(Part part)
        {
            AssociatedParts.Add(part);
        }

        public bool RemoveAssociatedPart(int partID)
        {
            var part = AssociatedParts.FirstOrDefault(p => p.ID == partID);
            if (part != null)
            {
                AssociatedParts.Remove(part);
                return true;
            }
            return false;
        }

        public Part LookupAssociatedPart(int partID)
        {
            return AssociatedParts.FirstOrDefault(p => p.ID == partID) ?? new InHousePart();
        }
    }
}
