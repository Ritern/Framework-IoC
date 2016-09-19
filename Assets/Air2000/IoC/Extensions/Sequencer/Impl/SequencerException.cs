/*----------------------------------------------------------------
            // Copyright © 2014-2016 Air2000
            // 
            // FileName: SequencerException.cs
			// Describle:
			// Created By:  Wells Hsu
			// Date&Time:  2016/9/18 20:25:41
            // Modify History:
            //
//----------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Air2000.IoC.Extensions.Sequencer
{
    public class SequencerException : Exception
    {
        public SequencerExceptionType type { get; set; }

        public SequencerException() : base()
        {
        }

        /// Constructs a SequencerException with a message and SequencerExceptionType
        public SequencerException(string message, SequencerExceptionType exceptionType) : base(message)
        {
            type = exceptionType;
        }
    }
}
