/*----------------------------------------------------------------
            // Copyright © 2014-2016 Air2000
            // 
            // FileName: ISequenceBinding.cs
			// Describle:
			// Created By:  Wells Hsu
			// Date&Time:  2016/9/18 20:15:03
            // Modify History:
            //
//----------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Air2000.IoC.Core;
using Air2000.IoC.Extensions.Command;

namespace Air2000.IoC.Extensions.Sequencer 
{
    public interface ISequenceBinding:ICommandBinding
    {
        /// <summary>
        /// Declares that the Binding is one-off.As soon as it's satisfied,it will be unmapped.
        /// </summary>
        /// <returns></returns>
        new ISequenceBinding Once();

        /// <summary>
        /// Get/set the property set to 'true' by 'Once()'
        /// </summary>
        new bool isOneOff { get; set; }

        new ISequenceBinding Bind<T>();
        new ISequenceBinding Bind(object key);
        new ISequenceBinding To<T>();
        new ISequenceBinding To(object o);
        new ISequenceBinding ToName<T>();
        new ISequenceBinding ToName(object o);
        new ISequenceBinding Named<T>();
        new ISequenceBinding Named(object o);
    }
}
