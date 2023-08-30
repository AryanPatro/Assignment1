using Assignment1_C__basics_;

SportsCar car = new SportsCar();
car.Model = "Corvette";
car.Make = "Chevrolet";
car.Color = "Red";
car.NumberofDoors = 2;
car.NumberofSeats = 2;
car.TestDrive(100);


Console.WriteLine("");

Suv suv = new Suv();
suv.Model = "Explorer";
suv.Make = "Ford";
suv.Color = "White";
suv.NumberofDoors = 4;
suv.NumberofSeats = 6;
// Calls overridden methods

Car[] vehicles = { car, suv };
foreach (Car c in vehicles)
{
    Console.WriteLine("State:");
    c.StartEngine(); // Calls correct override

    Console.WriteLine("");

    Console.WriteLine("Details of the vehicle:");
    c.DisplayDetails(); // Calls correct override'

    c.TestDrive(100);
    
}



