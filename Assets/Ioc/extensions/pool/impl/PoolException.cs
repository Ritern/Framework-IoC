using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Ioc.extensions.pool.api;

namespace Assets.Ioc.extensions.pool.impl
{
    public class PoolException : Exception
    {
        public PoolExceptionType type { get; set; }
        public PoolException() : base() { }
        public PoolException(string message,PoolExceptionType exceptionType) : base(message)
        {
            type = exceptionType;
        }
    }
}
