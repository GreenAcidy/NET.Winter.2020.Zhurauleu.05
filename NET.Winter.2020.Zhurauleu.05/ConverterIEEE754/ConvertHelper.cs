using System;
using System.Runtime.InteropServices;

namespace ConverterIEEE754
{
    /// <summary >
    /// Struct DoubleConverterToLong that conver double in long.
    /// </summary >
    [StructLayout(LayoutKind.Explicit)]

    public struct ConvertHelper
    {
        [FieldOffset(0)]
        private readonly long numberLong;
        [FieldOffset(0)]
        private double numberDouble;

        /// <summary >
        /// Method of getting number.
        /// </summary >
        /// <param  name = " number " > number for convirting. </param >
        public void SetNumber(double number)
        {
            this.numberDouble = number;
        }

        /// <summary >
        /// Method for returning number in long type.
        /// </summary >
        /// <returns>number in long type.  </returns>
        public long GetNumber()
        {
            return this.numberLong;
        }
    }

    /// <summary >
    /// Struct DoubleConverterToLong that conver double in long.
    /// </summary >
    public static class DoubleConverter
    {
        /// <summary >
        /// Algorith for converting double in IEEE754 using long.
        /// </summary >
        /// <param  name = " number " > number for convirting. </param >
        /// <returns>Format IEEE754.  </returns>
        public static string ConvertToIEEE754(double number)
        {
            ConvertHelper converter = default;
            converter.SetNumber(number);
            long item = converter.GetNumber();
            long mask = 1;
            char[] bit = new char[64];
            for (int i = 0; i < 64; i++)
            {
                if ((mask & item) != 0)
                {
                    bit[i] = '1';
                }
                else
                {
                    bit[i] = '0';
                }

                mask <<= 1;
            }

            Array.Reverse(bit);
            string result = new string(bit);
            return result;
        }
    }
}
