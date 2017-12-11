namespace Haiku.BusinessLogic.Data.Enums
{
    /// <summary>
    /// enum that represents the origin of the haiku poem
    /// </summary>
    public enum HaikuSource
    {
        /// <summary>
        /// haiku downloaded from AhaPoetry portal
        /// </summary>
        AHAPOETRY,

        /// <summary>
        /// haiku downloaded from DailyHaiku portal
        /// </summary>
        DAILYHAIKU,

        /// <summary>
        /// generated haiku
        /// </summary>
        GENERATED,

        /// <summary>
        /// unknown source
        /// </summary>
        UNKNOWN
    }
}
