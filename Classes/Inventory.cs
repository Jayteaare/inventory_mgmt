using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968_WGU_TallisJordan.Classes
{
    class Inventory
    {
        public static BindingList<Product> Products { get; private set; } = new BindingList<Product>();
        public static BindingList<Part> Parts { get; private set; } = new BindingList<Part>();

        public static void InitializePresetParts()
        {
            AddPart(new InHousePart(1, "Spindel", 10, 10.99m, 5, 50, 1000));
            AddPart(new OutsourcedPart(2, "Wheel", 20, 20.99m, 4, 100, "WGU"));
            AddPart(new InHousePart(3, "Gear", 15, 15.50m, 3, 80, 1001));
            AddPart(new OutsourcedPart(4, "Belt", 30, 5.75m, 10, 200, "TechCorp"));
            AddPart(new InHousePart(5, "Bearing", 25, 7.99m, 2, 90, 1002));
            AddPart(new OutsourcedPart(6, "Rotor", 5, 45.99m, 1, 40, "AutoParts"));
        }

        public static void InitializePresetProducts()
        {
            Product product1 = new Product(1, "Engine", 5, 250.99m, 1, 10);
            product1.AddAssociatedPart(LookupPart(1));
            product1.AddAssociatedPart(LookupPart(3));
            AddProduct(product1);

            Product product2 = new Product(2, "Transmission", 3, 125.55m, 1, 5);
            product2.AddAssociatedPart(LookupPart(2));
            product2.AddAssociatedPart(LookupPart(4));
            AddProduct(product2);

            Product product3 = new Product(3, "Suspension Kit", 4, 300.40m, 1, 8);
            product3.AddAssociatedPart(LookupPart(5));
            product3.AddAssociatedPart(LookupPart(6));
            AddProduct(product3);
        }

        public static void AddPart(Part part)
        {
            Parts.Add(part);
        }

        public static Part LookupPart(int partID)
        {
            return Parts.FirstOrDefault(p => p.ID == partID) ?? new InHousePart();
        }

        public static void UpdatePart(int partID, Part updatedPart)
        {
            var part = Parts.FirstOrDefault(p => p.ID == partID);
            if (part != null)
            {
                int partIndex = Parts.IndexOf(part);
                Parts[partIndex] = updatedPart;
            }
        }

        public static bool DeletePart(int partID)
        {
            var part = Parts.FirstOrDefault(p => p.ID == partID);
            if (part != null)
            {
                Parts.Remove(part);
                return true;
            }
            return false;
        }

        public static void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public static Product LookupProduct(int productID)
        {
            return Products.FirstOrDefault(p => p.ID == productID) ?? new Product();
        }

        public static void UpdateProduct(int productID, Product updatedProduct)
        {
            var currentProduct = Products.FirstOrDefault(p => p.ID == productID);
            if (currentProduct != null)
            {
                currentProduct.Name = updatedProduct.Name;
                currentProduct.Inventory = updatedProduct.Inventory;
                currentProduct.Price = updatedProduct.Price;
                currentProduct.Min = updatedProduct.Min;
                currentProduct.Max = updatedProduct.Max;

                currentProduct.AssociatedParts.Clear();
                foreach (var part in updatedProduct.AssociatedParts)
                {
                    currentProduct.AssociatedParts.Add(part);
                }
            }
        }

        public static bool DeleteProduct(int productID)
        {
            var product = Products.FirstOrDefault(p => p.ID == productID);
            if (product != null)
            {
                Products.Remove(product);
                return true;
            }
            return false;
        }
        public static int GetNextPartId()
        {
            return Parts.Count == 0 ? 1 : Parts.Max(p => p.ID) + 1;
        }
        public static int GetNextProductId()
        {
            return Products.Count == 0 ? 1 : Products.Max(p => p.ID) + 1;
        }
    }
}
