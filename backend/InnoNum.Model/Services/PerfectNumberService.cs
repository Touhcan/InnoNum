namespace InnoNum.Model.Services;

public class PerfectNumberService : IPerfectNumberService
{
    public PerfectNumberCount CountPerfectNumbersBetween(int minimum, int maximum)
    {
        var count = 0;
        for (var number = minimum; number < maximum; number++)
        {
            var sum = 0;
            for (var divisor = 1; divisor < number - 1; divisor++)
            {
                if (number % divisor == 0)
                    sum += number;
            }
            if (sum == number)
                count++;
        }
        return new(count);
    }
}
