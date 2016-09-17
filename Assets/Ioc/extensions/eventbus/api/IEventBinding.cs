using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Ioc.framework.api;
namespace Assets.Ioc.extensions.eventbus.api
{
    public delegate void EventHandlerDelegate();
    public delegate void EventHandlerDelegateEX(object data);
    public enum EventHandlerType
    {
        NO_ARGUMENTS,

        ONE_ARGUMENT,

        NOT_FOUND,
    }
    public interface IEventBinding : IBinding
    {
        new IEventBinding Bind(object key);
        IEventBinding To(EventHandlerDelegate handler);
        IEventBinding To(EventHandlerDelegateEX handler);

        EventHandlerType GetHandlerType(EventHandlerDelegate handler);
        EventHandlerType GetHandlerType(EventHandlerDelegateEX handler);
    }
}
