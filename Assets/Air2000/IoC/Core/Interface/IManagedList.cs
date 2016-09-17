/*----------------------------------------------------------------
            // Copyright © 2014-2016 Air2000
            // 
            // FileName: IManagedList.cs
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
    /// CN: 这是一个构成Binding的公共接口，目前是一个SemiBinding 或 Pool.
    ///     ManagedList 提供了对元素的添加/移除等操作.
    /// <para></para>
    /// EN: A common interface for the constituents parts of a Binding,which at present
    ///     are either a SemiBinding or a Pool.A managedList can have objects added or removed.
    /// </summary>
    public interface IManagedList
    {
        /// <summary>
        /// CN: 添加一个元素到列表中.
        /// <para></para>
        /// EN: Add a value to this List.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        IManagedList Add(object value);

        /// <summary>
        /// CN: 添加一个元素集到列表中.
        /// <para></para>
        /// EN: Add a set of values to this List.
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        IManagedList Add(object[] list);

        /// <summary>
        /// CN: 从列表中移除一个元素.
        /// <para></para>
        /// EN: Remove a value from this List.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
		IManagedList Remove(object value);

        /// <summary>
        /// CN: 从列表中移除一个元素集.
        /// <para></para>
        /// EN: Remove a set of values from this List.
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        IManagedList Remove(object[] list);

        /// <summary>
        /// CN: 检索列表中的元素.
        ///     如果限制条件为 ‘MANY’,这个值将是一个数组.
        ///     如果限制条件为 ‘POOL’,意味着和GetInstance()职能相同.
        /// <para></para>
        /// EN: Retrieve the value of this List.
        ///     If the constraint is MANY, the value will be an Array.
        ///     If the constraint is POOL, this becomes a synonym for GetInstance().
        /// </summary>
        object value { get; }
    }
}
