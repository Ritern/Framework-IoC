using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Ioc.extensions.reflector.api;

namespace Assets.Ioc.extensions.reflector.impl
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
