/*----------------------------------------------------------------
            // Copyright © 2014-2016 Air2000
            // 
            // FileName: IBinder.cs
			// Describle:
			// Created By:  Wells Hsu
			// Date&Time:  2016/9/14 10:06:40
            // Modify History:
            //
//----------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Air2000.IoC.Core
{
    /// <summary>
    /// CN: Binder 是一个类似集合的类。主要的目的是在一些互相没有联系的类之间
    ///     建立起连接。Binder 是整个框架的核心。
    /// <para></para>
    /// EN: Binders are a collection class (akin to ArrayList and Dictionary)
    ///     with the specific purpose of connection lists of things that are
    ///     not necessarily related,but need some type of runtime association.
    ///     Binders are the core concept of the framework,allowing all the other
    ///     functionality to exist and further functionality to easily be created.
    ///     
    ///     Think of each Binders as a collection of causes and effects,or actions
    ///     and reactions.If the key action happens , it triggers the Value action.
    ///     So,for example,an Event may be the key that triggers
    ///     instantiation of a particular class.
    /// </summary>
    public interface IBinder
    {
        /// <summary>
        /// CN: 绑定一个Binding Key 至一个类或者类接口。
        /// <para></para>
        /// EN: Bind a Binding Key to a class or interface generic.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
		IBinding Bind<T>();

        /// <summary>
        /// CN: 绑定一个Binding Key 至一个 值。
        /// <para></para>
        /// EN: Bind a Binding Key to a value.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        IBinding Bind(object value);

        /// <summary>
        /// CN: 根据提供的 类型检索并返回一个Binding instance.
        /// <para></para>
        /// EN: Retrieve a binding based on the provided Type.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        IBinding GetBinding<T>();

        /// <summary>
        /// CN: 根据提供的 值检索并返回一个Binding instance.
        /// <para></para>
        /// EN: Retrieve a binding based on the provided object
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        IBinding GetBinding(object key);

        /// <summary>
        /// CN: 
        /// <para></para>
        /// EN: Retrieve a binding based on the provided Key (generic)/Name combo.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="name"></param>
        /// <returns></returns>
        IBinding GetBinding<T>(object name);

        /// <summary>
        /// CN: 
        /// <para></para>
        /// EN: Retrieve a binding based on the provided Key/Name combo.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        IBinding GetBinding(object key, object name);

        /// <summary>
        /// CN: 
        /// <para></para>
        /// EN: Generate an unpopulated IBinding in whatever concrete form the Binder dictates.
        /// </summary>
        /// <returns></returns>
        IBinding GetRawBinding();

        /// <summary>
        /// CN: 
        /// <para></para>
        /// EN: Remove a binding based on the provided Key (generic).
        /// </summary>
        /// <typeparam name="T"></typeparam>
        void Unbind<T>();

        /// <summary>
        /// CN: 
        /// <para></para>
        /// EN: Remove a binding based on the provided Key (generic) / Name combo.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="name"></param>
        void Unbind<T>(object name);

        /// <summary>
        /// CN: 
        /// <para></para>
        /// EN: Remove a binding based on the provided Key.
        /// </summary>
        /// <param name="key"></param>
        void Unbind(object key);

        /// <summary>
        /// CN: 
        /// <para></para>
        /// EN: Remove a binding based on the provided Key / Name combo.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="name"></param>
        void Unbind(object key, object name);

        /// <summary>
        /// CN: 
        /// <para></para>
        /// EN: Remove the provided binding from the Binder.
        /// </summary>
        /// <param name="binding"></param>
        void Unbind(IBinding binding);

        /// <summary>
        /// CN: 
        /// <para></para>
        /// EN: Remove a select value from the given binding.
        /// </summary>
        /// <param name="binding"></param>
        /// <param name="value"></param>
        void RemoveValue(IBinding binding, object value);

        /// <summary>
        /// CN: 
        /// <para></para>
        /// EN: Remove a select key from the given binding.
        /// </summary>
        /// <param name="binding"></param>
        /// <param name="value"></param>
        void RemoveKey(IBinding binding, object value);

        /// <summary>
        /// CN: 
        /// <para></para>
        /// EN: Remove a select name from the given binding.
        /// </summary>
        /// <param name="binding"></param>
        /// <param name="value"></param>
        void RemoveName(IBinding binding, object value);

        /// <summary>
        /// CN: 
        /// <para></para>
        /// EN: The Binder is being removed.
        ///     Override this method to clean up remaining bindings.
        /// </summary>
        void OnRemove();

        /// <summary>
        /// CN:
        /// <para></para>
        /// EN: Places individual Bindings into the bindings Dictionary as part of the resolving process
        ///     Note that while some Bindings may store multiple keys, each key takes a unique position in the
        ///     bindings Dictionary.
        ///     Conflicts in the course of fluent binding are expected, but GetBinding
        ///     will throw an error if there are any unresolved conflicts.
        /// </summary>
        void ResolveBinding(IBinding binding, object key);
    }
}
