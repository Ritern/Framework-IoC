using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Ioc.framework.api
{
    public enum BinderExceptionType {
        /// <summary>
        /// The binder is being used while one or more Bindings are in conflict
        /// </summary>
        CONFLICT_IN_BINDER
    }

}
