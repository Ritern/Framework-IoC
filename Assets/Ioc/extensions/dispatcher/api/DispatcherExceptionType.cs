using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Ioc.extensions.dispatcher.api
{
    public enum DispatcherExceptionType
    {
        /// <summary>
        /// Injector Factory not found.
        /// </summary>
        NULL_FACTORY,

        /// <summary>
        /// Callback must be a Delegate with zero or one argument.
        /// </summary>
        ILLEGAL_CALLBACK_HANDLER
    }
}
