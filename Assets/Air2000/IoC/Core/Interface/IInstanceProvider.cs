/*----------------------------------------------------------------
            // Copyright © 2014-2016 Air2000
            // 
            // FileName: IInstanceProvider.cs
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
    /// CN: 为具体的类提供实例.
    /// <para></para>
    /// EN: Provides an instance of the specified Type.
    ///     When all you need is a new instance,use this instead of IInjectionBinder.
    /// </summary>
    public interface IInstanceProvider
    {
        /// <summary>
        /// CN: 根据类型检索一个实例.
        /// <para></para>
        /// EN: Retrieve an Instance based on the key.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        T GetInstance<T>();

        /// <summary>
        /// CN: 根据类型检索一个实例.
        /// <para></para>
        /// EN: Retrieve an Instance based on the key.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        object GetInstance(Type key);
    }
}
