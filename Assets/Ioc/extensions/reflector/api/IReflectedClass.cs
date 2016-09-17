using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace Assets.Ioc.extensions.reflector.api
{
    public interface IReflectedClass
    {
        /// <summary>
        /// Get or set preferred constructor.
        /// </summary>
        ConstructorInfo Constructor { get; set; }

        /// <summary>
        /// Get or set the preferred constructor's list of parameters.
        /// </summary>
        Type[] ConstructorParameters { get; set; }

        /// <summary>
        /// Get or set any PostConstructors.This includes inherited PostConstructors.
        /// </summary>
        MethodInfo[] PostConstructors { get; set; }

        /// <summary>
        /// Get or set the list of setter injections.This includes inherited setters.
        /// </summary>
        KeyValuePair<Type,PropertyInfo>[] Setters { get; set; }

        object[] SetterNames { get; set; }

        /// <summary>
        /// For testing.Allow a unit test to assert whether the binding was.
        /// generated on the current call,or on a prior one.
        /// </summary>
        bool PreGenerated { get; set; }

        /// [Obsolete"Strange migration to conform to C# guidelines. Removing camelCased publics"]
		ConstructorInfo constructor { get; set; }
        /// [Obsolete"Strange migration to conform to C# guidelines. Removing camelCased publics"]
        Type[] constructorParameters { get; set; }
        /// [Obsolete"Strange migration to conform to C# guidelines. Removing camelCased publics"]
        MethodInfo[] postConstructors { get; set; }
        /// [Obsolete"Strange migration to conform to C# guidelines. Removing camelCased publics"]
        KeyValuePair<Type, PropertyInfo>[] setters { get; set; }
        /// [Obsolete"Strange migration to conform to C# guidelines. Removing camelCased publics"]
        object[] setterNames { get; set; }
        /// [Obsolete"Strange migration to conform to C# guidelines. Removing camelCased publics"]
        bool preGenerated { get; set; }
    }
}
