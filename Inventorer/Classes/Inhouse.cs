namespace Inventorer
{
    public class Inhouse : Part
    {
        private int machineID;
        public override int MachineID
        {
            get
            {
                return GetMachineID();
            }
            set
            {
                SetMachineID(value);
            }
        }

        public Inhouse() {}
        public Inhouse(string name, double Price, int quantity, int min, int max, int machineID)
            : base(name, Price, quantity, min, max)
        {   
            MachineID = machineID;
        }
        public Inhouse(int partID, string name, double Price, int quantity, int min, int max, int machineID)
            : base(partID, name, Price, quantity, min, max)
        {
            MachineID = machineID;
        }

        public void SetMachineID(int machineID)
        {
            this.machineID = machineID;
        }
        public override int GetMachineID()
        {
            return machineID;
        }

    }
}
