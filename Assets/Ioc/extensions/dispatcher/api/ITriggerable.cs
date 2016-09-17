using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Ioc.extensions.dispatcher.api
{
    public interface ITriggerable
    {
        /// <summary>
        /// Cause this ITriggerable to acess any provided Key in its Binder by the provided generic and data.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data"></param>
        /// <returns></returns>
        bool Trigger<T>(object data);

        /// <summary>
        /// Cause this ITriggerable to acess any provided Key in its Binder by the provided key and data.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        bool Trigger(object key, object data);
    }
}
