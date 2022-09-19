namespace Planner
{
    public class Building
    {
        private string _designer = "Shane";
        private DateTime _dateConstructed;
        private string _address;
        private string _owner;

        public int Stories { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }
        public double Volume { get => Width * Depth; }

        public Building(string address)
        {
            this._address = address;
        }

        public void Construct()
        {
            this._dateConstructed = DateTime.Now;
        }
        public void Purchase(string name)
        {
            this._owner = name;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"\n{_address}");
            Console.WriteLine("------------------");
            Console.WriteLine($"Designed by {_designer}");
            Console.WriteLine($"Constructed on {_dateConstructed}");
            Console.WriteLine($"Owned by {_owner}");
            Console.WriteLine($"{Volume} cubic meters of space");
        }
    }
}