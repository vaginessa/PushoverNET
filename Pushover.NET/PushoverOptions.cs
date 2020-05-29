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

        public string AppToken { get; }
        public string UserKey { get; }

        #endregion
    }
}
