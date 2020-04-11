namespace V60Calculator.Calculator
{
    public class CoffeeCalculatorResult
    {
        public int OutputVolume { get; set; }
        public double Grains { get; set; }
        public double BloomWater => Grains * 2;
        public double PostBloomWater => OutputVolume - BloomWater;

        public CoffeeCalculatorResult(int outputVolume, double grains)
        {
            OutputVolume = outputVolume;
            Grains = grains;
        }

        public override string ToString()
        {
            return $"Grains: {Grains} \r\nBloom Water: {BloomWater} \r\nPost Bloom Water: {PostBloomWater} \r\nOutput Volume: {OutputVolume}";
        }
    }
}