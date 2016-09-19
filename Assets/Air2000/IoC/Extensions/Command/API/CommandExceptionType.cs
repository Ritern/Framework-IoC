/*----------------------------------------------------------------
            // Copyright © 2014-2016 Air2000
            // 
            // FileName: CommandExceptionType.cs
			// Describle:
			// Created By:  Wells Hsu
			// Date&Time:  2016/9/18 16:46:57
            // Modify History:
            //
//----------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Air2000.IoC.Extensions.Command
{
    public enum CommandExceptionType
    {
        /// <summary>
        /// Commands must always override the Execute() method.
        /// </summary>
        EXECUTE_OVERRIDE,

        /// <summary>
        /// Binding wasn't found.
        /// </summary>
        NULL_BINDING,

        /// <summary>
        /// Something went wrong during construction,so the Command resolved to null.
        /// </summary>
        BAD_CONSTRUCTOR,
    }
}
