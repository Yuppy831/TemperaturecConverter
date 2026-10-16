using TemperatureConverter.Lib;

double[] temperatures = {-20, 0, 20,100};
foreach (double temperature in temperatures)
{
    Console.WriteLine($"до изменения:{temperature} C, после изменения:{TemperatureUtils.CelsiusToFahrenheit(temperature)}");
}

