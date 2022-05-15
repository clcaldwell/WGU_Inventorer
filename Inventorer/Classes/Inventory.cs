using System;
using System.Collections.Generic;
using System.Linq;

namespace Inventorer
{
    public class Inventory
    {
        public static List<Product> Products = new List<Product>();
        public static List<Part> AllParts = new List<Part>();

        private static int nextPartID = 0;
        private static int nextProductID = 0;

        public static int GetNextPartID()
        {
            return nextPartID++;
        }
        public static int GetNextProductID()
        {
            return nextProductID++;
        }

        // Part methods
        public static Part FindPart(int partID)
        {
            foreach (Part part in AllParts)
            {
                if (part.GetPartId() == partID)
                {
                    return part;
                }
            }
            return null;
        }
        public static void AddPart(Part part)
        {
            AllParts.Add(part);
        }
        public static void ModPart(int partID, Part replacement)
        {
            Part oldPart = AllParts.Where(i => i.PartID == partID).First();
            var index = AllParts.IndexOf(oldPart);

            if (index != -1)
                AllParts[index] = replacement;

            oldPart = replacement;

        }
        public static bool DelPart(Part part)
        {
            try
            {
                AllParts.Remove(FindPart(part.GetPartId()));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // Product methods
        public static Product FindProduct(int productID)
        {
            foreach (Product product in Products)
            {
                if (product.GetProductID() == productID)
                {
                    return product;
                }
            }
            return null;
        }
        public static void AddProduct(Product product)
        {
            Products.Add(product);
        }
        public static void ModProduct(int productID, Product replacement)
        {
            Product oldProduct = Products.Where(i => i.ProductID == productID).First();
            var index = Products.IndexOf(oldProduct);

            if (index != -1)
                Products[index] = replacement;

            oldProduct = replacement;
        }
        public static bool DelProduct(int productID)
        {
            try
            {
                Products.Remove(FindProduct(productID));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

    }
}
