/*----------------------------------------------------------------
            // Copyright © 2014-2016 Air2000
            // 
            // FileName: ContextExceptionType.cs
			// Describle:
			// Created By:  Wells Hsu
			// Date&Time:  2016/9/18 11:13:25
            // Modify History:
            //
//----------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace  Air2000.IoC.Extensions.Context 
{
    public enum ContextExceptionType
    {
        /// <summary>
        /// MVCSContext requires a root ContextView.
        /// </summary>
        NO_CONTEXT_VIEW,

        /// <summary>
        /// MVCSContext requires a mediationBinder.
        /// </summary>
        NO_MEDIATION_BINDER,
    }
}
