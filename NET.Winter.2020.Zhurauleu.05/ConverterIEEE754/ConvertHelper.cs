using System;
using System.Runtime.InteropServices;

namespace ConverterMethods
{
    /// <summary >
    /// Struct DoubleConverterToLong that conver double in long.
    /// </summary >
    [StructLayout(LayoutKind.Explicit)]

    internal struct ConvertHelper
    {
        [FieldOffset(0)]
        private long numberLong;
        [FieldOffset(0)]
        private double numberDouble;

        public double NumberDouble
        {
            set
            {
                this.numberDouble = value;
            }
        }

        public long NumberLong
        {
            get
            {
                return this.numberLong;
            }
        }
    }

    /// <summary >
    /// Struct DoubleConverterToLong that conver double in long.
    /// </summary >
    public static class DoubleConverter
    {
        public static readonly AppSettings AppSettings;

        static DoubleConverter()
        {
            AppSettings = new AppSettings
            {
                BitsInByte = 8,
                BytesInLong = 8,
            };
        }

        /// <summary >
        /// Algorith for converting double in IEEE754 using long.
        /// </summary >
        /// <param  name = " number " > number for convirting. </param >
        /// <returns>Format IEEE754.  </returns>
        public static string ConvertToIEEE754(double number)
        {
            ConvertHelper converter = default;
            converter.NumberDouble = number;
            long item = converter.NumberLong;
            long mask = 1;
            char[] bit = new char[AppSettings.BitsInByte * AppSettings.BytesInLong];
            for (int i = 0; i < AppSettings.BitsInByte * AppSettings.BytesInLong; i++)
            {
                bit[i] = (mask & item) != 0 ? '1' : '0';
                mask <<= 1;
            }

            Array.Reverse(bit);
            return new string(bit);
        }
    }
}
