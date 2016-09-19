/*----------------------------------------------------------------
            // Copyright © 2014-2016 Air2000
            // 
            // FileName: ReflectedClass.cs
			// Describle:
			// Created By:  Wells Hsu
			// Date&Time:  2016/9/17 19:16:20
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
    public class ReflectedClass : IReflectedClass
    {
        public ConstructorInfo Constructor { get; set; }
        public Type[] ConstructorParameters { get; set; }
        public MethodInfo[] PostConstructors { get; set; }
        public KeyValuePair<Type, PropertyInfo>[] Setters { get; set; }
        public object[] SetterNames { get; set; }
        public bool PreGenerated { get; set; }
    }
}
