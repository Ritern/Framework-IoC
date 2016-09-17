/*----------------------------------------------------------------
            // Copyright © 2014-2016 Air2000
            // 
            // FileName: BindingConst.cs
			// Describle:
			// Created By:  Wells Hsu
			// Date&Time:  2016/9/14 11:03:16
            // Modify History:
            //
//----------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Air2000.IoC.Core
{
    public enum BindingConst
    {
        /// Null is an acceptable binding, but dictionaries choke on it, so we map null to this instead.
        NULLOID
    }
}
