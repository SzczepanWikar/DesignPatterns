using Builder;

var carFromConstructor = new Car("Ford", "Focus", 2005, FuelType.Diesel, 1500, false, "Blue", 100, null, null, 4);
carFromConstructor.DisplayInfo();

Console.WriteLine();

var carFromBuilder = new CarBuilder()
            .SetMake("Toyota")
            .SetModel("Camry")
            .SetYear(2022)
            .SetFuelType(FuelType.Gas)
            .SetEngineCapacity(2000)
            .SetHasDaytimeRunningLights(true)
            .SetColour("Blue")
            .SetHorsepower(203)
            .SetCupHoldersNumber(4)
            .Build();

carFromBuilder.DisplayInfo();