namespace examples
{
    class TemperatureConverter
    {

        public double FarenheitToCelsius(string input)
        {
            double farenheit = double.Parse(input);
            double celsius = (farenheit - 32) * 5 / 9;
            return celsius;
        }

        public double CelsiusToFarenheit(string input)
        {
            double celsius = double.Parse(input);
            double farenheit = celsius * 9 / 5 + 32;
            return farenheit;
        }

    }

}
