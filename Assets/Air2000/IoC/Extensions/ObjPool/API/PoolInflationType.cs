/*----------------------------------------------------------------
            // Copyright © 2014-2016 Air2000
            // 
            // FileName: PoolInflationType.cs
			// Describle:
			// Created By:  Wells Hsu
			// Date&Time:  2016/9/18 14:06:05
            // Modify History:
            //
//----------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Air2000.IoC.Extensions.ObjPool 
{
    public enum PoolInflationType
    {
        /// <summary>
        /// When a dynamic pool inflates,add one to the pool.
        /// </summary>
        INCREMENT,

        /// <summary>
        /// When a dynamic pool inflates,double the size of the pool.
        /// </summary>
        DOUBLE
    }
}
