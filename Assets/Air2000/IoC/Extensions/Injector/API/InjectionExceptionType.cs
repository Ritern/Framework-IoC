/*----------------------------------------------------------------
            // Copyright © 2014-2016 Air2000
            // 
            // FileName: InjectionExceptionType.cs
			// Describle:
			// Created By:  Wells Hsu
			// Date&Time:  2016/9/17 19:57:41
            // Modify History:
            //
//----------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Air2000.IoC.Extensions.Injector
{
    public enum InjectionExceptionType
    {
        /// <summary>
        /// A circular dependency was found.
        /// </summary>
        CIRCULAR_DEPENDENCY,

        /// <summary>
        /// The value of a binding does not extend or implement the binding type.
        /// </summary>
        ILLEGAL_BINDING_VALUE,

        /// <summary>
        /// No InjectionBinder found.
        /// </summary>
        NO_BINDER,

        /// <summary>
        /// No ReflectionBinder found.
        /// </summary>
        NO_REFLECTOR,

        /// <summary>
        /// No InjectionFactory found.
        /// </summary>
        NO_FACTORY,

        /// <summary>
        /// The provided binding is not an instantiable class.
        /// </summary>
        NOT_INSTANTIABLE,

        /// <summary>
        /// The requested Binding was null or couldn't be found.
        /// </summary>
        NULL_BINDING,

        /// <summary>
        /// During an attempt to construct,no constructor was found.
        /// </summary>
        NULL_CONSTRUCTOR,

        /// <summary>
        /// No reflection was provided for the requested to null.
        /// </summary>
        NULL_INJECTION_POINT,

        /// <summary>
        /// No reflection was provided for the requested class.
        /// </summary>
        NULL_REFLECTION,

        /// <summary>
        /// The instance being injected into resolved to null.
        /// </summary>
        NULL_TARGET,

        /// <summary>
        /// The value being injected into the target resolved to null.
        /// </summary>
        NULL_VALUE_INJECTION,

        /// <summary>
        /// The list of setters and setter names must have exactly the same number of entires.
        /// Two lists are required because Unity does not at present support Tuple.
        /// Seeing this error likely indicates a problem with the Reflector (it's not you,it's me).
        /// </summary>
        SETTER_NAME_MISMATCH,

        /// <summary>
        /// The requested cross-context injector returned null.
        /// </summary>
        MISSING_CORSS_CONTEXT_INJECTOR,

        /// <summary>
        /// An implicit implementor does not fulfill the designated interface.
        /// </summary>
        IMPLICIT_BINDING_IMPLEMENTOR_DOES_NOT_IMPLEMENT_INTERFACE,

        /// <summary>
        /// An implicit type does not implement the designated interface.
        /// </summary>
        IMPLICIT_BINDING_TYPE_DOES_NOT_IMPLEMENT_DESIGNATED_INTERFACE,

        /// <summary>
        /// Assembly object was not retrieved and cached.
        /// </summary>
        UNINITIALIZED_ASSEMBLY,
    }
}
