using System;
using CommandLine;
using V60Calculator.Calculator;

namespace V60Calculator
{
    internal class Program
    {
        public const decimal ratio = 30 / 500;

        private static ICoffeeCalculator GetCalculator(Options options)
        {
            if (options.ShouldUseOutputVolume)
            {
                return new CoffeeGrainsCalculator(options.OutputCoffeeVolume);
            }

            return new CoffeeOutputCalculator(options.Grains);
        }

        private static void VerboseStart(Options options)
        {
            if (!options.Verbose)
                return;

            if (options.ShouldUseOutputVolume)
            {
                if (options.Verbose)
                {
                    Console.WriteLine($"Starting calculation for output of {options.OutputCoffeeVolume}ml/g");
                }
            }
            else
            {
                if (options.Verbose)
                {
                    Console.WriteLine($"Starting calculation for grains of {options.Grains}g");
                }
            }
        }
        
        private static void Main(string[] args)
        {
            Parser.Default.ParseArguments<Options>(args).WithParsed(options =>
            {
                if (!HasValidOptions(options))
                {
                    Environment.Exit(1);
                }
                
                var coffeeCalculator = GetCalculator(options);
                VerboseStart(options);
                
                var result = coffeeCalculator.CalculateCoffee();
                Console.WriteLine(result);
                
                if (!options.Verbose)
                    return;

                Console.WriteLine("Rinse your paper filter.");
                Console.WriteLine("Pour ground coffee in paper filter.");
                Console.WriteLine($"Pour {result.BloomWater}g/ml while spreading coffee.");
                Console.WriteLine("Perform circular motion so water bed is spread.");
                Console.WriteLine("Wait 45 seconds.");
                Console.WriteLine(
                    $"Pour the rest of the water ({result.PostBloomWater}g/ml) in filter paper.");
                Console.WriteLine("Wait for it to pour down.");
                Console.WriteLine("Let it cool and enjoy.");
            });
        }

        private static bool HasValidOptions(Options options)
        {
            if (options.OutputCoffeeVolume < 0)
            {
                Console.WriteLine("OutputCoffeeVolume ('-o') cannot be negative.");
                return false;
            }

            if (options.Grains < 0)
            {
                Console.WriteLine("Grains ('-g') cannot be negative.");
                return false;
            }

            if (options.OutputCoffeeVolume == 0 && options.Grains == 0)
            {
                Console.WriteLine("Either Grains ('-g') or OutputCoffeeVolume ('-o') must have a value greater than 0.");
                return false;
            }

            return true;
        }
    }
}