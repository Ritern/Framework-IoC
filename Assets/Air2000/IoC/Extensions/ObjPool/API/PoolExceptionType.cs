/*----------------------------------------------------------------
            // Copyright © 2014-2016 Air2000
            // 
            // FileName: PoolExceptionType.cs
			// Describle:
			// Created By:  Wells Hsu
			// Date&Time:  2016/9/18 14:05:45
            // Modify History:
            //
//----------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Air2000.IoC.Extensions.ObjPool
{
    public enum PoolExceptionType
    {
        /// <summary>
        /// POOL HAS OVERFLOWED ITS LIMIT.
        /// </summary>
        OVERFLOW,

        /// <summary>
        /// ATTEMPT TO ADD AN INSTANCE OF DIFFERENT TYPE TO A POOL.
        /// </summary>
        TYPE_MISMATCH,

        /// <summary>
        /// A POOL HAS NO INSTANCE PROVIDER.
        /// </summary>
        NO_INSTANCE_PROVIDER,
    }
}
