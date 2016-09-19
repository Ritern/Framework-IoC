/*----------------------------------------------------------------
            // Copyright © 2014-2016 Air2000
            // 
            // FileName: ReflectionBinder.cs
			// Describle:
			// Created By:  Wells Hsu
			// Date&Time:  2016/9/17 19:16:29
            // Modify History:
            //
//----------------------------------------------------------------*/
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using Air2000.IoC.Core;

namespace Air2000.IoC.Extensions.Reflector
{
    public class ReflectionBinder : Air2000.IoC.Core.Binder, IReflectionBinder
    {
        public ReflectionBinder() { }
        public IReflectedClass Get<T>()
        {
            return Get(typeof(T));
        }
        public IReflectedClass Get(Type type)
        {
            IBinding binding = GetBinding(type);
            IReflectedClass retv;
            if (binding == null)
            {
                binding = GetRawBinding();
                IReflectedClass reflected = new ReflectedClass();
                mapPreferredConstructor(reflected, binding, type);
                mapPostConstructors(reflected, binding, type);
                mapSetters(reflected, binding, type);
                binding.Bind(type).To(reflected);
                retv = binding.value as IReflectedClass;
                retv.PreGenerated = false;
            }
            else
            {
                retv = binding.value as IReflectedClass;
                retv.PreGenerated = true;
            }
            return retv;
        }

        public override IBinding GetRawBinding()
        {
            IBinding binding = base.GetRawBinding();
            binding.valueConstraint = BindingConstraintType.ONE;
            return binding;
        }

        private void mapPreferredConstructor(IReflectedClass reflected, IBinding binding, Type type)
        {
            ConstructorInfo constructor = findPreferredConstructor(type);
            if (constructor == null)
            {
                throw new ReflectionException("The reflector requires concrete classes.\nType " + type + " has no constructor. Is it an interface?", ReflectionExceptionType.CANNOT_REFLECT_INTERFACE);
            }
            ParameterInfo[] parameters = constructor.GetParameters();

            Type[] paramList = new Type[parameters.Length];
            for (int i = 0; i < parameters.Length; i++)
            {
                ParameterInfo info = parameters[i];
                if (info == null) continue;
                paramList[i] = info.ParameterType;
            }
            reflected.Constructor = constructor;
            reflected.ConstructorParameters = paramList;
        }

        private ConstructorInfo findPreferredConstructor(Type type)
        {
            ConstructorInfo[] constructors = type.GetConstructors(BindingFlags.FlattenHierarchy |
                                                                        BindingFlags.Public |
                                                                        BindingFlags.Instance |
                                                                        BindingFlags.InvokeMethod);
            if (constructors.Length == 1)
            {
                return constructors[0];
            }
            int len;
            int shortestLen = int.MaxValue;
            ConstructorInfo shortestConstructor = null;
            foreach (ConstructorInfo constructor in constructors)
            {
                object[] taggedConstructors = constructor.GetCustomAttributes(typeof(Construct), true);
                if (taggedConstructors.Length > 0)
                {
                    return constructor;
                }
                len = constructor.GetParameters().Length;
                if (len < shortestLen)
                {
                    shortestLen = len;
                    shortestConstructor = constructor;
                }
            }
            return shortestConstructor;
        }

        private void mapPostConstructors(IReflectedClass reflected, IBinding binding, Type type)
        {
            MethodInfo[] methods = type.GetMethods(
                BindingFlags.FlattenHierarchy |
                BindingFlags.Public |
                BindingFlags.Instance |
                BindingFlags.InvokeMethod);
            ArrayList methodList = new ArrayList();
            for (int i = 0; i < methods.Length; i++)
            {
                MethodInfo info = methods[i];
                if (info == null) continue;
                object[] tagged = info.GetCustomAttributes(typeof(PostConstruct), true);
                if (tagged.Length > 0)
                {
                    methodList.Add(info);
                }
            }

            methodList.Sort(new PriorityComparer());

            MethodInfo[] postConstructors = (MethodInfo[])methodList.ToArray(typeof(MethodInfo));
            reflected.PostConstructors = postConstructors;
        }

        private void mapSetters(IReflectedClass reflected,IBinding binding,Type type)
        {
            KeyValuePair<Type, PropertyInfo>[] pairs = new KeyValuePair<Type, PropertyInfo>[0];
            object[] names = new object[0];

            MemberInfo[] privateMembers = type.FindMembers(
                MemberTypes.Property,
                BindingFlags.FlattenHierarchy |
                BindingFlags.SetProperty |
                BindingFlags.NonPublic |
                BindingFlags.Instance,
                null, null);
            for(int i = 0; i < privateMembers.Length; i++)
            {
                MemberInfo info = privateMembers[i];
                if (info == null) continue;
                object[] injections = info.GetCustomAttributes(typeof(Inject), true);
                if (injections.Length > 0)
                {
                    throw new ReflectionException("The class " + type.Name + " has a non-public Injection setter " + info.Name + ". Make the setter public to allow injection.", ReflectionExceptionType.CANNOT_INJECT_INTO_NONPUBLIC_SETTER);
                }
            }

            MemberInfo[] members = type.FindMembers(MemberTypes.Property,
                BindingFlags.FlattenHierarchy |
                BindingFlags.SetProperty |
                BindingFlags.Public |
                BindingFlags.Instance,
                null, null);

            for (int i = 0; i < members.Length; i++)
            {
                MemberInfo info = members[i];
                if (info == null) continue;
                object[] injections = info.GetCustomAttributes(typeof(Inject), true);
                if (injections.Length > 0)
                {
                    Inject attr = injections[0] as Inject;
                    PropertyInfo point = info as PropertyInfo;
                    Type pointType = point.PropertyType;
                    KeyValuePair<Type, PropertyInfo> pair = new KeyValuePair<Type, PropertyInfo>(pointType, point);
                    pairs = AddKV(pair, pairs);

                    object bindingName = attr.name;
                    names = Add(bindingName, names);
                }
            }
            reflected.Setters = pairs;
            reflected.SetterNames = names;
        }

        private object[] Add(object value,object[] list)
        {
            object[] tempList = list;
            int length = tempList.Length;
            list = new object[length + 1];
            tempList.CopyTo(list, 0);
            list[length] = value;
            return list;
        }
        private KeyValuePair<Type, PropertyInfo>[] AddKV(KeyValuePair<Type, PropertyInfo> value, KeyValuePair<Type, PropertyInfo>[] list)
        {
            KeyValuePair<Type, PropertyInfo>[] tempList = list;
            int len = tempList.Length;
            list = new KeyValuePair<Type, PropertyInfo>[len + 1];
            tempList.CopyTo(list, 0);
            list[len] = value;
            return list;
        }
    }

    class PriorityComparer : IComparer
    {
        int IComparer.Compare(Object x, Object y)
        {

            int pX = getPriority(x as MethodInfo);
            int pY = getPriority(y as MethodInfo);

            return (pX < pY) ? -1 : 1;
        }

        private int getPriority(MethodInfo methodInfo)
        {
            PostConstruct attr = methodInfo.GetCustomAttributes(true)[0] as PostConstruct;
            int priority = attr.priority;
            return priority;
        }
    }
}
