using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Ioc.extensions.pool.api
{
    public interface IPoolable
    {
        /// <summary>
        /// Clean up this instance for reuse.
        /// </summary>
        void Restore();

        /// <summary>
        /// Keep this instance from being returned to the pool.
        /// </summary>
        void Retain();

        /// <summary>
        /// Release this instance back to the pool.
        /// </summary>
        void Release();

        /// <summary>
        /// Is this instance retained?
        /// </summary>
        bool retain { get; }
    }
}
