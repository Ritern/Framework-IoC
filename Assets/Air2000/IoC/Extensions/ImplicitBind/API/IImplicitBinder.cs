/*----------------------------------------------------------------
            // Copyright © 2014-2016 Air2000
            // 
            // FileName: IImplicitBinder.cs
			// Describle:
			// Created By:  Wells Hsu
			// Date&Time:  2016/9/18 14:32:40
            // Modify History:
            //
//----------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Air2000.IoC.Extensions.ImplicitBind
{
    public interface IImplicitBinder
    {
        /// <summary>
        /// CN:
        /// <para></para>
        /// EN: Search through indicated namespaces and scan for all annotated classes.
        ///     Automatically create bindings.
        /// </summary>
        /// <param name="usingNamespaces"></param>
        void ScanForAnnotatedClasses(string[] usingNamespaces);
    }
}
