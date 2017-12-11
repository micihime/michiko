using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Haiku.Logger
{
    /// <summary>
    /// Provides logging mechanisms that should be used within the whole CareLink project 
    /// instead of direct access to log4net logger.
    /// </summary>
    public static class HaikuLogger
    {
        #region Public method(s)

        /// <summary>
        /// Logs the specified verbose message to the log.
        /// </summary>
        /// <param name="message">The message to write.</param>
        public static void Debug(string message)
        {
            Write(message, TraceEventType.Verbose, HaikuLogCategory.General);
        }

        /// <summary>
        /// Logs the specified verbose message in the specified format to the log.
        /// </summary>
        /// <param name="messageFormat">The message format.</param>
        /// <param name="parameters">The parameters.</param>
        public static void Debug(string messageFormat, params object[] parameters)
        {
            Debug(string.Format(messageFormat, parameters));
        }

        /// <summary>
        /// Logs the specified verbose message to the log.
        /// </summary>
        /// <param name="message">The message to write.</param>
        /// <param name="category">The category of the log message.</param>
        public static void Debug(string message, HaikuLogCategory category)
        {
            Write(message, TraceEventType.Verbose, category);
        }

        /// <summary>
        /// Logs the specified verbose message to the log with extended properties.
        /// </summary>
        /// <param name="extendedProperties">The extended properties.</param>
        /// <param name="message">The message.</param>
        /// <param name="parameters">The parameters.</param>
        public static void Debug(IDictionary<string, object> extendedProperties, string message, params object[] parameters)
        {
            Write(string.Format(message, parameters), TraceEventType.Verbose, HaikuLogCategory.General, extendedProperties);
        }

        /// <summary>
        /// Logs the specified information message to the log.
        /// </summary>
        /// <param name="message">The message to write.</param>
        public static void Information(string message)
        {
            Write(message, TraceEventType.Information, HaikuLogCategory.General);
        }

        /// <summary>
        /// Logs the specified information message in the specified format to the log.
        /// </summary>
        /// <param name="messageFormat">The message format.</param>
        /// <param name="parameters">The parameters.</param>
        public static void Information(string messageFormat, params object[] parameters)
        {
            Information(string.Format(messageFormat, parameters));
        }

        /// <summary>
        /// Logs the specified information message to the log.
        /// </summary>
        /// <param name="message">The message to write.</param>
        /// <param name="category">The category of the log message.</param>
        public static void Information(string message, HaikuLogCategory category)
        {
            Write(message, TraceEventType.Information, category);
        }

        /// <summary>
        /// Logs the specified information message to the log with extended properties.
        /// </summary>
        /// <param name="extendedProperties">The extended properties.</param>
        /// <param name="message">The message.</param>
        /// <param name="parameters">The parameters.</param>
        public static void Information(IDictionary<string, object> extendedProperties, string message, params object[] parameters)
        {
            Write(string.Format(message, parameters), TraceEventType.Information, HaikuLogCategory.General, extendedProperties);
        }

        /// <summary>
        /// Logs the specified warning message to the log.
        /// </summary>
        /// <param name="message">The message to write.</param>
        public static void Warning(string message)
        {
            Write(message, TraceEventType.Warning, HaikuLogCategory.General);
        }

        /// <summary>
        /// Logs the specified warning message in the specified format to the log.
        /// </summary>
        /// <param name="messageFormat">The message format.</param>
        /// <param name="parameters">The parameters.</param>
        public static void Warning(string messageFormat, params object[] parameters)
        {
            Warning(string.Format(messageFormat, parameters));
        }

        /// <summary>
        /// Logs the specified warning message to the log.
        /// </summary>
        /// <param name="message">The message to write.</param>
        /// <param name="category">The category of the log message.</param>
        public static void Warning(string message, HaikuLogCategory category)
        {
            Write(message, TraceEventType.Warning, category);
        }

        /// <summary>
        /// Logs the specified error message to the log.
        /// </summary>
        /// <param name="message">The message to write.</param>
        public static void Error(string message)
        {
            Write(message, TraceEventType.Error, HaikuLogCategory.General);
        }

        /// <summary>
        /// Logs the specified error message in the specified format to the log.
        /// </summary>
        /// <param name="messageFormat">The message format.</param>
        /// <param name="parameters">The parameters.</param>
        public static void Error(string messageFormat, params object[] parameters)
        {
            Error(string.Format(messageFormat, parameters));
        }

        /// <summary>
        /// Logs the specified error message to the log.
        /// </summary>
        /// <param name="message">The message to write.</param>
        /// <param name="category">The category of the log message.</param>
        public static void Error(string message, HaikuLogCategory category)
        {
            Write(message, TraceEventType.Error, category);
        }

        /// <summary>
        /// Logs the specified critical message to the log.
        /// </summary>
        /// <param name="message">The message to write.</param>
        public static void Critical(string message)
        {
            Write(message, TraceEventType.Critical, HaikuLogCategory.General);
        }

        /// <summary>
        /// Logs the specified information message in the specified format to the log.
        /// </summary>
        /// <param name="messageFormat">The message format.</param>
        /// <param name="parameters">The parameters.</param>
        public static void Critical(string messageFormat, params object[] parameters)
        {
            Critical(string.Format(messageFormat, parameters));
        }

        /// <summary>
        /// Logs the specified critical message to the log.
        /// </summary>
        /// <param name="message">The message to write.</param>
        /// <param name="category">The category of the log message.</param>
        public static void Critical(string message, HaikuLogCategory category)
        {
            Write(message, TraceEventType.Critical, category);
        }
        
        /// <summary>
        /// Writes the specified message to the log.
        /// </summary>
        /// <param name="message">The message to write.</param>
        /// <param name="severity">The severity of the log message.</param>
        /// <param name="category">The category of the log message.</param>
        /// <param name="extendedProperties">The extended properties.</param>
        public static void Write(string message, TraceEventType severity, HaikuLogCategory category, IDictionary<string, object> extendedProperties = null)
        {
            var entry = new HaikuLogEntry
            {
                ActivityId = Trace.CorrelationManager.ActivityId,
                Timestamp = DateTime.Now,
                Message = message,
                Category = category.ToString(),
                Severity = severity,
                Priority = 0,
                Title = "CareLinkPro Logger",
            };

            Write(entry);
        }

        /// <summary>
        /// Writes the specified log entry.
        /// </summary>
        /// <param name="logEntry">The log entry.</param>
        public static void Write(HaikuLogEntry logEntry)
        {
            LogWriter.Write(logEntry);
        }

        #endregion
    }
}
