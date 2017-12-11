using System;
using System.Collections.Generic;

using Haiku.BusinessLogic.Data.Enums;

namespace Haiku.BusinessLogic.Data
{
    /// <summary>
    /// class that represents verse model
    /// </summary>
    public class VerseModel
    {
        #region Fields

        List<PartOfSpeech> partOfSpeechList;
        List<int> syllableCountList;
        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the part of speech list.
        /// </summary>
        /// <value>
        /// The part of speech list.
        /// </value>
        public List<PartOfSpeech> PartOfSpeechList
        {
            get { return partOfSpeechList; }
            set { partOfSpeechList = value; }
        }

        /// <summary>
        /// Gets or sets the syllable count list.
        /// </summary>
        /// <value>
        /// The syllable count list.
        /// </value>
        public List<int> SyllableCountList
        {
            get { return syllableCountList; }
            set { syllableCountList = value; }
        }
        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="VerseModel" /> class.
        /// </summary>
        /// <param name="extractedVerseModel">The extracted verse model.</param>
        /// <param name="syllableCount">The syllable count.</param>
        public VerseModel(List<PartOfSpeech> extractedVerseModel, int syllableCount)
        {
            partOfSpeechList = extractedVerseModel;
            NewSyllableDistribution(syllableCount);
        }
        #endregion

        #region Public Methods

        /// <summary>
        /// Re-news the syllable distribution.
        /// </summary>
        /// <param name="syllableRange">The syllable range.</param>
        public void NewSyllableDistribution(int verseSyllableCount)
        {
            Random random = new Random();
            bool isOK = false;

            do
            {
                List<int> syllableList = new List<int>();
                int syllableRange = verseSyllableCount;

                for (int i = 0; i < (partOfSpeechList.Count - 1); i++)
                {
                    if (syllableRange >= 1)
                    {
                        int syllableCount = random.Next(1, syllableRange);
                        syllableList.Add(syllableCount);
                        syllableRange -= syllableCount;
                    }
                    else
                    {
                        isOK = false;
                        break;
                    }
                }

                if (syllableRange >= 1)
                {
                    syllableList.Add(syllableRange);
                    syllableCountList = syllableList;
                    isOK = true;
                }
                else
                {
                    isOK = false;
                }

            } while (!isOK);
        }

        /// <summary>
        /// Determines whether this instance is valid
        /// </summary>
        /// <returns>returns true if valid</returns>
        public bool IsValid()
        {
            if (partOfSpeechList.Count.Equals(syllableCountList.Count))
                return true;
            else
                return false;
        }
        #endregion
    }
}
