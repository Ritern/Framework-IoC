/*----------------------------------------------------------------
            // Copyright © 2014-2016 Air2000
            // 
            // FileName: DispatcherExceptionType.cs
			// Describle:
			// Created By:  Wells Hsu
			// Date&Time:  2016/9/18 16:12:38
            // Modify History:
            //
//----------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Air2000.IoC.Extensions.Dispatcher
{
    public enum DispatcherExceptionType
    {
        /// <summary>
        /// Injector Factory not found.
        /// </summary>
        NULL_FACTORY,

        /// <summary>
        /// Callback must be a Delegate with zero or one argument.
        /// </summary>
        ILLEGAL_CALLBACK_HANDLER
    }
}
