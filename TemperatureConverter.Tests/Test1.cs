using TemperatureConverter.Lib;

namespace TemperatureConverter.Tests;

[TestClass]
public sealed class TemperatureUtilsTests
{
    [TestMethod]
    public void TestMethod1()
    {
        double Result1 = TemperatureUtils.CelsiusToFahrenheit(0);
        double Result2 = TemperatureUtils.CelsiusToFahrenheit(100);
        double Result3 = TemperatureUtils.CelsiusToFahrenheit(-40);
        Assert.AreEqual(32, Result1);
        Assert.AreEqual(212, Result2);
        Assert.AreEqual(-40, Result3);
    }
}
