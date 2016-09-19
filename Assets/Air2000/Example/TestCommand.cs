/*----------------------------------------------------------------
            // Copyright © 2014-2016 Air2000
            // 
            // FileName: TestCommand.cs
			// Describle:
			// Created By:  Wells Hsu
			// Date&Time:  2016/9/18 17:29:36
            // Modify History:
            //
//----------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Air2000.IoC.Core;
using Air2000.IoC.Extensions.Injector;
using Air2000.IoC.Extensions.Command;
using UnityEngine;

namespace Assets.Air2000.Example
{
    public class Command1 : Command
    {
        public override void Execute()
        {
            base.Execute();
        }
        public override void Fail()
        {
            base.Fail();
        }
        public override void Restore()
        {
            base.Restore();
        }
        public override void Retain()
        {
            base.Retain();
        }
        public override void Release()
        {
            base.Release();
        }
    }
    public class Command2 : Command
    {
        public override void Execute()
        {
            base.Execute();
        }
        public override void Fail()
        {
            base.Fail();
        }
        public override void Restore()
        {
            base.Restore();
        }
        public override void Retain()
        {
            base.Retain();
        }
        public override void Release()
        {
            base.Release();
        }
    }
    public class TestCommand : MonoBehaviour
    {
        void Start()
        {
            InjectionBinder injectionBinder = new InjectionBinder();
            injectionBinder.Bind<IInstanceProvider>().Bind<IInjectionBinder>().ToValue(injectionBinder);
            injectionBinder.Bind<ICommandBinder>().To<CommandBinder>().ToSingleton();
            ICommandBinder commandBinder = injectionBinder.GetInstance<ICommandBinder>();
            commandBinder.Bind<Command1>().To<Command1>();
            commandBinder.Bind<Command2>().To<Command2>();
            
            int a = 1;
        }
    }
}
