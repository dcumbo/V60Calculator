using System;

namespace V60Calculator.Calculator
{
    public class CoffeeOutputCalculator : CoffeeCalculator, ICoffeeCalculator
    {
        private readonly double _grains;

        public CoffeeOutputCalculator(double grains)
        {
            _grains = grains;
        }

        public CoffeeCalculatorResult CalculateCoffee()
        {
            var outputVolume = Convert.ToInt32(_grains / Ratio);

            return new CoffeeCalculatorResult(outputVolume, _grains);
        }
    }
}