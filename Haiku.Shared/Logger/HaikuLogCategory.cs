namespace Haiku.Logger
{
    /// <summary>
    /// Defines names of the logging categories.
    /// </summary>
    public enum HaikuLogCategory
    {
        /// <summary>
        /// General logging category.
        /// </summary>
        General,

        /// <summary>
        /// Validation logging category.
        /// </summary>
        HaikuValidation,

        /// <summary>
        /// Error logging category. 
        /// Should be used only for critical/fatal errors.
        /// </summary>
        HaikuError
    }
}
