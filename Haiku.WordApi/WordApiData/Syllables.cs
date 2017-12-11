using System.Collections.Generic;

namespace Haiku.DataPreparation.WordApiData
{
    /// <summary>
    /// class representing information about word,s syllables 
    /// </summary>
    public class Syllables
    {
        /// <summary>
        /// The number of syllables in a word
        /// </summary>
        public int count;

        /// <summary>
        /// The list of syllables of a word
        /// </summary>
        public List<string> list;
    }
}
