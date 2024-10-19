using Moq;
using Microsoft.Extensions.Logging;
using InnoNum.Model;
using InnoNum.Model.Services;

namespace InnoNum.UnitTests;

public class PerfectNumberServiceUnitTest
{
    [Fact]
    public void Test()
    {
        var mock = new Mock<ILogger<PerfectNumberService>>();
        var logger = mock.Object;

        var service = new PerfectNumberService(logger);
        var expected = new PerfectNumberCount(1);
        Assert.Equal(expected, service.CountPerfectNumbersBetween(1, 10));
    }
}

