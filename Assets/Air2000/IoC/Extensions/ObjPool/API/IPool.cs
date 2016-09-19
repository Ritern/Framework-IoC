/*----------------------------------------------------------------
            // Copyright © 2014-2016 Air2000
            // 
            // FileName: IPool.cs
			// Describle:
			// Created By:  Wells Hsu
			// Date&Time:  2016/9/18 14:05:13
            // Modify History:
            //
//----------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Air2000.IoC.Core;

namespace Air2000.IoC.Extensions.ObjPool
{
    public interface IPool<T> : IPool
    {
        new T GetInstance();
    }

    public interface IPool : IManagedList
    {
        /// <summary>
        /// CN:
        /// <para></para>
        /// EN: A class that provides instances to the pool when it needs them.
        ///     This can be the InjectionBinder,or any class write that satisfies the IInstanceProvider interface.
        /// </summary>
        IInstanceProvider instanceProvider { get; set; }

        /// <summary>
        /// CN:
        /// <para></para>
        /// EN: The object Type of the first object added to the pool.
        ///     Pool objects must be of the same concrete type.This property enforces that requirement.
        /// </summary>
        Type poolType { get; set; }
        object GetInstance();
        void ReturnInstance(object value);
        void Clean();

        int available { get; }

        int size { get; set; }

        int instanceCount { get; }

        PoolOverflowBehavior overflowBehavior { get; set; }

        PoolInflationType inflationType { get; set; }
    }
}
