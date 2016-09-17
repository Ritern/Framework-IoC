using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Ioc.framework.api;

namespace Assets.Ioc.extensions.injector.api
{
    public interface IInjectionBinding : IBinding
    {
        /// <summary>
        /// Map the Binding to a Singleton so that every 'GetInstance()' on the Binder Key returns the same instance.
        /// </summary>
        /// <returns></returns>
        IInjectionBinding ToSingleton();

        /// <summary>
        /// Map the Binding to a stated instance so that every 'GetInstance()' on the Binder Key returns the provided instance.
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        IInjectionBinding ToValue(object o);

        /// <summary>
        /// Map the Binding to a stated instance so that every 'GetInstance()' on the Binder Key returns the provided instance.
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        IInjectionBinding SetValue(object o);

        /// <summary>
        /// Map the binding and give access to all contexts in hierarchy.
        /// </summary>
        /// <returns></returns>
        IInjectionBinding CrossContext();

        bool isCrossContext { get; }

        /// <summary>
        /// Boolean setter to optionally override injection.If false,the instance will not be injected after instantiation.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        IInjectionBinding ToInject(bool value);

        /// <summary>
        /// Get the parameter that specifies whether this Binding allows an instance to be injected.
        /// </summary>
        bool toInject { get; }

        /// <summary>
        /// Get and set the InjectionBindingType.
        /// </summary>
        InjectionBindingType type { get; set; }

        /// <summary>
        /// Bind is the same as Key,but permits Binder synatx: 'Bind<T>().Bind<T>();'.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        new IInjectionBinding Bind<T>();

        /// <summary>
        /// Bind is the same as Key,but permits Binder synatx: 'Bind<T>().Bind<T>();'.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        new IInjectionBinding Bind(object key);

        new IInjectionBinding To<T>();
        new IInjectionBinding To(object o);
        new IInjectionBinding ToName<T>();
        new IInjectionBinding ToName(object o);
        new IInjectionBinding Named<T>();
        new IInjectionBinding Named(object o);


        new object key { get; }
        new object name { get; }
        new object value { get; }
        new Enum keyConstraint { get; set; }
        new Enum valueConstraint { get; set; }
    }
}
