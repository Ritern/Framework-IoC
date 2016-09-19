/*----------------------------------------------------------------
            // Copyright © 2014-2016 Air2000
            // 
            // FileName: ICrossContextInjectionBinder.cs
			// Describle:
			// Created By:  Wells Hsu
			// Date&Time:  2016/9/17 19:56:05
            // Modify History:
            //
//----------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Air2000.IoC.Extensions.Injector
{
    public interface ICrossContextInjectionBinder:IInjectionBinder
    {
        /// <summary>
        /// CN:
        /// <para></para>
        /// EN: Cross-Context Injection Binder is shared across all child contexts.
        /// </summary>
        IInjectionBinder CrossContextBinder { get; set; }
    }
}
