namespace V60Calculator.Calculator
{
    public class CoffeeGrainsCalculator : CoffeeCalculator, ICoffeeCalculator
    {
        private readonly int _outputVolume;

        public CoffeeGrainsCalculator(int outputVolume)
        {
            _outputVolume = outputVolume;
        }

        public CoffeeCalculatorResult CalculateCoffee()
        {
            return new CoffeeCalculatorResult(_outputVolume, _outputVolume * Ratio);
        }
    }
}