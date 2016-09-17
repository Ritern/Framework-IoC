using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Ioc.extensions.eventbus.api
{
    public interface IEventProcessor
    {
        IEventBinding Bind(object key);
        void Register(object eventID, EventHandlerDelegate handler);
        void Register(object eventID, EventHandlerDelegateEX handler);
        void Notify(object eventID, object data);
        void Unregister(object eventID, EventHandlerDelegate handler);
        void Unregister(object eventID, EventHandlerDelegateEX handler);
    }
}
