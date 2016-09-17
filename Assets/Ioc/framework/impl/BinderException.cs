using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Ioc.framework.api;

namespace Assets.Ioc.framework.impl
{
    public class BinderException : Exception
    {
        public BinderExceptionType type { get; set; }
        public BinderException() : base() { }
        public BinderException(string message, BinderExceptionType exceptionType) : base(message)
        {
            type = exceptionType;
        }
    }
}
