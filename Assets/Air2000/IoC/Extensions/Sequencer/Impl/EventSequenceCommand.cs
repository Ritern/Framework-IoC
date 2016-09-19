/*----------------------------------------------------------------
            // Copyright © 2014-2016 Air2000
            // 
            // FileName: EventSequenceCommand.cs
			// Describle:
			// Created By:  Wells Hsu
			// Date&Time:  2016/9/18 20:24:40
            // Modify History:
            //
//----------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Air2000.IoC.Extensions.Context;
using Air2000.IoC.Extensions.Dispatcher;

namespace  Air2000.IoC.Extensions.Sequencer 
{
    public class EventSequenceCommand : SequenceCommand
    {
        /// The context-wide Event bus
        [Inject(ContextKeys.CONTEXT_DISPATCHER)]
        public IEventDispatcher dispatcher { get; set; }

        /// The injected IEvent
        [Inject]
        public IEvent evt { get; set; }
    }
}
