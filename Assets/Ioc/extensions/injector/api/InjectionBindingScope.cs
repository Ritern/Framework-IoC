using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Ioc.extensions.injector.api
{
    public enum InjectionBindingScope
    {
        /// <summary>
        /// Scope is limited to the context Context.
        /// </summary>
        SINGLE_CONTEXT,

        /// <summary>
        /// Scope is mapped across all Contexts.
        /// </summary>
        CROSS_CONTEXT,
    }
}
