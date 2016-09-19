/*----------------------------------------------------------------
            // Copyright © 2014-2016 Air2000
            // 
            // FileName: IReflectedClass.cs
			// Describle:
			// Created By:  Wells Hsu
			// Date&Time:  2016/9/17 18:59:58
            // Modify History:
            //
//----------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace Air2000.IoC.Extensions.Reflector
{
    public interface IReflectedClass
    {
        /// <summary>
        /// CN:
        /// <para></para>
        /// EN: Get/set the preferred constructor.
        /// </summary>
        ConstructorInfo Constructor { get; set; }

        /// <summary>
        /// CN:
        /// <para></para>
        /// EN: Get/set the preferred constructor's list of parameters.
        /// </summary>
        Type[] ConstructorParameters { get; set; }

        /// <summary>
        /// CN:
        /// <para></para>
        /// EN: Get/set any PostConstructors.This includes inherited PostConstructors.
        /// </summary>
        MethodInfo[] PostConstructors { get; set; }

        /// <summary>
        /// CN: 
        /// <para></para>
        /// EN: Get/set the list of setter injections.This includes inherited setters.
        /// </summary>
        KeyValuePair<Type,PropertyInfo>[] Setters { get; set; }

        /// <summary>
        /// CN:
        /// <para></para>
        /// EN: Setters' name
        /// </summary>
        object[] SetterNames { get; set; }

        /// <summary>
        /// CN:
        /// <para></para>
        /// EN: For testing.Allows a unit test to assert whether the binding was
        ///     generated on the current call,or on a prior one.
        /// </summary>
        bool PreGenerated { get; set; }
    }
}
