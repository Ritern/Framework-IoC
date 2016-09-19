/*----------------------------------------------------------------
            // Copyright © 2014-2016 Air2000
            // 
            // FileName: ICommandBinder.cs
			// Describle:
			// Created By:  Wells Hsu
			// Date&Time:  2016/9/18 16:47:26
            // Modify History:
            //
//----------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Air2000.IoC.Core;

namespace Air2000.IoC.Extensions.Command
{
    public interface ICommandBinder : IBinder
    {
        /// <summary>
        /// Trigger a key that unlocks one or more Commands.
        /// </summary>
        /// <param name="trigger"></param>
        void ReactTo(object trigger);

        /// <summary>
        /// Trigger a key that unlocks one or more Commands and provide a data injection to that Command.
        /// </summary>
        /// <param name="trigger"></param>
        /// <param name="data"></param>
        void ReactTo(object trigger, object data);

        /// <summary>
        /// Release a previously retained Command.
        /// By default,a Command is garbage collected at the end of its 'Execute()' method.
        /// But the Command can be retained for asynchronous calls.
        /// </summary>
        /// <param name="command"></param>
        void ReleaseCommand(ICommand command);

        /// <summary>
        /// Called to halt execution of a currently running command group.
        /// </summary>
        void Stop(object key);

        /// <summary>
        /// Bind a trigger Key by generic Type.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        new ICommandBinding Bind<T>();

        /// <summary>
        /// Bind a trigger Key by value.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        new ICommandBinding Bind(object value);

        new ICommandBinding GetBinding<T>();
    }
}
