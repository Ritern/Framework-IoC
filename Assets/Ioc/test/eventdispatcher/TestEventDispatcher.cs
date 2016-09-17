using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Ioc.extensions.dispatcher.eventdispatcher.api;
using Assets.Ioc.extensions.dispatcher.eventdispatcher.impl;
using Assets.Ioc.extensions.injector.api;
using Assets.Ioc.extensions.injector.impl;
using Assets.Ioc.extensions.reflector.api;
using Assets.Ioc.extensions.reflector.impl;
using UnityEngine;

namespace Assets.Ioc.test.eventdispatcher
{
    public class CustomEvent : IEvent
    {
        public object type { get; set; }
        public IEventDispatcher target { get; set; }
        public object data { get; set; }
    }
    public class TestEventDispatcher : MonoBehaviour
    {
        public EventDispatcher Dispatcher;
        void Start()
        {
            Dispatcher = new EventDispatcher();
            //Dispatcher.Bind("Hello").To(onHelloCallback).To(onHelloCallback2);
            Dispatcher.AddListener("Hello", onHelloCallback);
            Dispatcher.AddListener("Hello", onHelloCallback2);

            //Dispatcher.Bind("Hello").To(onHelloCallback2);

            CustomEvent evtObj = new CustomEvent() { target = null };

            Dispatcher.Trigger("Hello", evtObj);

            InjectionBinder injectionBinder = new InjectionBinder();
            injectionBinder.Bind<EventDispatcher>().ToValue(Dispatcher).ToName("dispatcher1").ToInject(false);
            injectionBinder.Bind<EventDispatcher>().ToValue(new EventDispatcher()).ToName("dispatcher2").ToInject(false);

            AABB aabb = new AABB();
            injectionBinder.injector.Inject(aabb);


            int b = 1;
        }

        void onHelloCallback()
        {
            int a = 1;
        }
        void onHelloCallback2()
        {
            int a = 1;
        }
    }

    public class AABB
    {
        [Inject]
        public EventDispatcher dispatcher1 { get; set; }

        [Inject]
        public EventDispatcher dispatcher2 { get; set; }

    }

}
