using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Ioc.extensions.dispatcher.eventdispatcher.api
{
    public interface IEvent
    {
        /// <summary>
        /// The Event key.
        /// </summary>
        object type { get; set; }

        /// <summary>
        /// The IEventDispatcher that sent the event.
        /// </summary>
        IEventDispatcher target { get; set; }

        /// <summary>
        /// An arbitrary data payload.
        /// </summary>
        object data { get; set; }
    }
}
