using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Ioc.framework.api
{
    public interface IBinding
    {
        /// <summary>
        /// Tie this binding to a Type key.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        IBinding Bind<T>();

        /// <summary>
        /// Tie this binding to a value key,such as a string or class instance.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        IBinding Bind(object key);

        /// <summary>
        /// Set the Binding's value to a Type.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        IBinding To<T>();

        /// <summary>
        /// Set the Binding's value to a value,such as a string or class instance.
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        IBinding To(object o);

        /// <summary>
        /// Qualify a binding using a marker type.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        IBinding ToName<T>();

        /// <summary>
        /// Qualify a binding using a value,such as a string or class instance.
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        IBinding ToName(object o);

        /// <summary>
        /// Retrieve a binding if the supplied name matches,by Type.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        IBinding Named<T>();

        /// <summary>
        /// Retrieve a binding if the supplied name matches,by value.
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        IBinding Named(object o);

        /// <summary>
        /// Remove a specific key from the binding.
        /// </summary>
        /// <param name="o"></param>
        void RemoveKey(object o);

        /// <summary>
        /// Remove a specific value from the binding.
        /// </summary>
        /// <param name="o"></param>
        void RemoveValue(object o);

        /// <summary>
        /// Remove a name from the binding.
        /// </summary>
        /// <param name="o"></param>
        void RemoveName(object o);

        /// <summary>
        /// Get the binding's key.
        /// </summary>
        object key { get; }
        /// <summary>
        /// Get the binding's name.
        /// </summary>
        object name { get; }
        /// <summary>
        /// Get the binding's value.
        /// </summary>
        object value { get; }
        /// <summary>
        /// Get or set a MANY or ONE constraint on the Key.
        /// </summary>
        Enum keyConstraint { get; set; }
        /// <summary>
        /// Get or set a MANY or ONE constraint on the key.
        /// </summary>
        Enum valueConstraint { get; set; }
        /// <summary>
        /// Mark a binding as weak,so that any new binding will override it.
        /// </summary>
        IBinding Weak();

        /// <summary>
        /// Get whether or not the binding is weak,default false.
        /// </summary>
        bool isWeak { get; }
    }
}
