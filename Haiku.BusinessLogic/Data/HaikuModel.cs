using System;
using System.Collections.Generic;
using System.Linq;

using Haiku.BusinessLogic.Data.Enums;
using Haiku.BusinessLogic.DBAccess;

namespace Haiku.BusinessLogic.Data
{
    /// <summary>
    /// class that represents haiku model (list of parts of speeches with syllable distribution)
    /// </summary>
    public class HaikuModel
    {
        #region Constants

        /// <summary>
        /// syllable count for 1st and 3rd verse
        /// </summary>
        const int SYLLABLE_COUNT_1ST_AND_3RD_VERSE = 5;
        /// <summary>
        /// The thir d_ vers e_ syllabl e_ count
        /// </summary>
        const int SYLLABLE_COUNT_2ND_VERSE = 7;

        /// <summary>
        /// minimum count of words in extracted model
        /// </summary>
        const int WORDS_MIN = 2;
        /// <summary>
        /// maximum count of words in extracted model for 1st and 3rd verse
        /// </summary>
        const int WORDS_MAX = 5;
        /// <summary>
        /// maximum count of words in extracted model for 2nd verse
        /// </summary>
        const int WORDS_MAX2 = 7;
        #endregion

        #region Fields

        private string id;

        private VerseModel firstVerseModel;
        private VerseModel secondVerseModel;
        private VerseModel thirdVerseModel;
        #endregion

        #region Properties

        /// <summary>
        /// Gets the model identifier.
        /// </summary>
        /// <value>
        /// The model identifier.
        /// </value>
        public string ID
        {
            get { return id; }
            set { id = value; }
        }

        /// <summary>
        /// Gets the first verse model.
        /// </summary>
        /// <value>
        /// The first verse model.
        /// </value>
        public VerseModel FirstVerseModel
        {
            get { return firstVerseModel; }
            set { firstVerseModel = value; }
        }

        /// <summary>
        /// Gets the second verse model.
        /// </summary>
        /// <value>
        /// The second verse model.
        /// </value>
        public VerseModel SecondVerseModel
        {
            get { return secondVerseModel; }
            set { secondVerseModel = value; }
        }

        /// <summary>
        /// Gets the third verse model.
        /// </summary>
        /// <value>
        /// The third verse model.
        /// </value>
        public VerseModel ThirdVerseModel
        {
            get { return thirdVerseModel; }
            set { thirdVerseModel = value; }
        }
        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="HaikuModel"/> class.
        /// </summary>
        public HaikuModel(HaikuDBModel dbModel)
        {
            List<PartOfSpeech> v1 = convertVerseModelString(dbModel.FirstVerseModel);
            List<PartOfSpeech> v2 = convertVerseModelString(dbModel.SecondVerseModel);
            List<PartOfSpeech> v3 = convertVerseModelString(dbModel.ThirdVerseModel);

            firstVerseModel = new VerseModel(v1, SYLLABLE_COUNT_1ST_AND_3RD_VERSE);
            secondVerseModel = new VerseModel(v2, SYLLABLE_COUNT_2ND_VERSE);
            thirdVerseModel = new VerseModel(v3, SYLLABLE_COUNT_1ST_AND_3RD_VERSE);
        }
        #endregion

        #region Public Methods

        /// <summary>
        /// Re-news the syllable distribution.
        /// </summary>
        public void NewSyllableDistribution()
        {
            FirstVerseModel.NewSyllableDistribution(SYLLABLE_COUNT_1ST_AND_3RD_VERSE);
            SecondVerseModel.NewSyllableDistribution(SYLLABLE_COUNT_2ND_VERSE);
            ThirdVerseModel.NewSyllableDistribution(SYLLABLE_COUNT_1ST_AND_3RD_VERSE);
        }

        /// <summary>
        /// Determines whether this instance is valid.
        /// </summary>
        /// <returns>true if valid, false if not</returns>
        public bool IsValid()
        {
            if ((firstVerseModel == null) || (secondVerseModel == null) || (thirdVerseModel == null))
                return false;

            if (firstVerseModel.IsValid() && secondVerseModel.IsValid() && thirdVerseModel.IsValid())
                return true;
            else
                return false;
        }

        //private static bool IsValid(ExtractedHaikuModel model)
        //{
        //    if ((model.FirstVerseModel == null) || (model.SecondVerseModel == null) || (model.ThirdVerseModel == null))
        //        return false;

        //    if (((model.firstVerseModel.Count >= 2) && (model.firstVerseModel.Count <= 4)) &&
        //        ((model.secondVerseModel.Count >= 3) && (model.secondVerseModel.Count <= 5)) &&
        //        ((model.thirdVerseModel.Count >= 2) && (model.thirdVerseModel.Count <= 4)))
        //        return true;
        //    else
        //        return false;
        //}
        #endregion

        #region Private Methods

        /// <summary>
        /// Converts the verse model string.
        /// </summary>
        /// <param name="stringModel">The string model.</param>
        /// <returns></returns>
        private List<PartOfSpeech> convertVerseModelString(string stringModel)
        {
            List<PartOfSpeech> model = new List<PartOfSpeech>();
            List<string> listOfStrings = stringModel.Split('-').ToList();
            List<int> listOfInts = listOfStrings.Select(q => Convert.ToInt32(q)).ToList();
            foreach (int item in listOfInts)
            {
                model.Add((PartOfSpeech)item);
            }
            return model;
        }
        #endregion
    }
}
