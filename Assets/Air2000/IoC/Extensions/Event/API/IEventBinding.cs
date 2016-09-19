/*----------------------------------------------------------------
            // Copyright © 2014-2016 Air2000
            // 
            // FileName: IEventBinding.cs
			// Describle:
			// Created By:  Wells Hsu
			// Date&Time:  2016/9/14 11:56:31
            // Modify History:
            //
//----------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Air2000.IoC.Core;

namespace Air2000.IoC.Extensions.Event
{
    public delegate void EventHandlerDelegate();
    public delegate void EventHandlerDelegateEX(object data);
    public interface IEventBinding : IBinding
    {
        new IEventBinding Bind(object key);
        IEventBinding To(EventHandlerDelegate handler);
        IEventBinding To(EventHandlerDelegateEX handler);
    }
}
