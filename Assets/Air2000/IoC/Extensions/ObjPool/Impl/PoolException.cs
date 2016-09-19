/*----------------------------------------------------------------
            // Copyright © 2014-2016 Air2000
            // 
            // FileName: PoolException.cs
			// Describle:
			// Created By:  Wells Hsu
			// Date&Time:  2016/9/18 14:06:43
            // Modify History:
            //
//----------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace  Air2000.IoC.Extensions.ObjPool 
{
    public class PoolException : Exception
    {
        public PoolExceptionType type { get; set; }

        public PoolException() : base()
        {
        }

        /// Constructs a PoolException with a message and PoolExceptionType
        public PoolException(string message, PoolExceptionType exceptionType) : base(message)
        {
            type = exceptionType;
        }
    }
}
