using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Ioc.extensions.injector.api
{
    public enum InjectionBindingType
    {
        /// <summary>
        /// The binding provides a new instance every time.
        /// </summary>
        DEFAULT,

        /// <summary>
        /// The binding always provides the same instance.
        /// </summary>
        SINGLETON,

        /// <summary>
        /// The binding always provides the same instance based on a provided value.
        /// </summary>
        VALUE,
    }
}
