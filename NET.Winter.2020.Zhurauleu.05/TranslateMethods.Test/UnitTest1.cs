using NUnit.Framework;

namespace TranslateMethods.Test
{
    public class DoubleTransformerTests
    {
        [TestCase(double.NaN, ExpectedResult = "Not a number")]
        [TestCase(double.NegativeInfinity, ExpectedResult = "Negative infinity")]
        [TestCase(double.PositiveInfinity, ExpectedResult = "Positive infinity")]
        [TestCase(-0.0d, ExpectedResult = "minus zero")]
        [TestCase(0.0d, ExpectedResult = "zero")]
        [TestCase(0.1d, ExpectedResult = "zero point one")]
        [TestCase(-23.809d, ExpectedResult = "minus two three point eight zero nine")]
        [TestCase(-0.123456789d, ExpectedResult = "minus zero point one two three four five six seven eight nine")]
        [TestCase(1.23333e308d, ExpectedResult = "one point two three three three three E plus three zero eight")]
        [TestCase(double.Epsilon, ExpectedResult = "Epsilon")]
        [TestCase(double.MinValue, ExpectedResult ="minus one point seven nine seven six nine three one three four eight six two three one five seven E plus three zero eight")]
        [TestCase(double.MaxValue, ExpectedResult = "one point seven nine seven six nine three one three four eight six two three one five seven E plus three zero eight")]
        public string TransformToDifferentWords_Strategy(double number)
        {
            var provider = new EnglishDictionary();
            return number.TransformToWords(provider);
        }
    }
}