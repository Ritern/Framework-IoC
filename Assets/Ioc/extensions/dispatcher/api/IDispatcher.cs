using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Ioc.extensions.dispatcher.api
{
    /// <summary>
    /// A dispatcher sends notifications to any registered listener.
    /// It represents the subject in a standard Observer pattern.
    /// 
    /// In MVCSContext the dispatched notification is an IEvent.
    /// </summary>
    public interface IDispatcher
    {
        /// <summary>
        /// Send a notification of type eventType.No data.
        /// In MVCSContext this dispatches an IEvent.
        /// </summary>
        /// <param name="eventType"></param>
        void Dispatch(object eventType);

        /// <summary>
        /// Send a notification of type eventType and the provided data payload.
        /// In MVCSContext this dispatches an IEvent.
        /// </summary>
        /// <param name="eventType"></param>
        /// <param name="data"></param>
        void Dispatch(object eventType, object data);
    }
}
