using System;

class RemoteControlCar
{
    public int distanceDriven = 0;
    public int batteryCharge = 100;

    public static RemoteControlCar Buy()
    {
        RemoteControlCar car = new RemoteControlCar();
        return car;
    }

    public string DistanceDisplay()
    {
        return $"Driven {distanceDriven} meters";
    }

    public string BatteryDisplay()
    {
        if (batteryCharge > 0)
        {
            return $"Battery at {batteryCharge}%";
        }
        return "Battery empty";
    }

    public void Drive()
    {
        if (distanceDriven < 2000)
        {
            distanceDriven += 20;
        }
        if (batteryCharge > 0)
        {
            batteryCharge -= 1;
        }
    }
}
