using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Ioc.framework.api
{
    /// <summary>
    /// A common interface for the constituents parts of a Binding,which at present
    /// are either a SemiBinding or a Pool.A managedList can have objects added or removed.
    /// </summary>
    public interface IManagedList
    {
        /// <summary>
        /// Add a value to this List.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        IManagedList Add(object value);

        /// <summary>
        /// Add a set of value to this List.
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        IManagedList Add(object[] list);

        /// <summary>
        /// Remove a value from this List.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        IManagedList Remove(object value);

        /// <summary>
        /// Remove a set of values from this List.
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        IManagedList Remove(object[] list);

        /// <summary>
        /// Retrieve the value of this List.
        /// If the constraint is MANY,the value will be an Array.
        /// If the constraint is POOL,this becomes a synonym for GetInstance().
        /// </summary>
        object value { get; }
    }
}
