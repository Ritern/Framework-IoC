/*----------------------------------------------------------------
            // Copyright © 2014-2016 Air2000
            // 
            // FileName: ITriggerProvider.cs
			// Describle:
			// Created By:  Wells Hsu
			// Date&Time:  2016/9/18 16:13:14
            // Modify History:
            //
//----------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Air2000.IoC.Extensions.Dispatcher
{
    public interface ITriggerProvider
    {
        /// <summary>
        /// CN:
        /// <para></para>
        /// EN: Register a Triggerable client with this provider.
        /// </summary>
        /// <param name="target"></param>
        void AddTriggerable(ITriggerable target);

        /// <summary>
        /// CN:
        /// <para></para>
        /// EN: Remove a previously registered Triggerable client from this provider.
        /// </summary>
        /// <param name="target"></param>
        void RemoveTriggerable(ITriggerable target);

        /// <summary>
        /// CN:
        /// <para></para>
        /// EN: Count of the current number of trigger clients.
        /// </summary>
        int Triggerables { get; }
    }
}
