/*----------------------------------------------------------------
            // Copyright © 2014-2016 Air2000
            // 
            // FileName: BinderException.cs
			// Describle:
			// Created By:  Wells Hsu
			// Date&Time:  2016/9/14 11:04:16
            // Modify History:
            //
//----------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Air2000.IoC.Core
{
    public class BinderException : Exception
    {
        public BinderExceptionType type { get; set; }

        public BinderException() : base() { }

        /// Constructs a BinderException with a message and BinderExceptionType
        public BinderException(string message, BinderExceptionType exceptionType) : base(message)
        {
            type = exceptionType;
        }
    }
}
