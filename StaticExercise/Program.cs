namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"52\u00b0 Fahrenheit is {TempConverter.FahrenheitToCelsius(52f):N1}\u00b0 Celsius");
            
            Console.WriteLine($"47\u00b0 Celsius is {TempConverter.CelsiusToFahrenheit(47):N1}\u00b0 Fahrenheit");
        }
    }
}
