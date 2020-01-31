using System;
using System.Collections.Generic;
using System.Text;

namespace TranslateMethods
{
    /// <summary >
    /// Class EnglishDictionary contains two dictionaries for translating number (System.Double) into its english "verbal format".
    /// </summary >
    public class EnglishDictionary : IDictionaryProvider
    {
        /// <summary >
        /// <value>
        /// Gets dictionary Keys contains digits and signs and its "verbal format" for translating.
        /// </value>
        /// </summary >
        /// <value>
        /// Gets "verbal format" for digits and signs.
        /// </value>
        public Dictionary<char, string> Keys => new Dictionary<char, string>
        {
            {'0', "zero"},
            {'1', "one"},
            {'2', "two"},
            {'3', "three"},
            {'4', "four"},
            {'5', "five"},
            {'6', "six"},
            {'7', "seven"},
            {'8', "eight"},
            {'9', "nine"},
            {'-', "minus"},
            {'.', "point"},
            {'E', "E"},
            {'+', "plus"},
        };

        /// <summary >
        /// Gets dictionary SpecialKeys contains special numbers and its "verbal format" for translating.
        /// </summary >
        /// <value>
        /// Gets "verbal format" for special word .
        /// </value>
        public Dictionary<double, string> SpecialKeys => new Dictionary<double, string>
        {
        {double.NaN, "Not a number"},
        {double.PositiveInfinity, "Positive infinity"},
        {double.NegativeInfinity, "Negative infinity"},
        {double.Epsilon, "Epsilon" },
        };
    }
}
