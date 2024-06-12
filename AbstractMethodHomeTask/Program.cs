using AbstractMethodHomeTask;

Vehicle[] vehicles = new Vehicle[3];

vehicles[0] = new Car(2020, "Bentley", "Bentayga", 360)
{
    Color = "Red"
};

vehicles[1] = new Car(2019, "BMW", "M8", 400)
{
    Color = "Blue"
};

vehicles[2] = new Bus(2018, 50)
{
    Color = "Yellow"
};

foreach (var vehicle in vehicles)
{
    vehicle.ShowInfo();
}

