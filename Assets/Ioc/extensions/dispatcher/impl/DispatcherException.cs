﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Ioc.extensions.dispatcher.api;

namespace Assets.Ioc.extensions.dispatcher.impl
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
