using System;
using System.Collections.Generic;
using System.Text;

namespace Pushover.NET
{
    /// <summary>
    /// Represents a <see cref="Message"/> sent as a notification through the <see cref="Pushover"/> client.
    /// </summary>
    class Message
    {
        #region Properties

        /// <summary>
        /// The title of the <see cref="Message"/> being sent.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// The body of the <see cref="Message"/> being sent.
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        /// The device to which the <see cref="Message"/> is being sent.
        /// </summary>
        public string Device { get; set; }

        /// <summary>
        /// The notification sound used when receiving the <see cref="Message"/>.
        /// </summary>
        public string Sound { get; set; }

        #endregion
    }
}
