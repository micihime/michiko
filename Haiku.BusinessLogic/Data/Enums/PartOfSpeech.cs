namespace Haiku.BusinessLogic.Data.Enums
{
    /// <summary>
    /// enum that specifies the part of speech/ word class
    /// </summary>
    public enum PartOfSpeech
    {
        /// <summary>
        /// The word cannot be found in dictionary or its part of speech was not recognised
        /// </summary>
        NONE,

        /// <summary>
        /// definite article 
        /// </summary>
        DEFINITE_ARTICLE,

        /// <summary>
        /// indefinite article 
        /// </summary>
        INDEFINITE_ARTICLE,

        /// <summary>
        /// noun
        /// </summary>
        NOUN,

        /// <summary>
        /// pronoun
        /// </summary>
        PRONOUN,

        /// <summary>
        /// adjective
        /// </summary>
        ADJECTIVE,

        /// <summary>
        /// verb
        /// </summary>
        VERB,
        
        /// <summary>
        /// adverb
        /// </summary>
        ADVERB,

        /// <summary>
        /// preposition
        /// </summary>
        PREPOSITION,

        /// <summary>
        /// conjunction
        /// </summary>
        CONJUNCTION,

        /// <summary>
        /// numeral
        /// </summary>
        NUMERAL


    }

    public static class PartOfSpeechHelper
    {
        public static PartOfSpeech DeterminePartOfSpeechFromString(string item)
        {
            if (item == null)
                return PartOfSpeech.NONE;
            switch (item.ToUpper())
            {
                case "ADJECTIVE": return PartOfSpeech.ADJECTIVE;
                case "NOUN": return PartOfSpeech.NOUN;
                case "PRONOUN": return PartOfSpeech.PRONOUN;
                case "VERB": return PartOfSpeech.VERB;
                case "ADVERB": return PartOfSpeech.ADVERB;
                case "NUMERAL": return PartOfSpeech.NUMERAL;
                case "PREPOSITION": return PartOfSpeech.PREPOSITION;
                case "CONJUNCTION": return PartOfSpeech.CONJUNCTION;
                case "DEFINITE_ARTICLE": return PartOfSpeech.DEFINITE_ARTICLE;
                case "INDEFINITE_ARTICLE": return PartOfSpeech.INDEFINITE_ARTICLE;
                default: return PartOfSpeech.NONE;
            }
        }
    }
}
