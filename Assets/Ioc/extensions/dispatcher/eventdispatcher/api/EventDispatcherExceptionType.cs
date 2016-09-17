using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Ioc.extensions.dispatcher.eventdispatcher.api
{
    public enum EventDispatcherExceptionType
    {
        /// <summary>
        /// Indicates that an event was fired with null as the key.
        /// </summary>
        EVENT_KEY_NULL,

        /// <summary>
        /// Indicates that the type of event in the call and the type of Event in the payload don't match.
        /// </summary>
        EVENT_TYPE_MISMATCH,

        /// <summary>
        /// When attempting to fire a callback,the callback was discovered to be casting illegally.
        /// </summary>
        TARGET_INVOCATION
    }
}
