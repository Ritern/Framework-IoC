/*----------------------------------------------------------------
            // Copyright © 2014-2016 Air2000
            // 
            // FileName: EventDispatcherException.cs
			// Describle:
			// Created By:  Wells Hsu
			// Date&Time:  2016/9/18 16:29:34
            // Modify History:
            //
//----------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Air2000.IoC.Extensions.Dispatcher
{
    public class EventDispatcherException : Exception
    {
        public EventDispatcherExceptionType type { get; set; }

        public EventDispatcherException() : base()
        {
        }

        /// Constructs an EventDispatcherException with a message and EventDispatcherExceptionType
        public EventDispatcherException(string message, EventDispatcherExceptionType exceptionType) : base(message)
        {
            type = exceptionType;
        }
    }
}
