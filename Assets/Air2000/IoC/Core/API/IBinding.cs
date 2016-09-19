/*----------------------------------------------------------------
            // Copyright © 2014-2016 Air2000
            // 
            // FileName: IBinding.cs
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
    /// CN: 绑定一个SemiBinding类型的Key值 至 一个SemiBinding类型的Value值。
    ///     Bindings 是框架中最小的元素，开发过程中我们可能会与之打交道。
    /// <para></para>
    /// EN: Binds a key SemiBinding to a value SemiBinding.
    ///     Bindings represent the smallest element of framework with which most
    ///     developers will normally interact.
    /// </summary>
    public interface IBinding
    {
        /// <summary>
        /// CN: 将当前的Binding 绑定至一个 Type 类型的Key.
        /// <para></para>
        /// EN: Tie this binding to a Type key.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        IBinding Bind<T>();

        /// <summary>
        /// CN: 将当前的Binding 绑定至一个 值类型的Key，类似字符串或者object instance.
        /// <para></para>
        /// EN: Tie this binding to a value key,such as a string or class instance.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        IBinding Bind(object key);

        /// <summary>
        /// CN: 设置当前Binding的Value，类型为Type.
        /// <para></para>
        /// EN: Set the Binding's value to a Type.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        IBinding To<T>();

        /// <summary>
        /// CN: 设置当前Binding的Value，类型为object instance.
        /// <para></para>
        /// EN: Set the Binding's value to a value,such as a string or class instance.
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        IBinding To(object o);

        /// <summary>
        /// CN: 用类型填充Name来限制一个Binding.
        /// <para></para>
        /// EN: Qualify a binding using a marker type.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        IBinding ToName<T>();

        /// <summary>
        /// CN: 用值类型填充Name来限制一个Binding.
        /// <para></para>
        /// EN: Qualify a binding using a value.
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        IBinding ToName(object o);

        /// <summary>
        /// CN: 检索并返回一个类型匹配的Binding.
        /// <para></para>
        /// EN: Retrieve a binding if supplied name matches,by Type.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        IBinding Named<T>();

        /// <summary>
        /// CN: 检索并返回一个值类型匹配的Binding.
        /// <para></para>
        /// EN: Retrieve a binding if supplied name matches,by value.
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        IBinding Named(object o);

        /// <summary>
        /// CN: 从当前Binding 中移除一个Key.
        /// <para></para>
        /// EN: Remove a specific key from the binding.
        /// </summary>
        /// <param name="o"></param>
        void RemoveKey(object o);

        /// <summary>
        /// CN: 从当前Binding 中移除一个Value.
        /// <para></para>
        /// EN: Remove a specific value from the binding.
        /// </summary>
        /// <param name="o"></param>
        void RemoveValue(object o);

        /// <summary>
        /// CN: 从当前Binding 中移除一个Name.
        /// <para></para>
        /// EN: Remove a name from the binding.
        /// </summary>
        /// <param name="o"></param>
        void RemoveName(object o);

        /// <summary>
        /// CN: 从当前Binding 中移除一个Name.
        /// <para></para>
        /// EN: Remove a name from the binding.
        /// </summary>
        object key { get; }

        /// <summary>
        /// CN: 从当前Binding 中移除一个Name.
        /// <para></para>
        /// EN: Remove a name from the binding.
        /// </summary>
        object name { get; }

        /// <summary>
        /// CN: 从当前Binding 中移除一个Name.
        /// <para></para>
        /// EN: Remove a name from the binding.
        /// </summary>
        object value { get; }

        /// <summary>
        /// CN: 获取或设置当前binding Key 的约束.
        /// <para></para>
        /// EN: Get or set a MANY or ONE constraint on the Key.
        /// </summary>
        Enum keyConstraint { get; set; }

        /// <summary>
        /// CN: 获取或设置当前binding Value 的约束.
        /// <para></para>
        /// EN: Get or set a MANY or ONE constraint on the Key.
        /// </summary>
        Enum valueConstraint { get; set; }

        /// <summary>
        /// CN: 标注当前binding是否弱引用，所有新的Binding可以重写它.
        /// <para></para>
        /// EN: Mark a binding as weak, so that any new binding will override it.
        /// </summary>
        IBinding Weak();

        /// <summary>
        /// CN: 获取当前Binding是否弱引用，默认值为False.
        /// <para></para>
        /// EN: Get whether or not the binding is weak, default false.
        /// </summary>
        bool isWeak { get; }
    }
}
