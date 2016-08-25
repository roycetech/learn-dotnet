using System;
using examples;

class TemperatureConverterProgram {

    public static void run() {
        string choice = string.Empty, input = String.Empty;
        double result;

        while (choice != "q" && choice != "Q") {
            Console.Write("Press F)arenheit, C)elsius to convert to, or Q)uit: ");
            choice = Console.ReadKey().KeyChar.ToString();
            Console.WriteLine();

            switch (choice) {
                case "Q":
                case "q":
                    Console.WriteLine("Thank you, program will now exit");
                    break;
                case "F":
                case "f":
                    Console.Write("Enter temperature in Celsius: ");
                    input = Console.ReadLine();
                    TemperatureConverter celsiusConverter = new TemperatureConverter();                    
                    result = celsiusConverter.CelsiusToFarenheit(input);
                    Console.WriteLine($"The temperature in Farenheit is {result:f2}");
                    break;
                case "C":
                case "c":
                    Console.Write("Enter temperature in Farenheit: ");
                    input = Console.ReadLine();
                    TemperatureConverter farenheitConverter = new TemperatureConverter();                    
                    result = farenheitConverter.FarenheitToCelsius(input);
                    Console.WriteLine($"The temperature in Celsius is {result:f2}");
                    break;
                    default:
                    Console.WriteLine($"The choice {choice} is not supported");
                    break;
            }  
        }

    }

}