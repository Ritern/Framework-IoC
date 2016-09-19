/*----------------------------------------------------------------
            // Copyright © 2014-2016 Air2000
            // 
            // FileName: Sequencer.cs
			// Describle:
			// Created By:  Wells Hsu
			// Date&Time:  2016/9/18 20:25:24
            // Modify History:
            //
//----------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Air2000.IoC.Core;
using Air2000.IoC.Extensions.Dispatcher;
using Air2000.IoC.Extensions.Command;

namespace Air2000.IoC.Extensions.Sequencer 
{
    public class Sequencer : CommandBinder, ISequencer, ITriggerable
    {

        public Sequencer()
        {
        }

        override public IBinding GetRawBinding()
        {
            return new SequenceBinding(resolver);
        }

        override public void ReactTo(object key, object data)
        {
            ISequenceBinding binding = GetBinding(key) as ISequenceBinding;
            if (binding != null)
            {
                nextInSequence(binding, data, 0);
            }
        }

        private void removeSequence(ISequenceCommand command)
        {
            if (activeSequences.ContainsKey(command))
            {
                command.Cancel();
                activeSequences.Remove(command);
            }
        }

        private void invokeCommand(Type cmd, ISequenceBinding binding, object data, int depth)
        {
            ISequenceCommand command = createCommand(cmd, data);
            command.sequenceId = depth;
            trackCommand(command, binding);
            executeCommand(command);
            ReleaseCommand(command);
        }

        /// Instantiate and Inject the ISequenceCommand.
        new virtual protected ISequenceCommand createCommand(object cmd, object data)
        {
            injectionBinder.Bind<ISequenceCommand>().To(cmd);
            ISequenceCommand command = injectionBinder.GetInstance<ISequenceCommand>() as ISequenceCommand;
            command.data = data;
            injectionBinder.Unbind<ISequenceCommand>();
            return command;
        }

        private void trackCommand(ISequenceCommand command, ISequenceBinding binding)
        {
            activeSequences[command] = binding;
        }

        private void executeCommand(ISequenceCommand command)
        {
            if (command == null)
            {
                return;
            }
            command.Execute();
        }

        public void ReleaseCommand(ISequenceCommand command)
        {
            if (command.retain == false)
            {
                if (activeSequences.ContainsKey(command))
                {
                    ISequenceBinding binding = activeSequences[command] as ISequenceBinding;
                    object data = command.data;
                    activeSequences.Remove(command);
                    nextInSequence(binding, data, command.sequenceId + 1);
                }
            }
        }

        private void nextInSequence(ISequenceBinding binding, object data, int depth)
        {
            object[] values = binding.value as object[];
            if (depth < values.Length)
            {
                Type cmd = values[depth] as Type;
                invokeCommand(cmd, binding, data, depth);
            }
            else
            {
                if (binding.isOneOff)
                {
                    Unbind(binding);
                }
            }
        }

        private void failIf(bool condition, string message, SequencerExceptionType type)
        {
            if (condition)
            {
                throw new SequencerException(message, type);
            }
        }

        new public virtual ISequenceBinding Bind<T>()
        {
            return base.Bind<T>() as ISequenceBinding;
        }

        new public virtual ISequenceBinding Bind(object value)
        {
            return base.Bind(value) as ISequenceBinding;
        }
    }
}
