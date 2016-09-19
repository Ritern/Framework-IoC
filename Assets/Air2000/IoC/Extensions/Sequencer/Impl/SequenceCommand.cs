/*----------------------------------------------------------------
            // Copyright © 2014-2016 Air2000
            // 
            // FileName: SequenceCommand.cs
			// Describle:
			// Created By:  Wells Hsu
			// Date&Time:  2016/9/18 20:25:14
            // Modify History:
            //
//----------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Air2000.IoC.Extensions.Sequencer 
{
    public class SequenceCommand : Air2000.IoC.Extensions.Command.Command, ISequenceCommand
    {
        [Inject]
        public ISequencer sequencer { get; set; }

        public SequenceCommand()
        {
        }

        new public void Fail()
        {
            if (sequencer != null)
            {
                sequencer.Stop(this);
            }
        }

        new virtual public void Execute()
        {
            throw new SequencerException("You must override the Execute method in every SequenceCommand", SequencerExceptionType.EXECUTE_OVERRIDE);
        }

        new public void Release()
        {
            retain = false;
            if (sequencer != null)
            {
                sequencer.ReleaseCommand(this);
            }
        }
    }
}
