using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Ioc.framework.api
{
    public interface IBinder {

        /// <summary>
        /// Bind a Binding Key to a class or interface generic.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        IBinding Bind<T>();

        /// <summary>
        /// Bind a Binding Key to a value.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        IBinding Bind(object value);

        /// <summary>
        /// Retrieve a binding based on the provided Type.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        IBinding GetBinding<T>();

        /// <summary>
        /// Retrieve a binding based on the provided Key (generic)/Name combo.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="name"></param>
        /// <returns></returns>
        IBinding GetBinding<T>(object name);

        /// <summary>
        /// Retrieve a binding based on the provided Key/Name combo.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        IBinding GetBinding(object key, object name);

        /// <summary>
        /// Generate an unpopulated IBinding whatever concrete from the Binder dictates.
        /// </summary>
        /// <returns></returns>
        IBinding GetRawBinding();

        /// <summary>
        /// Remove a binding based on the provided Key (generic).
        /// </summary>
        /// <typeparam name="T"></typeparam>
        void Unbind<T>();

        /// <summary>
        /// Remove a binding based on the provided Key (generic) / Name combo.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="name"></param>
        void Unbind<T>(object name);

        /// <summary>
        /// Remove a binding based on the provided Key / Name combo.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="name"></param>
        void Unbind(object key, object name);

        /// <summary>
        /// Remove the provided binding from the binder.
        /// </summary>
        /// <param name="binding"></param>
        void Unbind(IBinding binding);

        /// <summary>
        /// Remove a select value from the given binding.
        /// </summary>
        /// <param name="binding"></param>
        /// <param name="value"></param>
        void RemoveValue(IBinding binding, object value);

        /// <summary>
        /// Remove a select key from the given binding.
        /// </summary>
        /// <param name="binding"></param>
        /// <param name="value"></param>
        void RemoveKey(IBinding binding, object value);

        /// <summary>
        /// Remove a select name from the given binding.
        /// </summary>
        /// <param name="binding"></param>
        /// <param name="value"></param>
        void RemoveName(IBinding binding, object value);

        /// <summary>
        /// The Binder is being removed.
        /// Override this method to clean up remaining bindings.
        /// </summary>
        void OnRemove();

        /// <summary>
        /// Places individual Bindings into the bindings Dictionary as part of the resolving process.
        /// Note that while some Bindings may store multiple keys,each key takes a unique position in 
        /// the bindings Dinctionary.
        /// Conflicts in the course of fluent bindings are expected,but GetBinding
        /// will throw an error if there are any unresolved conflicts.
        /// </summary>
        /// <param name="binding"></param>
        /// <param name="key"></param>
        void ResolveBinding(IBinding binding, object key);
    }

}
