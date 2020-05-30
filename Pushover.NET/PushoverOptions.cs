using System;
using System.Collections.Generic;
using System.Text;

namespace Pushover.NET
{
    /// <summary>
    /// Represents a collection of options used when sending a notification through the <see cref="Pushover"/> class.
    /// </summary>
    class PushoverOptions
    {
        #region Properties

        /// <summary>
        /// The token generated for each application using Pushover.
        /// </summary>
        public string AppToken { get; }

        /// <summary>
        /// The unique key generated for each Pushover account.
        /// </summary>
        public string UserKey { get; }

        #endregion
    }
}
