/*----------------------------------------------------------------
            // Copyright © 2014-2016 Air2000
            // 
            // FileName: IReflectionBinder.cs
			// Describle:
			// Created By:  Wells Hsu
			// Date&Time:  2016/9/17 19:00:36
            // Modify History:
            //
//----------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Air2000.IoC.Extensions.Reflector
{
    public interface IReflectionBinder
    {
        /// <summary>
        /// CN:
        /// <para></para>
        /// EN: Get a binding based on the provided Type.
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        IReflectedClass Get(Type type);

        /// <summary>
        /// CN:
        /// <para></para>
        /// EN: Get a binding based on the provided Type generic.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        IReflectedClass Get<T>();
    }
}
