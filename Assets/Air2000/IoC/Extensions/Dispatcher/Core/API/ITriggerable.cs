/*----------------------------------------------------------------
            // Copyright © 2014-2016 Air2000
            // 
            // FileName: ITriggerable.cs
			// Describle:
			// Created By:  Wells Hsu
			// Date&Time:  2016/9/18 16:13:02
            // Modify History:
            //
//----------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Air2000.IoC.Extensions.Dispatcher
{
    public interface ITriggerable
    {
        /// <summary>
        /// CN:
        /// <para></para>
        /// EN: Cause this ITriggerable to acess any provided Key in its Binder by the provided generic and data.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data"></param>
        /// <returns></returns>
        bool Trigger<T>(object data);

        /// <summary>
        /// CN:
        /// <para></para>
        /// EN: Cause this ITriggerable to acess any provided Key in its Binder by the provided key and data.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        bool Trigger(object key, object data);
    }
}
