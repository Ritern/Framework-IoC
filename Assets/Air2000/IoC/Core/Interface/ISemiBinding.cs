/*----------------------------------------------------------------
            // Copyright © 2014-2016 Air2000
            // 
            // FileName: ISemiBinding.cs
			// Describle:
			// Created By:  Wells Hsu
			// Date&Time:  2016/9/14 10:06:40
            // Modify History:
            //
//----------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Air2000.IoC.Core
{
    /// <summary>
    /// CN: SemiBinding 是整个框架组成中原子级别的部分。它代表着
    ///     Binding的Key、Value或Name。
    ///     SemiBinding 存储了一些 具体的值、类型（Type）、集合等。
    ///     同时也存在一定的限制条件，例如ONE,MANY这些。ONE意味着SemiBinding
    ///     只能持有一个单例，而不是一个列表。默认的KEY-VALUE-NAME结构如下：
    ///     Key-ONE
    ///     Value-MANY
    ///     Name-ONE
    /// <para></para>
    /// EN: A SemiBinding is the smallest atomic part of the framework.It represents
    ///     either the Key or the Value or the Name arm of the binding.
    ///     The SemiBinding stores some value...a system Type,a list,a concrete value.
    ///     It also has a constraint defined by the constant ONE or MANY.
    ///     A constraint of ONE makes the SemiBinding maintain a singular value,rather than a list.
    ///     The defalut constraints are:
    ///     Key-ONE
    ///     Value-MANY
    ///     Name-ONE
    /// </summary>
    public interface ISemiBinding : IManagedList
    {
        /// <summary>
        /// CN: 设置约束的类型.
        /// <para></para>
        /// EN: Set or get the constraint.
        /// </summary>
        Enum constraint { get; set; }

        /// <summary>
        /// CN: 第二约束条件，确保SemiBinding不会包含多个相等的值.
        /// <para></para>
        /// EN: A secondary constraint that ensures that this SemiBinding will never contain multiple values equivalent to each other.
        /// </summary>
        bool uniqueValues { get; set; }
    }
}
