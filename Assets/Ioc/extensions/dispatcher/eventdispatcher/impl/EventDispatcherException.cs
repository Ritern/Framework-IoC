using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Ioc.extensions.dispatcher.eventdispatcher.api;

namespace Assets.Ioc.extensions.dispatcher.eventdispatcher.impl
{
    public class EventDispatcherException : Exception
    {
        public EventDispatcherExceptionType type { get; set; }

        public EventDispatcherException() : base() { }

        /// Constructs an EventDispatcherException with a message and EventDispatcherExceptionType
		public EventDispatcherException(string message, EventDispatcherExceptionType exceptionType) : base(message)
        {
            type = exceptionType;
        }
    }
}
