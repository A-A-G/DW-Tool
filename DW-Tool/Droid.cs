namespace DW
{
    public class Droid
    {
        private string name;
        private int attValue;
        private int defValue;
        private int pvgValue;

        public Droid(string name, int attValue, int defValue, int pvgValue)
        {
            this.name = name;
            this.attValue = attValue;
            this.defValue = defValue;
            this.pvgValue = pvgValue;
        }

        public string Name
        {
            get { return name; }
        }

        public int AttValue
        {
            get { return attValue; }
        }

        public int DefValue
        {
            get { return defValue; }
        }

        public int PVGValue
        {
            get { return pvgValue; }
        }
    }
}
