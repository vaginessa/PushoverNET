using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PushoverNET
{
    /// <summary>
    /// Represents a <see cref="Pushover"/> client used to send a notification.
    /// </summary>
    public class Pushover
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

        public async Task<Response> SendNotificationAsync(Message message)
        {
            var parameters = new Dictionary<string, string>
            {
                { "token", _options.AppToken },
                { "user", _options.UserKey },
                { "title", message.Options.Title },
                { "message", message.Options.Body },
                { "device", message.Options.Device },
                { "sound", message.Options.Sound.ToString().ToLower() },
                { "priority", Convert.ToInt32(message.Options.Priority).ToString() },
                { "retry", message.Options.RetryInterval.TotalSeconds.ToString() },
                { "expire", message.Options.ExpireInterval.TotalSeconds.ToString() }
            };

            var content = new FormUrlEncodedContent(parameters);
            var response = await _client.PostAsync(uri, content).ConfigureAwait(false);
            var s = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            var json = JsonConvert.DeserializeObject<Response>(s);

            return json;
        }

        #endregion
    }
}
