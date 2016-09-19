/*----------------------------------------------------------------
            // Copyright © 2014-2016 Air2000
            // 
            // FileName: EventBinding.cs
			// Describle:
			// Created By:  Wells Hsu
			// Date&Time:  2016/9/18 16:29:13
            // Modify History:
            //
//----------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using Air2000.IoC.Core;

namespace Air2000.IoC.Extensions.Dispatcher
{
    public class EventBinding : Binding, IEventBinding
    {
        private Dictionary<Delegate, EventCallbackType> callbackTypes;

        public EventBinding() : this(null)
        {
        }

        public EventBinding(Air2000.IoC.Core.Binder.BindingResolver resolver) : base(resolver)
        {
            keyConstraint = BindingConstraintType.ONE;
            valueConstraint = BindingConstraintType.MANY;
            callbackTypes = new Dictionary<Delegate, EventCallbackType>();
        }

        public EventCallbackType TypeForCallback(EmptyCallback callback)
        {
            if (callbackTypes.ContainsKey(callback))
            {
                return callbackTypes[callback];
            }
            return EventCallbackType.NOT_FOUND;
        }

        public EventCallbackType TypeForCallback(EventCallback callback)
        {
            if (callbackTypes.ContainsKey(callback))
            {
                return callbackTypes[callback];
            }
            return EventCallbackType.NOT_FOUND;
        }

        new public IEventBinding Bind(object key)
        {
            return base.Bind(key) as IEventBinding;
        }

        public IEventBinding To(EventCallback value)
        {
            base.To(value);
            storeMethodType(value as Delegate);
            return this;
        }

        public IEventBinding To(EmptyCallback value)
        {
            base.To(value);
            storeMethodType(value as Delegate);
            return this;
        }

        new public IEventBinding To(object value)
        {
            base.To(value);
            storeMethodType(value as Delegate);
            return this;
        }

        override public void RemoveValue(object value)
        {
            base.RemoveValue(value);
            callbackTypes.Remove(value as Delegate);
        }

        private void storeMethodType(Delegate value)
        {
            if (value == null)
            {
                throw new DispatcherException("EventDispatcher can't map something that isn't a delegate'", DispatcherExceptionType.ILLEGAL_CALLBACK_HANDLER);
            }
            MethodInfo methodInfo = value.Method;
            int argsLen = methodInfo.GetParameters().Length;
            switch (argsLen)
            {
                case 0:
                    callbackTypes[value] = EventCallbackType.NO_ARGUMENTS;
                    break;
                case 1:
                    callbackTypes[value] = EventCallbackType.ONE_ARGUMENT;
                    break;
                default:
                    throw new DispatcherException("Event callbacks must have either one or no arguments", DispatcherExceptionType.ILLEGAL_CALLBACK_HANDLER);
            }
        }
    }
}
