/*----------------------------------------------------------------
            // Copyright © 2014-2016 Air2000
            // 
            // FileName: ContextKeys.cs
			// Describle:
			// Created By:  Wells Hsu
			// Date&Time:  2016/9/18 20:35:12
            // Modify History:
            //
//----------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Air2000.IoC.Extensions.Context
{
    public enum ContextKeys
    {
        /// <summary>
        /// Marker for the named Injection of the Context.
        /// </summary>
        CONTEXT,

        /// <summary>
        /// Marker for the named Injection of the ContextView.
        /// </summary>
        CONTEXT_VIEW,

        /// <summary>
        /// Marker for the named Injection of the contextDispatcher.
        /// </summary>
        CONTEXT_DISPATCHER,

        /// <summary>
        /// Marker for the named Injection of the crossContextDispatcher.
        /// </summary>
        CROSS_CONTEXT_DISPATCHER,
    }
}
