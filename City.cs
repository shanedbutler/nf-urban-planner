namespace Planner
{
    public class City
    {
        private string _name;
        private int _yearEstablished;
        public string Mayor { get; set; }
        public List<Building> Buildings = new List<Building>();
        public City(string name)
        {
            this._name = name;
        }
        public void Establish()
        {
            this._yearEstablished = DateTime.Now.Year;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"\n----{this._name}----");
            Console.WriteLine($"Established {this._yearEstablished}");
            Console.WriteLine($"Current Mayor is {Mayor}");
        }
        public void AddBuilding(Building building)
        {
            this.Buildings.Add(building);
        }
        public void PrintBuildings()
        {
            Console.WriteLine($"\n{this._name} has {this.Buildings.Count} buildings:");

            foreach (Building building in this.Buildings)
            {
                building.PrintInfo();
            }
        }
    }
}
