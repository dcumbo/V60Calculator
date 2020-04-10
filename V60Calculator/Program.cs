using System;
using CommandLine;

namespace V60Calculator
{
    internal class Program
    {
        public const decimal ratio = 30 / 500;

        private static void Main(string[] args)
        {
            Parser.Default.ParseArguments<Options>(args).WithParsed(options =>
            {
                var coffeeCalculator = new CoffeeCalculator(options.OutputCoffeeVolume);

                if (options.Verbose)
                {
                    Console.WriteLine($"Starting calculation for output of {options.OutputCoffeeVolume}");
                }

                Console.WriteLine($"Grans required are {coffeeCalculator.Grains}");

                if (!options.Verbose)
                    return;

                Console.WriteLine("Rinse your paper filter.");
                Console.WriteLine("Pour ground coffee in paper filter.");
                Console.WriteLine($"Pour {coffeeCalculator.BloomWater}g/ml while spreading coffee.");
                Console.WriteLine("Perform circular motion so water bed is spread.");
                Console.WriteLine("Wait 45 seconds.");
                Console.WriteLine(
                    $"Pour the rest of the water ({coffeeCalculator.PostBloomWater}g/ml) in filter paper.");
                Console.WriteLine("Wait for it to pour down.");
                Console.WriteLine("Let it cool and enjoy.");
            });
        }
    }
}