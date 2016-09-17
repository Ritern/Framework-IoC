using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Ioc.extensions.dispatcher.eventdispatcher.api;
using Assets.Ioc.extensions.pool.api;

namespace Assets.Ioc.extensions.dispatcher.eventdispatcher.impl
{
    public class TmEvent:IEvent,IPoolable
    {
        public object type { get; set; }
        public IEventDispatcher target { get; set; }
        public object data { get; set; }
        protected int retainCount;
        public TmEvent() { }
        public TmEvent(object type,IEventDispatcher target,object data)
        {
            this.type = type;
            this.target = target;
            this.data = data;
        }

        #region IPoolable implementation

        public void Restore()
        {
            this.type = null;
            this.target = null;
            this.data = null;
        }

        public void Retain()
        {
            retainCount++;
            System.Console.WriteLine("Retain: " + retainCount);
        }

        public void Release()
        {
            retainCount--;
            System.Console.WriteLine("Release: " + retainCount);
            if (retainCount == 0)
            {
                target.ReleaseEvent(this);
            }
        }

        public bool retain
        {
            get
            {
                return retainCount > 0;
            }
        }

        #endregion
    }
}
