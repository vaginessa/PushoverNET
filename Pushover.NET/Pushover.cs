using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Pushover.NET
{
    /// <summary>
    /// Represents a <see cref="Pushover"/> client used to send a notification.
    /// </summary>
    class Pushover
    {
        #region Fields

        /// <summary>
        /// The collection of <see cref="PushoverOptions"/> passed when creating a new instance of the <see cref="Pushover"/> class.
        /// </summary>
        private readonly PushoverOptions _options;

        /// <summary>
        /// The <see cref="HttpClient"/> used to send the notification.
        /// </summary>
        private static readonly HttpClient _client = new HttpClient();

        #endregion

        #region Constructor

        /// <summary>
        /// Creates a new instance of the <see cref="Pushover"/> class.
        /// </summary>
        public Pushover(PushoverOptions options)
        {
            _options = options;
        }

        #endregion
        }
}
