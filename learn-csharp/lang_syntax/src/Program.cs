using System;
using oop;

namespace ConsoleApplication
{
    public class Program1
    {

        public static void Main(string[] args)
        {
            var name = "Michelle";
            // Console.WriteLine("Hello World!");
            Console.WriteLine($"Hello {name}");

            new EnumExample().run();
            // TemperatureConverterProgram.run();
            new SquareProgram().run();
        }
    }
}
