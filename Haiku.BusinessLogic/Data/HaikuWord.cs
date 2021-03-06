﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using Haiku.BusinessLogic.Data.Enums;
using Haiku.BusinessLogic.DBAccess;

namespace Haiku.BusinessLogic.Data
{
    /// <summary>
    /// Class that represents haiku-specific word
    /// </summary>
    public class HaikuWord
    {
        #region Fields

        private int id;

        private string wordString;

        private PartOfSpeech partOfSpeech;

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
        public PartOfSpeech WordPartOfSpeech
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

        #region Constructor

        //public HaikuWord(HaikuDBWord haikuDBWord)
        //{
        //    ID = haikuDBWord.ID;
        //    WordString = haikuDBWord.WordString;
        //    WordPartOfSpeech = PartOfSpeechHelper.DeterminePartOfSpeechFromString(haikuDBWord.WordPartOfSpeech);
        //    NumberOfSyllables = haikuDBWord.NumberOfSyllables;
        //}
        #endregion

        #region Methods

        public bool IsValid()
        {
            if (!String.IsNullOrEmpty(wordString) ||
                (WordPartOfSpeech != PartOfSpeech.NONE) ||
                (NumberOfSyllables > 0))
                return true;
            else
                return false;
        }
        #endregion
    }
}