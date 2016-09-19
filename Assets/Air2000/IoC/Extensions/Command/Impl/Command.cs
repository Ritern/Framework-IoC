/*----------------------------------------------------------------
            // Copyright © 2014-2016 Air2000
            // 
            // FileName: Command.cs
			// Describle:
			// Created By:  Wells Hsu
			// Date&Time:  2016/9/18 16:48:01
            // Modify History:
            //
//----------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Air2000.IoC.Extensions.ObjPool;
using Air2000.IoC.Extensions.Injector;

namespace Air2000.IoC.Extensions.Command
{
    public class Command : ICommand, IPoolable
    {
        /// Back reference to the CommandBinder that instantiated this Commmand
        [Inject]
        public ICommandBinder commandBinder { get; set; }

        /// The InjectionBinder for this Context
        [Inject]
        public IInjectionBinder injectionBinder { get; set; }

        public object data { get; set; }

        public bool cancelled { get; set; }

        public bool IsClean { get; set; }

        public int sequenceId { get; set; }

        public Command()
        {
            //Set to false on construction to ensure that it's not double-injected on first use.
            //The pool will satisfy all injections on first use. The CommandBinder re-injects
            //every time the Command is recycled.
            IsClean = false;
        }

        public virtual void Execute()
        {
            throw new CommandException("You must override the Execute method in every Command", CommandExceptionType.EXECUTE_OVERRIDE);
        }

        public virtual void Retain()
        {
            retain = true;
        }

        public virtual void Release()
        {
            retain = false;
            if (commandBinder != null)
            {
                commandBinder.ReleaseCommand(this);
            }
        }

        /// Use/override this method to clean up the Command for recycling
        public virtual void Restore()
        {
            injectionBinder.injector.Uninject(this);
            IsClean = true;
        }

        public virtual void Fail()
        {
            if (commandBinder != null)
            {
                commandBinder.Stop(this);
            }
        }

        public void Cancel()
        {
            cancelled = true;
        }

        public bool retain { get; set; }
    }
}
