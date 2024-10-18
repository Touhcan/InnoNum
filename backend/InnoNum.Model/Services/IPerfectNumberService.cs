namespace InnoNum.Model.Services;

public interface IPerfectNumberService
{
    PerfectNumberCount CountPerfectNumbersBetween(int minimum, int maximum);
}
