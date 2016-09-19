/*----------------------------------------------------------------
            // Copyright © 2014-2016 Air2000
            // 
            // FileName: CommandException.cs
			// Describle:
			// Created By:  Wells Hsu
			// Date&Time:  2016/9/18 16:49:14
            // Modify History:
            //
//----------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Air2000.IoC.Extensions.Command 
{
    public class CommandException : Exception
    {
        public CommandExceptionType type { get; set; }

        public CommandException() : base()
        {
        }

        /// Constructs a CommandException with a message and CommandExceptionType
        public CommandException(string message, CommandExceptionType exceptionType) : base(message)
        {
            type = exceptionType;
        }
    }
}
