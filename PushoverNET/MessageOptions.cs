using System;
using System.Collections.Generic;
using System.Text;

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
