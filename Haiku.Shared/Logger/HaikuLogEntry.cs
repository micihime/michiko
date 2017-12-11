using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Haiku.Logger
{
    /// <summary>
    /// Defines a log entry.
    /// </summary>
    public class HaikuLogEntry
    {
        #region Public member(s)

        /// <summary>
        /// Gets or sets the activity id.
        /// </summary>
        /// <value>
        /// The activity id.
        /// </value>
        public Guid ActivityId { get; set; }

        /// <summary>
        /// Gets or sets the event id.
        /// </summary>
        /// <value>
        /// The event id.
        /// </value>
        public int EventId { get; set; }

        /// <summary>
        /// Gets or sets the time stamp.
        /// </summary>
        /// <value>
        /// The time stamp.
        /// </value>
        public DateTime Timestamp { get; set; }

        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        /// <value>
        /// The message.
        /// </value>
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets the category.
        /// </summary>
        /// <value>
        /// The category.
        /// </value>
        public string Category { get; set; }

        /// <summary>
        /// Gets or sets the severity.
        /// </summary>
        /// <value>
        /// The severity.
        /// </value>
        public TraceEventType Severity { get; set; }

        /// <summary>
        /// Gets or sets the priority.
        /// </summary>
        /// <value>
        /// The priority.
        /// </value>
        public int Priority { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        public string Title { get; set; }

        #endregion
    }
}
