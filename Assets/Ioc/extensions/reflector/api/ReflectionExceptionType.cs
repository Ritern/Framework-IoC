﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Ioc.extensions.reflector.api
{
    public enum ReflectionExceptionType
    {
        /// The reflector requires a constructor, which Interfaces don't provide.
        CANNOT_REFLECT_INTERFACE,

        /// The reflector is not allowed to inject into private/protected setters.
        CANNOT_INJECT_INTO_NONPUBLIC_SETTER,
    }
}
