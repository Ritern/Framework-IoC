/*----------------------------------------------------------------
            // Copyright © 2014-2016 Air2000
            // 
            // FileName: ReflectionException.cs
			// Describle:
			// Created By:  Wells Hsu
			// Date&Time:  2016/9/17 19:16:47
            // Modify History:
            //
//----------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Air2000.IoC.Extensions.Reflector
{
    public class ReflectionException : Exception
    {
        public ReflectionExceptionType type { get; set; }

        public ReflectionException() : base()
        {
        }

        /// Constructs a ReflectionException with a message and ReflectionExceptionType
        public ReflectionException(string message, ReflectionExceptionType exceptionType) : base(message)
        {
            type = exceptionType;
        }
    }
}
