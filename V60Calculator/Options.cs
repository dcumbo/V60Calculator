using CommandLine;

namespace V60Calculator
{
    public class Options
    {
        [Option('o', "outputcoffeevolume", HelpText = "Amount of coffee you in cup in ml. Required if -g is unset.",
            Group = "Volume")]
        public int OutputCoffeeVolume { get; set; }

        [Option('g', "grains", HelpText = "Amount of grains you want to use. Ignored if '-o' is set.",
            Group = "Volume")]
        public double Grains { get; set; }

        [Option('v', "verbose", Default = false, HelpText = "Output verbose")]
        public bool Verbose { get; set; }

        public bool ShouldUseOutputVolume => OutputCoffeeVolume > 0;
    }
}