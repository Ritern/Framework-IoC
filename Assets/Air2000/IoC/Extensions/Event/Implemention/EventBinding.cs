/*----------------------------------------------------------------
            // Copyright © 2014-2016 Air2000
            // 
            // FileName: EventBinding.cs
			// Describle:
			// Created By:  Wells Hsu
			// Date&Time:  2016/9/14 11:56:56
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
    public class EventBinding : Binding, IEventBinding
    {
        public EventBinding() : this(null) { }
        public EventBinding(Binder.BindingResolver resolver) : base(resolver)
        {
            keyConstraint = BindingConstraintType.ONE;
            valueConstraint = BindingConstraintType.MANY;
            nameConstraint = BindingConstraintType.ONE;
        }
        new public IEventBinding Bind(object key)
        {
            return base.Bind(key) as IEventBinding;
        }
        public IEventBinding To(EventHandlerDelegate handler)
        {
            base.To(handler);
            return this;
        }
        public IEventBinding To(EventHandlerDelegateEX handler)
        {
            base.To(handler);
            return this;
        }
        new public IEventBinding To(object value)
        {
            base.To(value);
            return this;
        }
    }
}
