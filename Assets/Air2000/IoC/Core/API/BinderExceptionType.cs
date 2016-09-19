/*----------------------------------------------------------------
            // Copyright © 2014-2016 Air2000
            // 
            // FileName: BinderExceptionType.cs
			// Describle:
			// Created By:  Wells Hsu
			// Date&Time:  2016/9/14 11:01:48
            // Modify History:
            //
//----------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Air2000.IoC.Core
{
    public enum BinderExceptionType
    {
        /// The binder is being used while one or more Bindings are in conflict
        CONFLICT_IN_BINDER
    }
}
