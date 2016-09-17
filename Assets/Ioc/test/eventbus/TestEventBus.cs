using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using Air2000.IoC.Extensions.Event;

namespace Assets.Ioc.test.eventbus
{
    public class TestEventBus : MonoBehaviour
    {
        void Start()
        {
            EventProcessor eventProcessor = new EventProcessor();
            eventProcessor.Register("Hello", Hello);
            eventProcessor.Register("HelloEX", HelloEX);

            eventProcessor.Notify("Hello", this);
            eventProcessor.Notify("HelloEX", this);

            eventProcessor.Unregister("Hello", Hello);
            eventProcessor.Unregister("HelloEX", HelloEX);

            eventProcessor.Notify("Hello", this);
            eventProcessor.Notify("HelloEX", this);
        }

        void Hello()
        {
            int a = 1;
        }

        void HelloEX(object data)
        {
            int a = 1;
        }
    }
}
