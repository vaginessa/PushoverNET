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
        #region Constructor

        public Message(MessageOptions options)
        {
            Options = options;
        }

        #endregion

        #region Properties

        /// <summary>
        /// The <see cref="Message"/> options added when creating a new instance.
        /// </summary>
        public MessageOptions Options { get; set; }

        #endregion
    }
}
