using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Ioc.extensions.dispatcher.eventdispatcher.api
{
    public enum EventCallbackType
    {
        /// <summary>
        /// Indicates an EventCallback with no arguments.
        /// </summary>
        NO_ARGUMENTS,

        /// <summary>
        /// Indicates an EventCallback with one arguments.
        /// </summary>
        ONE_ARGUMENT,

        /// <summary>
        /// Indicates no matching EventCallback could be found.
        /// </summary>
        NOT_FOUND,
    }
}
