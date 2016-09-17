using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Ioc.extensions.injector.api;

namespace Assets.Ioc.extensions.injector.impl
{
    public class InjectionException : Exception
    {
        public InjectionExceptionType type { get; set; }
        public InjectionException() : base() { }
        public InjectionException(string message,InjectionExceptionType exceptionType) : base(message)
        {
            type = exceptionType;
        }
    }
}
