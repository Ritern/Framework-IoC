using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Ioc.framework.api;

namespace Assets.Ioc.extensions.reflector.api
{
    public interface IReflectionBinder
    {
        /// <summary>
        /// Get a binding based on the provided Type.
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        IReflectedClass Get(Type type);

        /// <summary>
        /// Get a binding based on the provided Type generic.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        IReflectedClass Get<T>();
    }
}
