using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Ioc.extensions.injector.api;
using Assets.Ioc.framework.api;
namespace Assets.Ioc.extensions.injector.api
{
    public interface ICrossContextInjectionBinder : IInjectionBinder
    {
        /// <summary>
        /// Cross-context Injection Binder is shaded across all child contexts
        /// </summary>
        IInjectionBinder CrossContextBinder { get; set; }
    }
}
