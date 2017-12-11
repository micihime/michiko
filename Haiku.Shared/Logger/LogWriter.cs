using System;
using System.Text;
using System.IO;

namespace Haiku.Logger
{
    /// <summary>
    /// The Log writer.
    /// </summary>
    public class LogWriter
    { 
        #region Private member(s)

        private static string logFile = Environment.SpecialFolder.ApplicationData.ToString() + "log.log";

        #endregion

        #region Public method(s)

        /// <summary>
        /// Writes the specified log entry.
        /// </summary>
        /// <param name="logEntry">The log entry.</param>
        public static void Write(HaikuLogEntry logEntry)
        {
            StringBuilder message = new StringBuilder();
            message.Append(" ").Append("ActivityID: " + logEntry.ActivityId + Environment.NewLine);
            message.Append(" ").Append("Title: " + logEntry.Title + Environment.NewLine);
            message.Append(" ").Append("Timestamp: " + logEntry.Timestamp + Environment.NewLine);
            message.Append(" ").Append("Category: " + logEntry.Category + Environment.NewLine);
            message.Append(" ").Append("Priority: " + logEntry.Priority + Environment.NewLine);
            message.Append(" ").Append("Message: " + logEntry.Message + Environment.NewLine);

            using (StreamWriter writer = new StreamWriter(logFile))
            {
                writer.WriteLine(message);
            }
        }

        #endregion
    }
}
