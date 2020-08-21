using System;
using System.Collections.Generic;
using System.Text;

namespace PushoverNET
{
    /// <summary>
    /// Represents a <see cref="Message"/> sent as a notification through the <see cref="Pushover"/> client.
    /// </summary>
    public class Message
    {
        #region Constructor

        public Message(MessageOptions options)
        {
            Options = options;
        }

        #endregion

        #region Properties

        /// <summary>
        /// The <see cref="Message"/> text required when sending a notification.
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        /// The <see cref="Message"/> options added when creating a new instance.
        /// </summary>
        public MessageOptions Options { get; set; }

        #endregion
    }
}
