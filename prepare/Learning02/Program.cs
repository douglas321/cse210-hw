using System;

class Program
{
    static void Main(string[] args)
    {
    
        var car1 = new Car();
        car1._make = "Honda";
        car1._model = "Civic";
        car1._mileage = 23;
        car1._gallonsOfFuel = 10;
        car1.owner = new Owner();
        car1.owner._name = "Bob";
        car1.owner._phoneNumber = "123-123-1231";

        car1.ReduceFuel(4);

        var miles = car1.RemainingMiles;

        var cars = new List<Car>();
        cars.Add(car1);

        
    }
}

public class Owner
{
    public string _name;
    public string _phoneNumber;
}
