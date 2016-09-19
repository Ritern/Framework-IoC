/*----------------------------------------------------------------
            // Copyright © 2014-2016 Air2000
            // 
            // FileName: IInjector.cs
			// Describle:
			// Created By:  Wells Hsu
			// Date&Time:  2016/9/17 19:56:36
            // Modify History:
            //
//----------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Air2000.IoC.Extensions.Reflector;

namespace Air2000.IoC.Extensions.Injector
{
    public interface IInjector
    {
        /// <summary>
        /// CN:
        /// <para></para>
        /// EN: Request an instantiation based on the given binding.
        ///     This request is made to the Injector,but it's really the InjectionFactory that does the instatiation.
        /// </summary>
        /// <param name="binding"></param>
        /// <returns></returns>
        object Instantiate(IInjectionBinding binding);

        /// <summary>
        /// CN:
        /// <para></para>
        /// EN: Requset that the provided target be injected.
        /// </summary>
        /// <param name="target"></param>
        /// <returns></returns>
        object Inject(object target);

        /// <summary>
        /// CN:
        /// <para></para>
        /// EN: Requset that the provided target be injected.
        /// </summary>
        /// <param name="target"></param>
        /// <returns></returns>
        object Inject(object target, bool attemptConstructorInjection);

        /// <summary>
        /// CN:
        /// <para></para>
        /// EN: Clear the injections from the provided instance.
        ///     Note that Uninject can only clean public properties...therefore only
        ///     setters will be uninjected...not injections provided via constructor injection.
        /// </summary>
        /// <param name="target"></param>
        void Uninject(object target);

        IInjectorFactory factory { get; set; }

        IInjectionBinder binder { get; set; }

        IReflectionBinder reflector { get; set; }
    }
}
