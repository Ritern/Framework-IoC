using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Ioc.framework.api
{
    /// <summary>
    /// Provides an instance of the specified Type
    /// When all you need is a new instance,use this instead of IInjectionBinder.
    /// </summary>
   public interface IInstanceProvider
    {
        /// <summary>
        /// Retrieve an Instance based on the key.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        T GetInstance<T>();

        /// <summary>
        /// Retrieve an Instance based on the key.
        /// i.e.  'injectionBinder.Get(typeof(ISomeInterface));'
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        object GetInstance(Type key);
    }
}
