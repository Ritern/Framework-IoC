/*----------------------------------------------------------------
            // Copyright © 2014-2016 Air2000
            // 
            // FileName: DispatcherException.cs
			// Describle:
			// Created By:  Wells Hsu
			// Date&Time:  2016/9/18 16:14:15
            // Modify History:
            //
//----------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Air2000.IoC.Extensions.Dispatcher
{
    public class DispatcherException : Exception
    {
        public DispatcherExceptionType type { get; set; }

        public DispatcherException() : base()
        {
        }

        /// Constructs a DispatcherException with a message and DispatcherExceptionType
        public DispatcherException(string message, DispatcherExceptionType exceptionType) : base(message)
        {
            type = exceptionType;
        }
    }
}
