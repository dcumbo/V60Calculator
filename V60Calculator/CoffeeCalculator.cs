namespace V60Calculator
{
    public class CoffeeCalculator
    {
        private const double ratio = 0.06;

        public CoffeeCalculator(int outputVolume)
        {
            OutputVolume = outputVolume;
        }

        private int OutputVolume { get; }
        public double Grains => OutputVolume * ratio;

        public double BloomWater => Grains * 2;
        public double PostBloomWater => OutputVolume - BloomWater;
    }
}