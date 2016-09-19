/*----------------------------------------------------------------
            // Copyright © 2014-2016 Air2000
            // 
            // FileName: IPooledCommandBinder.cs
			// Describle:
			// Created By:  Wells Hsu
			// Date&Time:  2016/9/18 16:47:50
            // Modify History:
            //
//----------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Air2000.IoC.Extensions.ObjPool;

namespace Air2000.IoC.Extensions.Command
{
    public interface IPooledCommandBinder
    {
        /// <summary>
        /// Retrieve the Pool of the specified type.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        Pool<T> GetPool<T>();

        /// <summary>
        /// Switch to disable pooling for those that don't want to use it.
        /// </summary>
        bool usePooling { get; set; }
    }
}
