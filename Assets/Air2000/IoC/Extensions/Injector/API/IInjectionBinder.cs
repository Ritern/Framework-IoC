/*----------------------------------------------------------------
            // Copyright © 2014-2016 Air2000
            // 
            // FileName: IInjectionBinder.cs
			// Describle:
			// Created By:  Wells Hsu
			// Date&Time:  2016/9/17 19:56:15
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
    public interface IInjectionBinder : IInstanceProvider
    {
        IInjector injector { get; set; }

        /// <summary>
        /// CN:
        /// <para></para>
        /// EN: Retrieve an Instance based on a key/name combo.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        object GetInstance(Type key, object name);

        /// <summary>
        /// CN:
        /// <para></para>
        /// EN: Retrieve an Instance based on a key/name combo.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="name"></param>
        /// <returns></returns>
        T GetInstance<T>(object name);

        /// <summary>
        /// CN:
        /// <para></para>
        /// EN: Relect all the type in the list
        ///     Return the number of types reflected,which should be equal to the list length.
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        int Reflect(List<Type> list);

        /// <summary>
        /// CN:
        /// <para></para>
        /// EN: Reflect all the types currently registered with InjectionBinder.
        ///     Return the number of types reflected,which should be equal to the number
        ///     of concrete classes you've mapped.
        /// </summary>
        /// <returns></returns>
        int ReflectAll();

        /// <summary>
        /// CN:
        /// <para></para>
        /// EN: Places individual Bindings into the bindings Dictionary as part of the resolving process.
        /// </summary>
        /// <param name="binding"></param>
        /// <param name="key"></param>
        void ResolveBinding(IBinding binding, object key);

        IInjectionBinding Bind<T>();
        IInjectionBinding Bind(Type key);
        IBinding Bind(object key);
        IInjectionBinding GetBinding<T>();
        IInjectionBinding GetBinding<T>(object name);
        IInjectionBinding GetBinding(object key);
        IInjectionBinding GetBinding(object key, object name);
        void Unbind<T>();
        void Unbind<T>(object name);
        void Unbind(object key);
        void Unbind(object key, object name);
        void Unbind(IBinding binding);
    }
}
