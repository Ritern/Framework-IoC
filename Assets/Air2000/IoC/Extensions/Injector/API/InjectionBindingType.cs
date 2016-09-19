/*----------------------------------------------------------------
            // Copyright © 2014-2016 Air2000
            // 
            // FileName: InjectionBindingType.cs
			// Describle:
			// Created By:  Wells Hsu
			// Date&Time:  2016/9/17 20:28:20
            // Modify History:
            //
//----------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Air2000.IoC.Extensions.Injector
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
