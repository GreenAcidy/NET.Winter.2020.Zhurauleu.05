using System;
using System.Collections.Generic;
using System.Text;

namespace TranslateMethods
{
    /// <summary >
    /// Class TransformToWords converts any real number (System.Double) into its "verbal format".
    /// </summary >
    public static class DoubleTransformer
    {
        /// <summary >
        /// Algorith for converting double in its "verbal format".
        /// </summary >
        /// <param  name = " number " > number for convirting. </param >
        /// <param  name = " provider " > interface for working with dictionaries. </param >
        /// <returns>Verbal format of number.  </returns>
        public static string TransformToWords(this double number, IDictionaryProvider provider)
        {
            if (provider == null)
            {
                throw new ArgumentNullException(nameof(provider), "must not be null");
            }

            bool flag = provider.SpecialKeys.TryGetValue(number, out string result);
            if (flag)
            {
                return result;
            }

            char[] array = number.ToString().ToCharArray();
            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < array.Length - 1; i++)
            {
                builder.Append($"{provider.Keys[array[i]]} ");
            }

            builder.Append($"{provider.Keys[array[^1]]}");
            return builder.ToString();
        }
    }
}
