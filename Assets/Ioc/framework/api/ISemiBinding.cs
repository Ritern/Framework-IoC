using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Ioc.framework.api
{
    /// <summary>
    /// SemiBinding
    /// </summary>
    public interface ISemiBinding : IManagedList
    {
        /// <summary>
        /// Set or get the constraint.
        /// </summary>
        Enum constraint { get; set; }

        /// <summary>
        /// A secondary constraint that ensures that this SemiBinding will never contain multiple values equivalent to each other.
        /// </summary>
        bool uniqueValues { get; set; }
    }
}
