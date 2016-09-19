/*----------------------------------------------------------------
            // Copyright © 2014-2016 Air2000
            // 
            // FileName: EventDispatcherExceptionType.cs
			// Describle:
			// Created By:  Wells Hsu
			// Date&Time:  2016/9/18 16:28:21
            // Modify History:
            //
//----------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace  Air2000.IoC.Extensions.Dispatcher 
{
    public enum EventDispatcherExceptionType
    {
        /// Indicates that an event was fired with null as the key.
        EVENT_KEY_NULL,

        /// Indicates that the type of Event in the call and the type of Event in the payload don't match.
        EVENT_TYPE_MISMATCH,

        /// When attempting to fire a callback, the callback was discovered to be casting illegally.
        TARGET_INVOCATION
    }
}
