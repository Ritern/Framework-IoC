using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Ioc.framework.api;
using Assets.Ioc.framework.impl;
using Assets.Ioc.extensions.eventbus.api;
using System.Reflection;

namespace Assets.Ioc.extensions.eventbus.impl
{
    public class EventBinding : Binding, IEventBinding
    {
        private Dictionary<Delegate, EventHandlerType> handlerTypes;
        public EventBinding() : this(null) { }
        public EventBinding(Assets.Ioc.framework.impl.Binder.BindingResolver resolver) : base(resolver)
        {
            keyConstraint = BindingConstraintType.ONE;
            valueConstraint = BindingConstraintType.MANY;
            handlerTypes = new Dictionary<Delegate, EventHandlerType>();
        }

        public EventHandlerType GetHandlerType(EventHandlerDelegate handler)
        {
            if (handlerTypes.ContainsKey(handler))
            {
                return handlerTypes[handler];
            }
            return EventHandlerType.NOT_FOUND;
        }
        public EventHandlerType GetHandlerType(EventHandlerDelegateEX handler)
        {
            if (handlerTypes.ContainsKey(handler))
            {
                return handlerTypes[handler];
            }
            return EventHandlerType.NOT_FOUND;
        }

        new public IEventBinding Bind(object key)
        {
            return base.Bind(key) as IEventBinding;
        }

        public IEventBinding To(EventHandlerDelegate value)
        {
            base.To(value);
            SaveHandlerType(value as Delegate);
            return this;
        }

        public IEventBinding To(EventHandlerDelegateEX value)
        {
            base.To(value);
            SaveHandlerType(value as Delegate);
            return this;
        }

        new public IEventBinding To(object value)
        {
            base.To(value);
            SaveHandlerType(value as Delegate);
            return this;
        }

        public override void RemoveValue(object value)
        {
            base.RemoveValue(value);
            handlerTypes.Remove(value as Delegate);
        }

        private void SaveHandlerType(Delegate value)
        {
            if (value == null)
            {
                throw new Exception("EventProcessor can't map something that isn't a delegate");
            }
            MethodInfo methodInfo = value.Method;
            int argsLen = methodInfo.GetParameters().Length;
            switch (argsLen)
            {
                case 0:
                    handlerTypes[value] = EventHandlerType.NO_ARGUMENTS;
                    break;
                case 1:
                    handlerTypes[value] = EventHandlerType.ONE_ARGUMENT;
                    break;
                default:
                    throw new Exception("Event handler must have either one or no arguments");
            }
        }
    }
}
