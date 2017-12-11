using Haiku.DataPreparation.WordApiData;

namespace Haiku.DataPreparation.Data
{
    /// <summary>
    /// Class that represents response of GET request to Word endpoint of WordsAPI
    /// documentation https://market.mashape.com/wordsapi/wordsapi#word
    /// endpoint https://wordsapiv1.p.mashape.com/words/{word}
    /// Retrieve information about a word.
    /// </summary>
    public class WordApiWord
    {
        /// <summary>
        /// The word string
        /// </summary>
        public string word;

        /// <summary>
        /// everything known about a word
        /// </summary>
        public WordInfo[] results;

        /// <summary>
        /// The syllable info
        /// </summary>
        public Syllables syllables;
        
        /// <summary>
        /// The frequency
        /// </summary>
        public double frequency;
    }
}
