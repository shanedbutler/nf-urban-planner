namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            Building FifteenTenWest = new Building("1510 West Avenue");
            FifteenTenWest.Stories = 3;
            FifteenTenWest.Width = 150;
            FifteenTenWest.Depth = 200;
            FifteenTenWest.Construct();
            FifteenTenWest.Purchase("Diego");
            FifteenTenWest.PrintInfo();

            Building OneZeroThreeGates = new Building ("103 Gates Ave");
            OneZeroThreeGates.Stories = 4;
            OneZeroThreeGates.Width = 75;
            OneZeroThreeGates.Depth = 125;
            OneZeroThreeGates.Construct();
            OneZeroThreeGates.Purchase("Fernando");
            OneZeroThreeGates.PrintInfo();
        }
    }
}
