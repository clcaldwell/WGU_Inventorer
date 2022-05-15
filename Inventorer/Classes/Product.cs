using System;
using System.Collections;

namespace Inventorer
{
    public class Product
    {
        private readonly ArrayList associatedParts;
        private int productID;
        public int ProductID
        {
            get
            {
                return GetProductID();
            }
            set
            {
                SetProductID(value);
            }
        }
        private string name;
        public string Name {
            get
            {
                return GetName();
            }
            set
            {
                SetName(value);
            }
        }
        private double price;
        public double Price {
            get
            {
                return GetPrice();
            }
            set
            {
                SetPrice(value);
            }
        }
        private int quantity;
        public int Quantity {
            get
            {
                return GetQuantity();
            }
            set
            {
                SetQuantity(value);
            }
        }
        private int min;
        public int Min {
            get
            {
                return GetMin();
            }
            set
            {
                SetMin(value);
            }
        }
        private int max;
        public int Max {
            get
            {
                return GetMax();
            }
            set
            {
                SetMax(value);
            }
        }

        public Product(string name, double Price, int quantity, int min, int  max, ArrayList associatedParts)
            : this(Inventory.GetNextProductID(), name, Price, quantity, min, max, associatedParts) { }

        public Product(int productID, string name, double Price, int quantity, int min, int max)
        {
            associatedParts = new ArrayList();
            ProductID = productID;
            Name = name;
            Price = Price;
            Quantity = quantity;
            Min = min;
            Max = max;
        }
        public Product(int productID, string name, double Price, int quantity, int min, int max, ArrayList associatedParts)
            :this(productID, name, Price, quantity, min, max)
        {
            this.associatedParts = associatedParts;
        }


        public void SetName(string name)
        {
            this.name = name;
        }
        public string GetName()
        {
            return name;
        }
        public void SetPrice(double Price)
        {
            if (Price <= 0)
            {
                throw new Exception("Price is zero or less");
            }
            this.Price = Price;
        }
        public double GetPrice()
        {
            return price;
        }
        public void SetQuantity(int quantity)
        {
            this.quantity = quantity;
        }
        public int GetQuantity()
        {
            return quantity;
        }
        public void SetMin(int min)
        {
            this.min = min;
        }
        public int GetMin()
        {
            return min;
        }
        public void SetMax(int max)
        {
            if (max < min) {
                throw new Exception("Max is less than min");
            }
            this.max = max;
        }
        public int GetMax()
        {
            return max;
        }
        public void SetProductID(int productID)
        {
            this.productID = productID;
        }
        public int GetProductID()
        {
            return productID;
        }
        public ArrayList GetAssociatedParts()
        {
            return associatedParts;
        }
        public void AddAssociatedPart(Part part)
        {
            associatedParts.Add(part);
        }
        public bool 
            AssociatedPart(int partID)
        {
            try
            {
                associatedParts.Remove(LookupAssociatedPart(partID));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public Part LookupAssociatedPart(int partID)
        {
            foreach (Part part in associatedParts)
            {
                if (part.GetPartId() == partID)
                {
                    return part;
                }
            }
            return null;
        }
    }
}
