/*----------------------------------------------------------------
            // Copyright © 2014-2016 Air2000
            // 
            // FileName: IEvent.cs
			// Describle:
			// Created By:  Wells Hsu
			// Date&Time:  2016/9/18 16:28:37
            // Modify History:
            //
//----------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Air2000.IoC.Extensions.Dispatcher
{
    public interface IEvent
    {
        /// The Event key
        object type { get; set; }

        /// The IEventDispatcher that sent the event
        IEventDispatcher target { get; set; }

        /// An arbitrary data payload
        object data { get; set; }
    }
}
