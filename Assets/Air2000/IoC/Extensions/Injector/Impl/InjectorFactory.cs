/*----------------------------------------------------------------
            // Copyright © 2014-2016 Air2000
            // 
            // FileName: InjectorFactory.cs
			// Describle:
			// Created By:  Wells Hsu
			// Date&Time:  2016/9/17 20:02:43
            // Modify History:
            //
//----------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Air2000.IoC.Extensions.Injector
{
    public class InjectorFactory : IInjectorFactory
    {
        public InjectorFactory() { }

        public object Get(IInjectionBinding binding, object[] args)
        {
            if (binding == null)
            {
                throw new InjectionException("InjectorFactory cannot act on null binding", InjectionExceptionType.NULL_BINDING);
            }
            InjectionBindingType type = binding.type;
            switch (type)
            {
                case InjectionBindingType.SINGLETON:
                    return singletonOf(binding, args);
                case InjectionBindingType.VALUE:
                    return valueOf(binding);
                default:
                    break;
            }
            return instanceOf(binding, args);
        }

        public object Get(IInjectionBinding binding)
        {
            return Get(binding, null);
        }

        protected object singletonOf(IInjectionBinding binding, object[] args)
        {
            if (binding.value != null)
            {
                if (binding.value.GetType().IsInstanceOfType(typeof(Type)))
                {
                    object o = createFromValue(binding.value, args);
                    if (o == null)
                        return null;
                    binding.SetValue(o);
                }
                else
                {

                }
            }
            else
            {
                binding.SetValue(generateImplicit((binding.key as object[])[0], args));
            }
            return binding.value;
        }

        protected object generateImplicit(object key, object[] args)
        {
            Type type = key as Type;
            if (!type.IsInterface && !type.IsAbstract)
            {
                return createFromValue(key, args);
            }
            throw new InjectionException("InjectorFactory can't instantiate an Interface or Abstract Class. Class: " + key.ToString(), InjectionExceptionType.NOT_INSTANTIABLE);
        }

        protected object valueOf(IInjectionBinding binding)
        {
            return binding.value;
        }

        protected object instanceOf(IInjectionBinding binding, object[] args)
        {
            if (binding.value != null)
            {
                return createFromValue(binding.value, args);
            }
            object value = generateImplicit((binding.key as object[])[0], args);
            return createFromValue(value, args);
        }

        protected object createFromValue(object o, object[] args)
        {
            Type value = (o is Type) ? o as Type : o.GetType();
            object retv = null;
            try
            {
                if (args == null || args.Length == 0)
                {
                    retv = Activator.CreateInstance(value);
                }
                else
                {
                    retv = Activator.CreateInstance(value, args);
                }
            }
            catch
            {

            }
            return retv;
        }
    }
}
