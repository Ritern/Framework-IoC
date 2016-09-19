/*----------------------------------------------------------------
            // Copyright © 2014-2016 Air2000
            // 
            // FileName: PoolOverflowBehavior.cs
			// Describle:
			// Created By:  Wells Hsu
			// Date&Time:  2016/9/18 14:06:22
            // Modify History:
            //
//----------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Air2000.IoC.Extensions.ObjPool
{
    public enum PoolOverflowBehavior
    {
        /// <summary>
        /// Requesting more than the fixed size will throw an exception.
        /// </summary>
        EXCEPTION,

        /// <summary>
        /// Requestion more than the fixed size will throw a warning.
        /// </summary>
        WARNING,

        /// <summary>
        /// Requesting more than the fixed size will return null and not throw an error.
        /// </summary>
        IGNORE
    }
}
