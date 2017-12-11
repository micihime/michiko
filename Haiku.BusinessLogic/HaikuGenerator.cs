using System;
using System.Linq;
using System.Collections.Generic;

using Haiku.BusinessLogic.Data;
using Haiku.BusinessLogic.DBAccess;

namespace Haiku.BusinessLogic
{
    /// <summary>
    /// class that contains functions for generating haiku poems
    /// </summary>
    public static class HaikuGenerator
    {
        #region Private Fields

        /// <summary>
        /// The dictionary
        /// </summary>
        private static List<HaikuWord> dictionary = HaikuDBAccess.GetHaikuWords();
        /// <summary>
        /// The extracted model list
        /// </summary>
        private static List<HaikuDBModel> modelList = HaikuDBAccess.GetHaikuModels();
        #endregion

        #region Public Methods

        /// <summary>
        /// Generates the random haiku poem using words from dictionary and based on random model from model list.
        /// </summary>
        /// <param name="dictionary">The dictionary with words and their metadata.</param>
        /// <param name="haikuModelList">The haiku model list.</param>
        /// <returns>Generated haiku.</returns>
        public static HaikuPoem GenerateRandomHaiku()
        {
            try
            {
                Random random = new Random();
                int modelNr = random.Next(0, modelList.Count);
                HaikuModel model = new HaikuModel(modelList[modelNr]);

                //every time new Random() is used, it is initialized using the clock - in a tight loop the same value is generated lots of times
                //single Random instance should be kept, Next should be called on the same instance
                HaikuPoem haiku = new HaikuPoem(
                    createVerse(dictionary, model.FirstVerseModel, random),
                    createVerse(dictionary, model.SecondVerseModel, random),
                    createVerse(dictionary, model.ThirdVerseModel, random),
                    modelNr
                );
                return haiku;
            }
            catch (ArgumentOutOfRangeException)
            {
                return GenerateRandomHaiku();
            }
        }
        #endregion

        #region Private Methods

        /// <summary>
        /// Creates the verse.
        /// </summary>
        /// <param name="dictionary">The dictionary.</param>
        /// <param name="verseModel">The verse model.</param>
        /// <param name="random">The random instance- every time new Random() is used, it's initialized using the clock. This causes that the 
        /// same value is generated lots of times in tight loop. Therefore, single Random instance should be kept and Next method should be 
        /// called on the same instance</param>
        /// <returns>generated verse</returns>
        private static string createVerse(List<HaikuWord> dictionary, VerseModel verseModel, Random random)
        {
            string verse = "";

            for (int j = 0; j < verseModel.PartOfSpeechList.Count; j++)
            {
                var queryHaikuWords = from word in dictionary
                                      where ((word.WordPartOfSpeech == verseModel.PartOfSpeechList[j]) &&
                                            (word.NumberOfSyllables == verseModel.SyllableCountList[j]))
                                      select word;

                List<HaikuWord> selectedHaikuWords = queryHaikuWords.ToList();
                int wordNr = random.Next(0, selectedHaikuWords.Count);
                verse = verse + " " + selectedHaikuWords[wordNr].WordString;
            }

            return verse;
        }
        #endregion
    }
}
