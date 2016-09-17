﻿/*----------------------------------------------------------------
            // Copyright © 2014-2016 Air2000
            // 
            // FileName: EventProcessor.cs
			// Describle:
			// Created By:  Wells Hsu
			// Date&Time:  2016/9/14 11:57:06
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
    public class EventProcessor : Binder, IEventProcessor
    {
        public override IBinding GetRawBinding()
        {
            return new EventBinding(resolver);
        }
        new public IEventBinding Bind(object key)
        {
            return base.Bind(key) as IEventBinding;
        }
        public void Register(object eventID, EventHandlerDelegate handler)
        {
            IBinding binding = GetBinding(eventID);
            if (binding == null)
            {
                Bind(eventID).To(handler);
            }
            else
            {
                binding.To(handler);
            }
        }
        public void Register(object eventID, EventHandlerDelegateEX handler)
        {
            IBinding binding = GetBinding(eventID);
            if (binding == null)
            {
                Bind(eventID).To(handler);
            }
            else
            {
                binding.To(handler);
            }
        }
        public void Notify(object eventID, object data = null)
        {
            IBinding binding = GetBinding(eventID);
            if (binding != null)
            {
                object[] callbacks = binding.value as object[];
                if (callbacks != null && callbacks.Length > 0)
                {
                    for (int i = 0; i < callbacks.Length; i++)
                    {
                        object callback = callbacks[i];
                        if (callback == null) continue;
                        if (callback is EventHandlerDelegate)
                        {
                            (callback as EventHandlerDelegate)();
                        }
                        else if (callback is EventHandlerDelegateEX)
                        {
                            (callback as EventHandlerDelegateEX)(data);
                        }
                    }
                }
            }
        }
        public void Unregister(object eventID, EventHandlerDelegate handler)
        {
            IBinding binding = GetBinding(eventID);
            if (binding != null)
            {
                binding.RemoveValue(handler);
            }
        }
        public void Unregister(object eventID, EventHandlerDelegateEX handler)
        {
            IBinding binding = GetBinding(eventID);
            if (binding != null)
            {
                binding.RemoveValue(handler);
            }
        }
    }
}
