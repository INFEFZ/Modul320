namespace Calculator
{
    public class AverageCalculator
    {
        public double CalculateAverage(double[] numbers)
        {
            return numbers.Sum() / numbers.Length;
        }
    }
}
