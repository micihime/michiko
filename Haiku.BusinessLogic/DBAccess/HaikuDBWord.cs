using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Haiku.BusinessLogic.Data;
using Haiku.BusinessLogic.Data.Enums;

namespace Haiku.BusinessLogic.DBAccess
{
    /// <summary>
    /// Class that represents haiku-specific word
    /// </summary>
    [Table("HaikuWords")]
    public class HaikuDBWord
    {
        #region Fields
        
        private int id;

        private string wordString;

        private string partOfSpeech;

        private Int16 numberOfSyllables;
        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        [Key]
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        /// <summary>
        /// The word
        /// </summary>
        public string WordString
        {
            get { return wordString; }
            set { wordString = value; }
        }

        /// <summary>
        /// The part of speech
        /// </summary>
        public string WordPartOfSpeech
        {
            get { return partOfSpeech; }
            set { partOfSpeech = value; }
        }

        /// <summary>
        /// The syllable count
        /// </summary>
        public Int16 NumberOfSyllables
        {
            get { return numberOfSyllables; }
            set { numberOfSyllables = value; }
        }
        #endregion

        #region Methods

        /// <summary>
        /// To the haiku word.
        /// </summary>
        /// <returns></returns>
        public HaikuWord ToHaikuWord()
        {
            try
            {
                HaikuWord haikuWord = new HaikuWord();
                haikuWord.ID = this.ID;
                haikuWord.WordString = this.WordString;
                haikuWord.WordPartOfSpeech = PartOfSpeechHelper.DeterminePartOfSpeechFromString(this.WordPartOfSpeech);
                haikuWord.NumberOfSyllables = this.NumberOfSyllables;
                return haikuWord;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        #endregion
    }
}