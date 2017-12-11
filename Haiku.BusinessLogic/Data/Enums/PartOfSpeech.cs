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
}
