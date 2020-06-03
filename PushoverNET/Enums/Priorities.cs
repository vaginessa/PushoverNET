using System;
using System.Collections.Generic;
using System.Text;

namespace PushoverNET.Enums
{
    /// <summary>
    /// Defines the available priorities for a notification
    /// </summary>
    /// <remarks>By default messages with no <see cref="MessageOptions.Priority"/> have a value of 0.</remarks>
    public enum Priorities
    {
        /// <summary>
        /// Messages sent with this priority will not generate any notifications.
        /// </summary>
        /// <remarks>On iOS this will increase the notifications counter.</remarks>
        Lowest = -2,

        /// <summary>
        /// Messages sent with this priority will not generate any sounds or vibration. They will generate a pop-up notification though.
        /// </summary>
        /// <remarks>Notifications sent during <i>Quiet Hours</i>/> are treated as if they were sent with this priority</remarks>
        Low = -1,

        /// <summary>
        /// Messages sent with this priority will vibrate, generate a sound and a pop-up notification.
        /// </summary>
        Normal = 0,

        /// <summary>
        /// Messages sent with this priority will vibrate, generate a sound and a pop-up notification and will be highlighted as <i>red</i>.
        /// </summary>
        /// <remarks>Will bypass any <i>Quiet Hours</i>.</remarks>
        High = 1,

        /// <summary>
        /// Messages sent with this priority are similar to <see cref="Priorities.High"/> but they will repeat until they're acknowledged.
        /// </summary>
        /// <remarks>Additional parameters <see cref="MessageOptions.ExpireInterval"/> and <see cref="MessageOptions.RetryInterval"/> required.</remarks>
        Emergency = 2
    }
}
