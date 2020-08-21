using System;
using System.Collections.Generic;
using System.Text;
using PushoverNET.Enums;

namespace PushoverNET
{
    /// <summary>
    /// Represents a collection of options used when creating an instance of the <see cref="Message"/> class.
    /// </summary>
    public class MessageOptions
    {
        #region Properties

        /// <summary>
        /// The title of the <see cref="Message"/> being sent.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// The device to which the <see cref="Message"/> is being sent.
        /// </summary>
        public string Device { get; set; }

        /// <summary>
        /// The notification sound used when receiving the <see cref="Message"/>.
        /// </summary>
        public Sounds Sound { get; set; }

        /// <summary>
        /// The notification priority.
        /// </summary>
        public Priorities Priority { get; set; } = Priorities.Normal;

        /// <summary>
        /// The time interval in seconds before sending again an <see cref="Priorities.Emergency"/> notification.
        /// </summary>
        /// <remarks>Needs to be of at least <bold>30 seconds</bold>.</remarks>
        public TimeSpan RetryInterval { get; set; }

        /// <summary>
        /// The time interval in seconds after which Pushover's server will stop sending an <see cref="Priorities.Emergency"/> notification.
        /// </summary>
        /// <remarks>Needs to be at maximum of <bold>10800 seconds</bold> (3 hours).</remarks>
        public TimeSpan ExpireInterval { get; set; }

        #endregion
    }
}
