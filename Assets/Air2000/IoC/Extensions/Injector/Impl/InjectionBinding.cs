/*----------------------------------------------------------------
            // Copyright © 2014-2016 Air2000
            // 
            // FileName: InjectionBinding.cs
			// Describle:
			// Created By:  Wells Hsu
			// Date&Time:  2016/9/17 20:01:56
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
    public class InjectionBinding : Binding, IInjectionBinding
    {
        private InjectionBindingType _type = InjectionBindingType.DEFAULT;
        private bool _toInject = true;
        private bool _isCrossContext = false;

        public InjectionBinding(Binder.BindingResolver resolver)
        {
            this.resolver = resolver;
            keyConstraint = BindingConstraintType.MANY;
            valueConstraint = BindingConstraintType.ONE;
        }

        public InjectionBindingType type
        {
            get
            {
                return _type;
            }
            set
            {
                _type = value;
            }
        }
        public bool toInject
        {
            get { return _toInject; }
        }
        public IInjectionBinding ToInject(bool value)
        {
            _toInject = value;
            return this;
        }
        public bool isCrossContext
        {
            get
            {
                return _isCrossContext;
            }
        }
        public IInjectionBinding ToSingleton()
        {
            //If already a value,this mapping is redundant.
            if (type == InjectionBindingType.VALUE)
                return this;

            type = InjectionBindingType.SINGLETON;
            if(resolver != null)
            {
                resolver(this);
            }
            return this;
        }

        public IInjectionBinding ToValue(object o)
        {
            type = InjectionBindingType.VALUE;
            SetValue(o);
            return this;
        }

        public IInjectionBinding SetValue(object o)
        {
            Type objType = o.GetType();

            object[] keys = key as object[];

            for (int i = 0; i < keys.Length; i++)
            {
                object aKey = keys[i];
                Type keyType = (aKey is Type) ? aKey as Type : aKey.GetType();
                if (keyType.IsAssignableFrom(objType) == false && (HasGenericAssignableFrom(keyType, objType) == false))
                {
                    throw new InjectionException("Injection cannot bind a value that does not extend or implement the binding type.", InjectionExceptionType.ILLEGAL_BINDING_VALUE);
                }
            }
            To(o);
            return this;
        }

        protected bool HasGenericAssignableFrom(Type keyType,Type objType)
        {
            if(keyType.IsGenericType == false)
            {
                return false;
            }
            return true;
        }
        protected bool IsGenericTypeAssignable(Type givenType,Type genericType)
        {
            var interfaceTypes = givenType.GetInterfaces();

            foreach (var it in interfaceTypes)
            {
                if (it.IsGenericType && it.GetGenericTypeDefinition() == genericType)
                    return true;
            }

            if (givenType.IsGenericType && givenType.GetGenericTypeDefinition() == genericType)
                return true;

            Type baseType = givenType.BaseType;
            if (baseType == null) return false;

            return IsGenericTypeAssignable(baseType, genericType);
        }
        public IInjectionBinding CrossContext()
        {
            _isCrossContext = true;
            if(resolver != null)
            {
                resolver(this);
            }
            return this;
        }

        new public IInjectionBinding Bind<T>()
        {
            return base.Bind<T>() as IInjectionBinding;
        }

        new public IInjectionBinding Bind(object key)
        {
            return base.Bind(key) as IInjectionBinding;
        }

        new public IInjectionBinding To<T>()
        {
            return base.To<T>() as IInjectionBinding;
        }

        new public IInjectionBinding To(object o)
        {
            return base.To(o) as IInjectionBinding;
        }

        new public IInjectionBinding ToName<T>()
        {
            return base.ToName<T>() as IInjectionBinding;
        }

        new public IInjectionBinding ToName(object o)
        {
            return base.ToName(o) as IInjectionBinding;
        }

        new public IInjectionBinding Named<T>()
        {
            return base.Named<T>() as IInjectionBinding;
        }

        new public IInjectionBinding Named(object o)
        {
            return base.Named(o) as IInjectionBinding;
        }
    }
}
