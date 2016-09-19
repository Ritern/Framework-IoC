/*----------------------------------------------------------------
            // Copyright © 2014-2016 Air2000
            // 
            // FileName: EventCallbackType.cs
			// Describle:
			// Created By:  Wells Hsu
			// Date&Time:  2016/9/18 16:28:04
            // Modify History:
            //
//----------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Air2000.IoC.Extensions.Dispatcher
{
    public enum EventCallbackType
    {
        /// <summary>
        /// Indicates an EventCallback with no arguments.
        /// </summary>
        NO_ARGUMENTS,

        /// <summary>
        /// Indicates an EventCallback with no argument.
        /// </summary>
        ONE_ARGUMENT,

        /// <summary>
        /// Indicates no matching EventCallback could be found.
        /// </summary>
        NOT_FOUND,
    }
}
