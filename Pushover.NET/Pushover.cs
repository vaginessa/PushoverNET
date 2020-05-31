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
        private static readonly HttpClient _client;

        /// <summary>
        /// The Pushover API web address
        /// </summary>
        private readonly Uri uri = new Uri("https://api.pushover.net/1/messages.json");

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

        #region Methods

        public async Task<string> SendNotificationAsync(Message message)
        {
            var parameters = new Dictionary<string, string>
            {
                { "token", _options.AppToken },
                { "user", _options.UserKey },
                { "title", message.Options.Title },
                { "message", message.Options.Body },
                { "device", message.Options.Device },
                { "sound", message.Options.Sound }
            };

            var content = new FormUrlEncodedContent(parameters);
            var response = await _client.PostAsync(uri, content);
            var output = response.StatusCode.ToString();
            return output;
        }

        #endregion
    }
}
