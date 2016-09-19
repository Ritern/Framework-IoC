/*----------------------------------------------------------------
            // Copyright © 2014-2016 Air2000
            // 
            // FileName: InjectionException.cs
			// Describle:
			// Created By:  Wells Hsu
			// Date&Time:  2016/9/17 20:02:20
            // Modify History:
            //
//----------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Air2000.IoC.Extensions.Injector
{
    public class InjectionException : Exception
    {
        public InjectionExceptionType type { get; set; }

        public InjectionException() : base()
        {
        }

        /// Constructs an InjectionException with a message and InjectionExceptionType
        public InjectionException(string message, InjectionExceptionType exceptionType) : base(message)
        {
            type = exceptionType;
        }
    }
}
