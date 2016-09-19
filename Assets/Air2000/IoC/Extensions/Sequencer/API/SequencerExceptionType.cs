/*----------------------------------------------------------------
            // Copyright © 2014-2016 Air2000
            // 
            // FileName: SequencerExceptionType.cs
			// Describle:
			// Created By:  Wells Hsu
			// Date&Time:  2016/9/18 20:15:49
            // Modify History:
            //
//----------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Air2000.IoC.Extensions.Sequencer
{
    public enum SequencerExceptionType
    {
        /// <summary>
        /// SequenceCommands must always override the Execute() method.
        /// </summary>
        EXECUTE_OVERRIDE,

        /// <summary>
        /// This exception is raised if the mapped Command doesn't implement ISequenceCommand.
        /// </summary>
        COMMAND_USED_IN_SEQUENCE,
    }
}
