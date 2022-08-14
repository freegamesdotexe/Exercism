using System;

static class AssemblyLine
{
    public static double SuccessRate(int speed)
    {
        if (speed > 0 && speed < 5)
        {
            return 1;
        }
        else if (speed > 4 && speed < 9)
        {
            return 0.9;
        }
        else if (speed == 9)
        {
            return 0.8;
        }
        else if (speed == 10)
        {
            return 0.77;
        }

        return 0;
    }
    
    public static double ProductionRatePerHour(int speed)
    {
        return speed * 221 * SuccessRate(speed);
    }

    public static int WorkingItemsPerMinute(int speed)
    {
        return (int)Math.Floor(ProductionRatePerHour(speed) / 60);
    }
}
