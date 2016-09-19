/*----------------------------------------------------------------
            // Copyright © 2014-2016 Air2000
            // 
            // FileName: IInjectionBinding.cs
			// Describle:
			// Created By:  Wells Hsu
			// Date&Time:  2016/9/17 19:56:26
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
    public interface IInjectionBinding : IBinding
    {
        /// <summary>
        /// CN:
        /// <para></para>
        /// EN: Map the Binding to a Singleton so that every 'GetInstance()' on the Binder Key returns the same instance.
        /// </summary>
        /// <returns></returns>
        IInjectionBinding ToSingleton();

        /// <summary>
        /// CN:
        /// <para></para>
        /// EN: Map the Binding to a stated instance so that every 'GetInstance()' on the Bindet Key returns the provided instance.
        /// </summary>
        /// <returns></returns>
        IInjectionBinding ToValue(object o);

        /// <summary>
        /// CN:
        /// <para></para>
        /// EN: Map the Binding to a stated instance so that every 'GetInstance()' on the Binder Key returns the provided instance.
        /// </summary>
        /// <returns></returns>
        IInjectionBinding SetValue(object o);

        /// <summary>
        /// CN:
        /// <para></para>
        /// EN: Map the binding and give access to all contexts in hierarchy.
        /// </summary>
        /// <returns></returns>
        IInjectionBinding CrossContext();
        bool isCrossContext { get; }

        /// <summary>
        /// CN:
        /// <para></para>
        /// EN: Boolean setter to optionally override injection.If false,the instance will not be injected after instantiation.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        IInjectionBinding ToInject(bool value);

        bool toInject { get; }

        /// <summary>
        /// CN:
        /// <para></para>
        /// EN: Get and set the InjectionBindingType.
        /// </summary>
        InjectionBindingType type { get; set; }

        /// <summary>
        /// CN:
        /// <para></para>
        /// Bind is the same as Key,but permits Binder syntax: 'Bind<T>().Bind<T>()'
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        new IInjectionBinding Bind<T>();

        /// <summary>
        /// CN:
        /// <para></para>
        /// Bind is the same as Key,but permits Binder syntax: 'Bind<T>().Bind<T>()'
        /// </summary>
        /// <typeparam name="T"></typeparam>
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
