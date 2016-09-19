/*----------------------------------------------------------------
            // Copyright © 2014-2016 Air2000
            // 
            // FileName: CrossContextInjectionBinder.cs
			// Describle:
			// Created By:  Wells Hsu
			// Date&Time:  2016/9/17 20:00:43
            // Modify History:
            //
//----------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Air2000.IoC.Core;

namespace Air2000.IoC.Extensions.Injector
{
    public class CrossContextInjectionBinder : InjectionBinder, ICrossContextInjectionBinder
    {
        public IInjectionBinder CrossContextBinder { get; set; }
        public CrossContextInjectionBinder() : base() { }
        public override IInjectionBinding GetBinding<T>()
        {
            return GetBinding(typeof(T), null);
        }

        public override IInjectionBinding GetBinding<T>(object name)
        {
            return GetBinding(typeof(T), name);
        }

        public override IInjectionBinding GetBinding(object key)
        {
            return GetBinding(key, null);
        }

        public override IInjectionBinding GetBinding(object key, object name)
        {
            IInjectionBinding binding = base.GetBinding(key, name) as IInjectionBinding;
            if (binding == null)
            {
                if (CrossContextBinder != null)
                {
                    binding = CrossContextBinder.GetBinding(key, name) as IInjectionBinding;
                }
            }

            return binding;
        }

        public override void ResolveBinding(IBinding binding, object key)
        {
            // Decide whether to resolve locally or not.
            if (binding is IInjectionBinding)
            {
                InjectionBinding injectionBinding = (InjectionBinding)binding;
                if (injectionBinding.isCrossContext)
                {
                    if (CrossContextBinder == null) // We are a crosscontextbinder.
                    {
                        base.ResolveBinding(binding, key);
                    }
                    else
                    {
                        Unbind(key, binding.name); // remove this cross context binding from the local binder.
                        CrossContextBinder.ResolveBinding(binding, key);
                    }
                }
                else
                {
                    base.ResolveBinding(binding, key);
                }
            }
        }
        protected override IInjector GetInjectorForBinding(IInjectionBinding binding)
        {
            if (binding.isCrossContext && CrossContextBinder != null)
            {
                return CrossContextBinder.injector;
            }
            else
            {
                return injector;
            }
        }
    }
}
