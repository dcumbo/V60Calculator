using CommandLine;

namespace V60Calculator
{
    public class Options
    {
        [Option('o', "outputcoffeevolume", Required = true, HelpText = "Amount of coffee you in cup in ml..")]
        public int OutputCoffeeVolume { get; set; }

        [Option('v', "verbose", Default = false, HelpText = "Output verbose")]
        public bool Verbose { get; set; }
    }
}