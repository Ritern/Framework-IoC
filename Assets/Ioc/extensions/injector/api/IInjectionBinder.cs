using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Ioc.framework.api;

namespace Assets.Ioc.extensions.injector.api
{
    public interface IInjectionBinder:IInstanceProvider
    {
        /// <summary>
        /// Get or set an Injector to use.By default,Injector instantiates it's own,but that can be overridden.
        /// </summary>
        IInjector injector { get; set; }

        /// <summary>
        /// Retrieve an Instance based on a key/name combo.
        /// i.e. 'injectionBinder.Get(typeof(ISomeInterface),SomeEnum.MY_ENUM);'.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        object GetInstance(Type key, object name);

        /// <summary>
        /// Retrieve an Instance based on a key/name combo.
        /// i.e. 'injectionBinder.Get<ISomeInterface>(SomeEnum.MY_ENUM);'.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="name"></param>
        /// <returns></returns>
        T GetInstance<T>(object name);

        /// Reflect all the types in the list
		/// Return the number of types in the list, which should be equal to the list length
		int Reflect(List<Type> list);

        /// Reflect all the types currently registered with InjectionBinder
        /// Return the number of types reflected, which should be equal to the number
        /// of concrete classes you've mapped.
        int ReflectAll();

        /// <summary>
        /// Places individual Bindings into the bindings Dictionary as part of the resolving process
        /// </summary>
        /// Note that while some Bindings may store multiple keys, each key takes a unique position in the
        /// bindings Dictionary.
        /// 
        /// Conflicts in the course of fluent binding are expected, but GetBinding
        /// will throw an error if there are any unresolved conflicts.
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
