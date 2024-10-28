using Microsoft.Extensions.Logging;

namespace InnoNum.Model.Services;

public class PerfectNumberService : IPerfectNumberService
{
    private readonly ILogger<PerfectNumberService> _logger;

    public PerfectNumberService(ILogger<PerfectNumberService> logger)
    {
        _logger = logger;
    }

    public PerfectNumberCount CountPerfectNumbersBetween(int minimum, int maximum)
    {
        if (minimum >= maximum)
        {
            _logger.LogError(
                "Invalid argument: {minimum} >= {maximum}",
                minimum, maximum);
            throw new ArgumentException(
                $"{nameof(minimum)} needs to be less than {nameof(maximum)}");
        }

        if (minimum <= 0 || maximum <= 0)
        {
            _logger.LogError(
                "One argument is <= 0: minimum: {minimum}, maximum: {maximum}",
                minimum, maximum);
            throw new ArgumentException(
                "all arguments need to be greater than 0");
        }

        var count = 0;

        for (var number = minimum; number < maximum; number++)
        {
            if (IsPerfectNumber(number))
            {
                count++;
            }
        }

        return new(count);
    }

    private bool IsProperDivisor(int number, int divisor)
    {
        return number % divisor == 0;
    }

    private int SumProperDivisors(int number)
    {
        var count = 0;
        for (var i = 1; i < number - 1; i++)
        {
            if (IsProperDivisor(number, i))
            {
                count += i;
            }
        }
        return count;
    }

    private bool IsPerfectNumber(int number)
    {
        return SumProperDivisors(number) == number;
    }
}
