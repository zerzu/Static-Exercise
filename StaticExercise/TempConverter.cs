using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    internal static class TempConverter
    {
        public static double FahrenheitToCelsius(double temp)
        {
            return (temp - 32) / 1.8; ;
        }

        public static double CelsiusToFahrenheit(double temp)
        {
            return (temp * 9) / 5 + 32;
        }
    }
}
