using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Ioc.framework.api;

namespace Assets.Ioc.extensions.dispatcher.eventdispatcher.api
{
    public delegate void EventCallback(IEvent payload);
    public delegate void EmptyCallback();
    public interface IEventBinding:IBinding
    {
        EventCallbackType TypeForCallback(EventCallback callback);
        EventCallbackType TypeForCallback(EmptyCallback callback);
        new IEventBinding Bind(object key);
        IEventBinding To(EventCallback callback);
        IEventBinding To(EmptyCallback callback);
    }
}
