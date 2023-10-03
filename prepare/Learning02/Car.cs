using System;

public class Car
{ 
    public string _make;
    public string _model;
    public int _mileage;
    public int _gallonsOfFuel;

    public Owner owner;

    public int RemainingMiles()
    {
        return _gallonsOfFuel * _mileage;
    }

    public void ReduceFuel(int amount)
    {
        _gallonsOfFuel = _gallonsOfFuel - amount;
    }
}