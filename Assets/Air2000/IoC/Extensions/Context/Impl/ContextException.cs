/*----------------------------------------------------------------
            // Copyright © 2014-2016 Air2000
            // 
            // FileName: ContextException.cs
			// Describle:
			// Created By:  Wells Hsu
			// Date&Time:  2016/9/18 11:15:30
            // Modify History:
            //
//----------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Air2000.IoC.Extensions.Context
{
    public class ContextException : Exception
    {
        public ContextExceptionType type { get; set; }

        public ContextException() : base()
        {
        }

        /// Constructs a ContextException with a message and ContextExceptionType
        public ContextException(string message, ContextExceptionType exceptionType) : base(message)
        {
            type = exceptionType;
        }
    }
}
