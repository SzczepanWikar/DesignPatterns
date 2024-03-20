namespace Builder
{
    internal class CarBuilder
    {
        private Car _car = new Car();


        public CarBuilder SetMake(string make)
        {
            _car.Make = make;  
            return this;
        }

        public CarBuilder SetModel(string model)
        {
            _car.Model = model;
            return this;
        }

        public CarBuilder SetYear(int year)
        {
            _car.Year = year;
            return this;
        }

        public CarBuilder SetFuelType(FuelType fuelType)
        {
            _car.FuelType = fuelType;
            return this;
        }

        public CarBuilder SetEngineCapacity(int engineCapacity)
        {
            _car.EngineCapacity = engineCapacity;
            return this;
        }

        public CarBuilder SetHasDaytimeRunningLights(bool hasDaytimeRunningLights)
        {
            _car.HasDaytimeRunningLights = hasDaytimeRunningLights;
            return this;
        }

        public CarBuilder SetColour(string colour)
        {
            _car.Colour = colour;
            return this;
        }

        public CarBuilder SetHorsepower(int horsepower)
        {
            _car.Horsepower = horsepower;
            return this;
        }

        public CarBuilder SetTrunkCapacity(int? trunkCapacity)
        {
            _car.TrunkCapacity = trunkCapacity;
            return this;
        }

        public CarBuilder SetAirConditionerAreasNumber(int? airConditionerAreasNumber)
        {
            _car.AirConditionerAreasNumber = airConditionerAreasNumber;
            return this;
        }

        public CarBuilder SetCupHoldersNumber(int? cupHoldersNumber)
        {
            _car.CupHoldersNumber = cupHoldersNumber;
            return this;
        }

        public Car Build()
        {
            // Tutaj można dodać logikę weryfikującą poprawność konstrukcji obiektu
            return _car;
        }
    }
}
