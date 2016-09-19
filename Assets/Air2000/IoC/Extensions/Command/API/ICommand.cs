/*----------------------------------------------------------------
            // Copyright © 2014-2016 Air2000
            // 
            // FileName: ICommand.cs
			// Describle:
			// Created By:  Wells Hsu
			// Date&Time:  2016/9/18 16:47:14
            // Modify History:
            //
//----------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Air2000.IoC.Extensions.Command
{
    public interface ICommand
    {
        /// <summary>
        /// Override this !'Execute()' is where you place the logic for your Command.
        /// </summary>
        void Execute();

        /// <summary>
        /// Keeps the Command in memory.Use only in conjection with 'Release()'.
        /// </summary>
        void Retain();

        /// <summary>
        /// Allows a previous Retained Command to be disposed.
        /// </summary>
        void Release();

        /// <summary>
        /// Indicates that the Command failed.
        /// Used in sequential command groups to terminate the sequence.
        /// </summary>
        void Fail();

        /// <summary>
        /// Inform the Command that further Exception has been terminated.
        /// </summary>
        void Cancel();

        /// <summary>
        /// Flag to indicate that a pooled Command has been restored to its pristine state.
        /// The CommandBinder will use this to determine if re-Injection is required.
        /// </summary>
        /// <returns></returns>
        bool IsClean { get; set; }

        /// <summary>
        /// The property set by 'Retain' and 'Release' to indicate whether the Command should be clean.
        /// </summary>
        bool retain { get; }

        /// <summary>
        /// The property set to true by a Cancel() call.
        /// Use cancelled internally to determine if further execution is warranted, especially in
		/// asynchronous calls. 
        /// </summary>
        bool cancelled { get; set; }

        /// <summary>
        /// A payload injected into the command.Most commonly ,this an IEvent.
        /// </summary>
        object data { get; set; }

        /// <summary>
        /// The ordered id of this Command,used in sequencing to find the next Command.
        /// </summary>
        int sequenceId { get; set; }
    }
}
