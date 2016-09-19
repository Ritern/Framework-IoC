/*----------------------------------------------------------------
            // Copyright © 2014-2016 Air2000
            // 
            // FileName: SequenceBinding.cs
			// Describle:
			// Created By:  Wells Hsu
			// Date&Time:  2016/9/18 20:25:04
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
    public class SequenceBinding : CommandBinding, ISequenceBinding
    {
        new public bool isOneOff { get; set; }

        public SequenceBinding() : base()
        {
        }

        public SequenceBinding(Binder.BindingResolver resolver) : base(resolver)
        {
        }

        new public ISequenceBinding Once()
        {
            isOneOff = true;
            return this;
        }

        //Everything below this point is simply facade on Binding to ensure fluent interface
        new public ISequenceBinding Bind<T>()
        {
            return Bind<T>();
        }

        new public ISequenceBinding Bind(object key)
        {
            return Bind(key);
        }

        new public ISequenceBinding To<T>()
        {
            return To(typeof(T));
        }

        new public ISequenceBinding To(object o)
        {
            Type oType = o as Type;
            Type sType = typeof(ISequenceCommand);


            if (sType.IsAssignableFrom(oType) == false)
            {
                throw new SequencerException("Attempt to bind a non SequenceCommand to a Sequence. Perhaps your command needs to extend SequenceCommand or implement ISequenCommand?\n\tType: " + oType.ToString(), SequencerExceptionType.COMMAND_USED_IN_SEQUENCE);
            }

            return base.To(o) as ISequenceBinding;
        }

        new public ISequenceBinding ToName<T>()
        {
            return base.ToName<T>() as ISequenceBinding;
        }

        new public ISequenceBinding ToName(object o)
        {
            return base.ToName(o) as ISequenceBinding;
        }

        new public ISequenceBinding Named<T>()
        {
            return base.Named<T>() as ISequenceBinding;
        }

        new public ISequenceBinding Named(object o)
        {
            return base.Named(o) as ISequenceBinding;
        }
    }
}
