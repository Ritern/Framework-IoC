/*----------------------------------------------------------------
            // Copyright © 2014-2016 Air2000
            // 
            // FileName: IInjectionBindingScope.cs
			// Describle:
			// Created By:  Wells Hsu
			// Date&Time:  2016/9/17 19:57:05
            // Modify History:
            //
//----------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Air2000.IoC.Extensions.Injector
{
    public enum InjectionBindingScope
    {
        /// <summary>
        /// Scope is limited to the current Context.
        /// </summary>
        SINGLE_CONTEXT,

        /// <summary>
        /// Scope is mapped across all Contexts.
        /// </summary>
        CROSS_CONTEXT,
    }
}
