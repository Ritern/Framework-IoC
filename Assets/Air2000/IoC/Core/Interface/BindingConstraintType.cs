/*----------------------------------------------------------------
            // Copyright © 2014-2016 Air2000
            // 
            // FileName: BindingConstraintType.cs
			// Describle:
			// Created By:  Wells Hsu
			// Date&Time:  2016/9/14 11:02:22
            // Modify History:
            //
//----------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Air2000.IoC.Core
{
    public enum BindingConstraintType
    {
        /// Constrains a SemiBinding to carry no more than one item in its Value
        ONE,
        /// Constrains a SemiBinding to carry a list of items in its Value
        MANY,
        /// Instructs the Binding to apply a Pool instead of a SemiBinding
        POOL,
    }
}
