using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace PushoverNET
{
    /// <summary>
    /// Represents the <see cref="Response"/> received from Pushover servers after sending a notification.
    /// </summary>
    public class Response
    {
        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("request")]
        public string Request { get; set; }

        [JsonProperty("errors")]
        public string[] Errors { get; set; }

        [JsonProperty("receipt")]
        public string Receipt { get; set; }

        [JsonProperty("user")]
        public string User { get; set; }
    }
}
