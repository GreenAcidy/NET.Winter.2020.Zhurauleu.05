using System.Collections.Generic;

namespace TranslateMethods
{
    /// <summary>
    /// Interface IDictionaryProvider sets the behavior for dictionaries.
    /// </summary>
    public interface IDictionaryProvider
    {
        /// <summary>
        /// Gets dictionary Keys.
        /// </summary>
        /// <value>
        /// Method get.
        /// </value>
        Dictionary<char, string> Keys { get; }

        /// <summary>
        /// Gets dictionary SpecialKeys.
        /// </summary>
        /// <value>
        /// Method get.
        /// </value>
        Dictionary<double, string> SpecialKeys { get; }
    }
}
