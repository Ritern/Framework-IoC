using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Ioc.extensions.dispatcher.eventdispatcher.api
{
    /// <summary>
    /// The EventDispatcher is the only Dispatcher currently released with Strange
    /// (though by separating EventDispatcher from Dispatcher I'm obviously
    /// signalling that I don't think it's the only possible one).
    /// </summary>
    public interface IEventDispatcher
    {
        IEventBinding Bind(object key);

        /// <summary>
        /// Add an observer with exactly one argument to this Dispatcher.
        /// </summary>
        /// <param name="evt"></param>
        /// <param name="callback"></param>
        void AddListener(object evt, EventCallback callback);

        /// <summary>
        /// Add an observer with exactly no arguments to this Dispatcher.
        /// </summary>
        /// <param name="evt"></param>
        /// <param name="callback"></param>
        void AddListener(object evt, EmptyCallback callback);

        /// <summary>
        /// Remove a previously registered observer with exactly one argument from this Dispatcher.
        /// </summary>
        /// <param name="evt"></param>
        /// <param name="callback"></param>
        void RemoveListener(object evt, EventCallback callback);

        /// <summary>
        /// Remove a previously registered observer with exactly no arguments from this Dispatcher.
        /// </summary>
        /// <param name="evt"></param>
        /// <param name="callback"></param>
        void RemoveListener(object evt, EmptyCallback callback);

        /// <summary>
        /// Returns true if the provided observer is already registered.
        /// </summary>
        /// <param name="evt"></param>
        /// <param name="callback"></param>
        bool HasListener(object evt, EventCallback callback);

        /// <summary>
        /// Returns true if the provided observer is already registered
        /// </summary>
        /// <param name="evt"></param>
        /// <param name="callback"></param>
        /// <returns></returns>
        bool HasListener(object evt, EmptyCallback callback);

        /// <summary>
        /// By passing true, an observer with exactly one argument will be added to this Dispatcher
        /// </summary>
        /// <param name="toAdd"></param>
        /// <param name="evt"></param>
        /// <param name="callback"></param>
        void UpdateListener(bool toAdd, object evt, EventCallback callback);

        /// <summary>
        /// By passing true, an observer with exactly no arguments will be added to this Dispatcher
        /// </summary>
        /// <param name="toAdd"></param>
        /// <param name="evt"></param>
        /// <param name="callback"></param>
        void UpdateListener(bool toAdd, object evt, EmptyCallback callback);

        /// <summary>
        /// Allow a previously retained event to be returned to its pool
        /// </summary>
        /// <param name="evt"></param>
        void ReleaseEvent(IEvent evt);
    }
}
