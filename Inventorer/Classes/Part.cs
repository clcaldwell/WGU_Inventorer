using System;

namespace Inventorer
{
    public abstract class Part
    {
        // Private vars
        private int partID;
        private string name;
        private double price;
        private int quantity;
        private int min;
        private int max;

        public int PartID
        {
            get { return GetPartId(); }
            set { SetPartId(value); }
        }
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
        public virtual int MachineID { get; set; }
        public virtual string CompanyName { get; set; }

        public Part() {}
        public Part(string name, double price, int quantity, int min, int max)
            :this(Inventory.GetNextPartID(), name, price, quantity, min, max) { }

        public Part(int partID, string name, double price, int quantity, int min, int max)
        {
            PartID = partID;
            Name = name;
            Price = price;
            Quantity = quantity;
            Min = min;
            Max = max;
        }

        public void SetName(string name)
        {
            this.name = name;
        }
        public string GetName()
        {
            return name;
        }
        public void SetPrice(double price)
        {
            if (price <= 0)
            {
                throw new Exception("Price is zero or less");
            }
            this.price = price;
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
            if (max < min)
            {
                throw new Exception("Max is less than Min");
            }
            this.max = max;
        }
        public int GetMax()
        {
            return max;
        }
        public void SetPartId(int partID)
        {
            this.partID = partID;
        }
        public int GetPartId()
        {
            return partID;
        }
        public virtual int GetMachineID() { return 0; }
        public virtual string GetCompanyName() { return ""; }
    }
}
