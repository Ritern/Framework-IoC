using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Ioc.framework.api
{
    public enum BindingConstraintType
    {
        /// <summary>
        /// Constrains a SemiBinding to carry no more than one item in its Value.
        /// </summary>
        ONE,
        /// <summary>
        /// Constrains a SemiBinding to carry a list of items in its Value.
        /// </summary>
        MANY,
        /// <summary>
        /// Instructs the Binding to apply a Pool instead of a SemiBinding.
        /// </summary>
        POOL,
    }
}
