using System.Collections.Generic;

namespace Haiku.DataPreparation.WordApiData
{
    /// <summary>
    /// class representing basic info of a word
    /// </summary>
    public class WordInfo
    {
        /// <summary>
        /// The definition of a word
        /// </summary>
        public string definition;

        /// <summary>
        /// The part of speech
        /// </summary>
        public string partOfSpeech;

        /// <summary>
        /// The synonyms
        /// </summary>
        public List<string> synonyms;

        /// <summary>
        /// words that are more general than the word.
        /// </summary>
        public List<string> typeOf;

        /// <summary>
        /// words that are more specific than the word.
        /// </summary>
        public List<string> hasTypes;

        /// <summary>
        /// List of words that are derived from the word.
        /// </summary>
        public List<string> derivation;

        /// <summary>
        /// The example sentences containing the word.
        /// </summary>
        public List<string> examples;
    }
}
