namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            City Fantatatown = new City("Fantatatown");
            Fantatatown.Mayor = "Claire";
            Fantatatown.Establish();

            Building FifteenTenWest = new Building("1510 West Avenue")
            {
                Stories = 3,
                Width = 150,
                Depth = 200
            };

            FifteenTenWest.Construct();
            FifteenTenWest.Purchase("Diego");
            Fantatatown.AddBuilding(FifteenTenWest);

            Building OneZeroThreeGates = new Building("103 Gates Ave")
            {
                Stories = 4,
                Width = 75,
                Depth = 125
            };
            
            OneZeroThreeGates.Construct();
            OneZeroThreeGates.Purchase("Fernando");
            Fantatatown.AddBuilding(OneZeroThreeGates);

            Fantatatown.PrintInfo();
            Fantatatown.PrintBuildings();
        }
    }
}
