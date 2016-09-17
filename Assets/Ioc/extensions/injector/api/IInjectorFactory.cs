using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Ioc.extensions.injector.api
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
