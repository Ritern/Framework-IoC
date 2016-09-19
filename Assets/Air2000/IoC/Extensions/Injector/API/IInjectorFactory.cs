/*----------------------------------------------------------------
            // Copyright © 2014-2016 Air2000
            // 
            // FileName: IInjectorFactory.cs
			// Describle:
			// Created By:  Wells Hsu
			// Date&Time:  2016/9/17 19:56:45
            // Modify History:
            //
//----------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Air2000.IoC.Extensions.Injector
{
    public interface IInjectorFactory
    {
        /// <summary>
        /// Request instantiation based on the provided binding.
        /// </summary>
        /// <param name="binding"></param>
        /// <returns></returns>
        object Get(IInjectionBinding binding);

        /// <summary>
        /// Request instantiation based on the provided binding and an array of Constructor arguments.
        /// </summary>
        /// <param name="binding"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        object Get(IInjectionBinding binding, object[] args);
    }
}
