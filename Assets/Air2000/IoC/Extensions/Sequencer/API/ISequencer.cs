/*----------------------------------------------------------------
            // Copyright © 2014-2016 Air2000
            // 
            // FileName: ISequencer.cs
			// Describle:
			// Created By:  Wells Hsu
			// Date&Time:  2016/9/18 20:15:30
            // Modify History:
            //
//----------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Air2000.IoC.Extensions.Command;

namespace Air2000.IoC.Extensions.Sequencer 
{
    public interface ISequencer:ICommandBinder
    {
        /// <summary>
        /// Release a previously retained SequenceCommand.
        /// By default,a Command is garbage collected at the end of its 'Execute()' method.
        /// But the Command can be retained for asynchronous calls.
        /// </summary>
        /// <param name="command"></param>
        void ReleaseCommand(ISequenceCommand command);

        new ISequenceBinding Bind<T>();

        new ISequenceBinding Bind(object value);
    }
}
