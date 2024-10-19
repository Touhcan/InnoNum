using Moq;
using Microsoft.Extensions.Logging;
using InnoNum.Model;
using InnoNum.Model.Services;

namespace InnoNum.UnitTests;

public class PerfectNumberServiceUnitTest
{
    private readonly PerfectNumberService _service;

    public PerfectNumberServiceUnitTest()
    {
        var mock = new Mock<ILogger<PerfectNumberService>>();
        var logger = mock.Object;
        _service = new(logger);
    }

    [Fact]
    public void PerfectNumberCountingWorks()
    {
        var expected = new PerfectNumberCount(1);
        var actual = _service.CountPerfectNumbersBetween(1, 10);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void MinimumNeedsToBeLessThanMaximum()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() =>
            _service.CountPerfectNumbersBetween(10, 1));
    }

    [Fact]
    public void AllArgumentsNeedToBeGreaterThanZero()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() =>
            _service.CountPerfectNumbersBetween(-10, 0));
    }
}

