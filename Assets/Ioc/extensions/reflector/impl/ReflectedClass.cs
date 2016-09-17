using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using Assets.Ioc.extensions.reflector.api;

namespace Assets.Ioc.extensions.reflector.impl
{
    public class ReflectedClass : IReflectedClass
    {
        public ConstructorInfo Constructor { get; set; }
        public Type[] ConstructorParameters { get; set; }
        public MethodInfo[] PostConstructors { get; set; }
        public KeyValuePair<Type, PropertyInfo>[] Setters { get; set; }
        public object[] SetterNames { get; set; }
        public bool PreGenerated { get; set; }

        /// [Obsolete"Strange migration to conform to C# guidelines. Removing camelCased publics"]
        public ConstructorInfo constructor { get { return Constructor; } set { Constructor = value; } }
        public Type[] constructorParameters { get { return ConstructorParameters; } set { ConstructorParameters = value; } }
        public MethodInfo[] postConstructors { get { return PostConstructors; } set { PostConstructors = value; } }
        public KeyValuePair<Type, PropertyInfo>[] setters { get { return Setters; } set { Setters = value; } }
        public object[] setterNames { get { return SetterNames; } set { SetterNames = value; } }
        public bool preGenerated { get { return PreGenerated; } set { PreGenerated = value; } }
    }
}
