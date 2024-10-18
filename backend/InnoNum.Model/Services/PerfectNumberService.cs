namespace InnoNum.Model.Services;

public class PerfectNumberService : IPerfectNumberService
{
    public PerfectNumberCount CountPerfectNumbersBetween(int minimum, int maximum)
    {
        return new(0);
    }
}
