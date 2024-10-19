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
        var count = 0;
        for (var number = minimum; number < maximum; number++)
        {
            using (_logger.BeginScope("Current number: {number}", number))
            {
                var sum = 0;
                for (var divisor = 1; divisor < number - 1; divisor++)
                {
                    if (number % divisor == 0)
                    {
                        _logger.LogInformation("Found correct divisor: {divisor}", divisor);
                        sum += divisor;
                    }
                }
                if (sum == number)
                {
                    _logger.LogInformation("Number is perfect (sum: {sum})", sum);
                    count++;
                }
            }
        }
        return new(count);
    }
}
