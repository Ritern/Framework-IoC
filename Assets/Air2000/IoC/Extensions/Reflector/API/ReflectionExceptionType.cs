/*----------------------------------------------------------------
            // Copyright © 2014-2016 Air2000
            // 
            // FileName: ReflectionExceptionType.cs
			// Describle:
			// Created By:  Wells Hsu
			// Date&Time:  2016/9/17 19:01:26
            // Modify History:
            //
//----------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Air2000.IoC.Extensions.Reflector
{
    public enum ReflectionExceptionType
    {
        /// <summary>
        /// The reflector requires a constructor,which Interfaces don't provide.
        /// </summary>
        CANNOT_REFLECT_INTERFACE,

        /// <summary>
        /// The reflector is not allowed to inject into private/protected setters.
        /// </summary>
        CANNOT_INJECT_INTO_NONPUBLIC_SETTER,
    }
}
