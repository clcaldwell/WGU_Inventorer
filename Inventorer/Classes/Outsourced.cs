namespace Inventorer
{
    public class Outsourced : Part
    {
        private string companyName;
        public override string CompanyName
        {
            get
            {
                return GetCompanyName();
            }
            set
            {
                SetCompanyName(value);
            }
        }

        public Outsourced(string name, double Price, int quantity, int min, int max, string companyName)
            : base(name, Price, quantity, min, max)
        {
            CompanyName = companyName;
        }
        public Outsourced(int partID, string name, double Price, int quantity, int min, int max, string companyName)
            : base(partID, name, Price, quantity, min, max)
        {
            CompanyName = companyName;
        }

        public void SetCompanyName(string companyName)
        {
            this.companyName = companyName;
        }
        public override string GetCompanyName()
        {
            return companyName;
        }
    }
}
