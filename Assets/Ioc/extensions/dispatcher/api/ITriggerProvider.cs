using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Ioc.extensions.dispatcher.api
{
    public interface ITriggerProvider
    {
        /// <summary>
        /// Register a Triggerable client with this provider.
        /// </summary>
        /// <param name="target"></param>
        void AddTriggerable(ITriggerable target);
        /// <summary>
        /// Remove a previously registered Triggerable client from this provider.
        /// </summary>
        /// <param name="target"></param>
        void RemoveTriggerable(ITriggerable target);
        /// <summary>
        /// Count of the current number of trigger clients.
        /// </summary>
        int Triggerables { get; }
    }
}
