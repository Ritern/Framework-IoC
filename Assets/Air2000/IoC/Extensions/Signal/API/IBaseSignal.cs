/*----------------------------------------------------------------
            // Copyright © 2014-2016 Air2000
            // 
            // FileName: IBaseSignal.cs
			// Describle:
			// Created By:  Wells Hsu
			// Date&Time:  2016/9/19 9:27:08
            // Modify History:
            //
//----------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Air2000.IoC.Extensions.Signal
{
    public interface IBaseSignal
    {
        /// <summary>
        /// Instruct a Signal to call on all its registered listeners.
        /// </summary>
        /// <param name="args"></param>
        void Dispatch(object[] args);

        /// <summary>
        /// Attach a callback to this Signal.
        /// The callback parameters must match the Types and order which were
        /// originally assigned to the Signal on its creation.
        /// </summary>
        /// <param name="callback"></param>
        void AddListener(Action<IBaseSignal, object[]> callback);

        /// <summary>
        /// Attach a callback to this Signal for the duration of exactly one Dispatch
        /// The callback parameters must match the Types and order which were
        /// originally assigned to the Signal on its creation,and the callback
        /// will be removed immediately after the Signal dispatches.
        /// </summary>
        /// <param name="callback"></param>
        void AddOnce(Action<IBaseSignal, object[]> callback);

        /// <summary>
        /// Remove a callback from this Signal.
        /// </summary>
        void RemoveListener();

        /// <summary>
        /// Returns a List<System.Type> representing the Types bindable to this Signal. 
        /// </summary>
        /// <returns></returns>
        List<Type> GetTypes();
    }
}
