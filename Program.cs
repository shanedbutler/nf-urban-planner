namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            City Fantatatown = new City("Fantatatown");
            Fantatatown.Mayor = "Claire";
            Fantatatown.Establish();

            Building FifteenTenWest = new Building("1510 West Avenue");
            FifteenTenWest.Stories = 3;
            FifteenTenWest.Width = 150;
            FifteenTenWest.Depth = 200;
            FifteenTenWest.Construct();
            FifteenTenWest.Purchase("Diego");
            Fantatatown.AddBuilding(FifteenTenWest);

            Building OneZeroThreeGates = new Building ("103 Gates Ave");
            OneZeroThreeGates.Stories = 4;
            OneZeroThreeGates.Width = 75;
            OneZeroThreeGates.Depth = 125;
            OneZeroThreeGates.Construct();
            OneZeroThreeGates.Purchase("Fernando");
            Fantatatown.AddBuilding(OneZeroThreeGates);

            Fantatatown.PrintInfo();
            Fantatatown.PrintBuildings();
        }
    }
}
