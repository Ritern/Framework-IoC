using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Ioc.extensions.reflector.api;
using Assets.Ioc.framework.api;

namespace Assets.Ioc.extensions.injector.api
{
    public interface IInjector
    {
        /// <summary>
        /// Request an instantiation based on the given binding.
        /// </summary>
        /// <param name="binding"></param>
        /// <returns></returns>
        object Instantiate(IInjectionBinding binding);

        /// <summary>
        /// Request that the provided target be injected.
        /// </summary>
        /// <param name="target"></param>
        /// <returns></returns>
        object Inject(object target);

        /// <summary>
        /// Request that the provided target be injected.
        /// </summary>
        /// <param name="target"></param>
        /// <param name="attemptConstructorInjection"></param>
        /// <returns></returns>
        object Inject(object target, bool attemptConstructorInjection);

        /// <summary>
        /// Clear the injections from the provided instance.
        /// Note that Uninject can only clean public properties...therefore only
        /// setters will be uninjected...not injections provided via constructor injection.
        /// </summary>
        /// <param name="target"></param>
        void Uninject(object target);

        /// <summary>
        /// Get or set an InjectorFactory
        /// </summary>
        IInjectorFactory factory { get; set; }

        /// <summary>
        /// Get or set an InjectionBinder.
        /// </summary>
        IInjectionBinder binder { get; set; }

        /// <summary>
        /// Get or set a ReflectionBinder.
        /// </summary>
        IReflectionBinder reflector { get; set; }
    }
}
