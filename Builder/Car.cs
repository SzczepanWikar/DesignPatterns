namespace Builder
{
    internal class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public FuelType FuelType { get; set; }
        public int EngineCapacity { get; set; }
        public bool HasDaytimeRunningLights { get; set; }
        public string Colour { get; set; }
        public int Horsepower { get; set; }
        public int? TrunkCapacity { get; set; }
        public int? AirConditionerAreasNumber { get; set; }
        public int? CupHoldersNumber { get; set; }

        public Car()
        {
        }

        public Car(
            string make,
            string model,
            int year,
            FuelType fuelType,
            int engineCapacity,
            bool hasDaytimeRunningLights,
            string colour,
            int horsePower,
            int? trunkCapacity,
            int? airConditionerAreasNumber,
            int? cupHoldersNumber
        )
        {
            Make = make;
            Model = model;
            Year = year;
            FuelType = fuelType;
            EngineCapacity = engineCapacity;
            HasDaytimeRunningLights = hasDaytimeRunningLights;
            Colour = colour;
            Horsepower = horsePower;
            TrunkCapacity = trunkCapacity;
            AirConditionerAreasNumber = airConditionerAreasNumber;
            CupHoldersNumber = cupHoldersNumber;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Make: {Make}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Year: {Year}");
            Console.WriteLine($"Fuel Type: {FuelType}");
            Console.WriteLine($"Engine Capacity: {EngineCapacity}");
            Console.WriteLine($"Daytime Running Lights: {(HasDaytimeRunningLights ? "Yes" : "No")}");
            Console.WriteLine($"Colour: {Colour}");
            Console.WriteLine($"Horsepower: {Horsepower}");
            if (TrunkCapacity.HasValue)
                Console.WriteLine($"Trunk Capacity: {TrunkCapacity}");
            if (AirConditionerAreasNumber.HasValue)
                Console.WriteLine($"Air Conditioner Areas Number: {AirConditionerAreasNumber}");
            if (CupHoldersNumber.HasValue)
                Console.WriteLine($"Cup Holders Number: {CupHoldersNumber}");
        }
    }
}
