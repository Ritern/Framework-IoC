/*----------------------------------------------------------------
            // Copyright © 2014-2016 Air2000
            // 
            // FileName: EventSequencer.cs
			// Describle:
			// Created By:  Wells Hsu
			// Date&Time:  2016/9/18 20:24:53
            // Modify History:
            //
//----------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Air2000.IoC.Extensions.Dispatcher;

namespace  Air2000.IoC.Extensions.Sequencer 
{
    public class EventSequencer : Sequencer
    {
        public EventSequencer()
        {
        }

        /// Instantiate and Inject the command, incling an IEvent to data.
         protected override ISequenceCommand createCommand(object cmd, object data)
        {
            injectionBinder.Bind<ISequenceCommand>().To(cmd);
            if (data is IEvent)
            {
                injectionBinder.Bind<IEvent>().ToValue(data).ToInject(false); ;
            }
            ISequenceCommand command = injectionBinder.GetInstance<ISequenceCommand>() as ISequenceCommand;
            command.data = data;
            if (data is IEvent)
            {
                injectionBinder.Unbind<IEvent>();
            }
            injectionBinder.Unbind<ISequenceCommand>();
            return command;
        }
    }
}
