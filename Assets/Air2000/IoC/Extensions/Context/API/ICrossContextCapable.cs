/*----------------------------------------------------------------
            // Copyright © 2014-2016 Air2000
            // 
            // FileName: ICrossContextCapable.cs
			// Describle:
			// Created By:  Wells Hsu
			// Date&Time:  2016/9/18 11:04:38
            // Modify History:
            //
//----------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Air2000.IoC.Extensions.Injector;

namespace Air2000.IoC.Extensions.Context
{
    public interface ICrossContextCapable
    {
        /// <summary>
        /// CN:
        /// <para></para>
        /// EN: Add cross-context functionality to a child context being added.
        /// </summary>
        /// <param name="childContext"></param>
        void AssignCrossContext(ICrossContextCapable childContext);

        /// <summary>
        /// CN:
        /// <para></para>
        /// EN: Clean up cross-context functionality from a child context being removed.
        /// </summary>
        /// <param name="childContext"></param>
        void RemoveCrossContext(ICrossContextCapable childContext);

        /// <summary>
        /// CN:
        /// <para></para>
        /// EN: Request a component from the context (might be useful in certain cross-context situations)
        ///     This is technically a deprecated methodlogy.Bind using CrossContext() instead.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        object GetComponent<T>();

        /// <summary>
        /// CN:
        /// <para></para>
        /// EN: Request a component from the context (might be useful in certain cross-context situations)
        ///     This is technically a deprecated methodlogy.Bind using CrossContext() instead.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        object GetComponent<T>(object name);

        /// <summary>
        /// CN:
        /// <para></para>
        /// EN: All cross-context capable contexts must implement an injectionBinder.
        /// </summary>
        ICrossContextInjectionBinder injectionBinder { get; set; }
    }
}
