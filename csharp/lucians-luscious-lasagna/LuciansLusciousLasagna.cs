class Lasagna
{

    public int ExpectedMinutesInOven()
    {
        return 40;
    }

    public int RemainingMinutesInOven(int timeElapsed)
    {
        return ExpectedMinutesInOven() - timeElapsed;
    }

    public int PreparationTimeInMinutes(int layers)
    {
        return layers * 2;
    }

    public int ElapsedTimeInMinutes(int layers, int timeElapsed)
    {
        return PreparationTimeInMinutes(layers) + timeElapsed;
    }
    // TODO: define the 'ElapsedTimeInMinutes()' method
}
