namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //            Create a static class called TempConverter.The class should have at least 2 methods,
            //            one called FahrenheitToCelsius that will require a double as a parameter and return a double,
            //            the other CelsiusToFahrenheit which will also require a double as a parameter and return a double.

            //Fill out these methods and call them in your Program.cs file.Make sure they’re accurate!
            double celsius = 13;

            double fahrenheit = 65;

            Console.WriteLine($"{fahrenheit} degrees in Fahrenheit is {TempConverter.FahrenheitToCelsius(fahrenheit)} degrees Celsius");
            Console.WriteLine();
            Console.WriteLine($"{celsius} degrees in Celsius is {TempConverter.CelsiusToFahrenheit(celsius)} degrees Fahrenheit");       





        }
    }
}
