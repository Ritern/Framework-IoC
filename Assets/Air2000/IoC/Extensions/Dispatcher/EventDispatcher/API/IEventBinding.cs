/*----------------------------------------------------------------
            // Copyright © 2014-2016 Air2000
            // 
            // FileName: IEventBinding.cs
			// Describle:
			// Created By:  Wells Hsu
			// Date&Time:  2016/9/18 16:28:45
            // Modify History:
            //
//----------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Air2000.IoC.Core;

namespace Air2000.IoC.Extensions.Dispatcher
{
    /// Delegate for adding a listener with a single argument
    public delegate void EventCallback(IEvent payload);

    /// Delegate for adding a listener with a no arguments
    public delegate void EmptyCallback();

    public interface IEventBinding : IBinding
    {
        /// Retrieve the type of the provided callback
        EventCallbackType TypeForCallback(EventCallback callback);

        /// Retrieve the type of the provided callback
        EventCallbackType TypeForCallback(EmptyCallback callback);

        new IEventBinding Bind(object key);
        IEventBinding To(EventCallback callback);
        IEventBinding To(EmptyCallback callback);
    }
}
