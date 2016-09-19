/*----------------------------------------------------------------
            // Copyright © 2014-2016 Air2000
            // 
            // FileName: IDispatcher.cs
			// Describle:
			// Created By:  Wells Hsu
			// Date&Time:  2016/9/18 16:12:47
            // Modify History:
            //
//----------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Air2000.IoC.Extensions.Dispatcher
{
    public interface IDispatcher
    {
        /// <summary>
        /// CN:
        /// <para></para>
        /// EN: Send a notification of type eventType.No data.
        /// </summary>
        /// <param name="eventType"></param>
        void Dispatch(object eventType);

        /// <summary>
        /// CN:
        /// <para></para>
        /// EN: Send a notification of type eventType with data.
        /// </summary>
        /// <param name="eventType"></param>
        /// <param name="data"></param>
        void Dispatch(object eventType, object data);
    }
}
