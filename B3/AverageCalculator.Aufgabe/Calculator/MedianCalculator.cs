namespace Calculator
{
    public class MedianCalculator
    {
        public double CalculateMedian(double[] numbers)
        {
            var numbersCloned = (double[])numbers.Clone();
            Array.Sort(numbersCloned);
            var size = numbersCloned.Length;
            var mid = size / 2;

            if (size % 2 != 0)
                return numbersCloned[mid];

            var midValue1 = numbersCloned[mid];
            var midValue2 = numbersCloned[mid - 1];
            return (midValue1 + midValue2) / 2;
        }
    }
}
