using System;
using Assets.Ioc.framework.api;

namespace Assets.Ioc.extensions.pool.api
{
    public interface IPool<T> : IPool
    {
        new T GetInstance();
    }
    public interface IPool : IManagedList
    {

        /// <summary>
        /// A class that provides instaces to the pool when it needs them.
        /// This can be the InjectionBinder,or any class you write that satisfies the IInstanceProvider
        /// interface.
        /// </summary>
        IInstanceProvider instanceProvider { get; set; }

        /// <summary>
        /// The object Type of the first object added to the pool.
        /// Pool objects must be of the same concrete type.This property enforces that requirement.
        /// </summary>
        Type poolType { get; set; }

        /// <summary>
        /// Gets an instance from the pool if one is available.
        /// </summary>
        /// <returns></returns>
        object GetInstance();

        /// <summary>
        /// Returns an instance to the pool.
        /// </summary>
        /// <param name="value"></param>
        void ReturnInstance(object value);

        /// <summary>
        /// Remove all instance references from the Pool.
        /// </summary>
        void Clean();

        /// <summary>
        /// Returns the count of non-committed instances.
        /// </summary>
        int available { get; }

        /// <summary>
        /// Gets or sets the size of the pool.
        /// </summary>
        int size { get; set; }

        /// <summary>
        /// Returns the total number of instances currently mamaged by this pool.
        /// </summary>
        int instanceCount { get; }

        /// <summary>
        /// Gets or sets the overflow behaviour of this pool.
        /// </summary>
        PoolOverflowBehavior overflowBehavior { get; set; }

        /// <summary>
        /// Gets or sets the type of inflation for infinite-sized pools.
        /// </summary>
        PoolInflationType inflationType { get; set; }
    }
}
