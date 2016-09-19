/*----------------------------------------------------------------
            // Copyright © 2014-2016 Air2000
            // 
            // FileName: IEventDispatcher.cs
			// Describle:
			// Created By:  Wells Hsu
			// Date&Time:  2016/9/18 16:28:57
            // Modify History:
            //
//----------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Air2000.IoC.Extensions.Dispatcher
{
    public interface IEventDispatcher : IDispatcher
    {
        IEventBinding Bind(object key);

        /// Add an observer with exactly one argument to this Dispatcher
        void AddListener(object evt, EventCallback callback);

        /// Add an observer with exactly no arguments to this Dispatcher
        void AddListener(object evt, EmptyCallback callback);

        /// Remove a previously registered observer with exactly one argument from this Dispatcher
        void RemoveListener(object evt, EventCallback callback);

        /// Remove a previously registered observer with exactly no arguments from this Dispatcher
        void RemoveListener(object evt, EmptyCallback callback);

        /// Returns true if the provided observer is already registered
        bool HasListener(object evt, EventCallback callback);

        /// Returns true if the provided observer is already registered
        bool HasListener(object evt, EmptyCallback callback);

        /// By passing true, an observer with exactly one argument will be added to this Dispatcher
        void UpdateListener(bool toAdd, object evt, EventCallback callback);

        /// By passing true, an observer with exactly no arguments will be added to this Dispatcher
        void UpdateListener(bool toAdd, object evt, EmptyCallback callback);

        /// Allow a previously retained event to be returned to its pool
        void ReleaseEvent(IEvent evt);
    }
}
