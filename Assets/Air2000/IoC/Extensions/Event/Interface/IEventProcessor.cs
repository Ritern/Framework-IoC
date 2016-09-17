/*----------------------------------------------------------------
            // Copyright © 2014-2016 Air2000
            // 
            // FileName: IEventProcessor.cs
			// Describle:
			// Created By:  Wells Hsu
			// Date&Time:  2016/9/14 11:56:41
            // Modify History:
            //
//----------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Air2000.IoC.Extensions.Event
{
    public interface IEventProcessor
    {
        IEventBinding Bind(object key);
        void Register(object eventID, EventHandlerDelegate handler);
        void Register(object eventID, EventHandlerDelegateEX handler);
        void Notify(object eventID, object data = null);
        void Unregister(object eventID, EventHandlerDelegate handler);
        void Unregister(object eventID, EventHandlerDelegateEX handler);

    }
}
