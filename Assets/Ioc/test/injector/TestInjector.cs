using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Ioc.extensions.injector.api;
using Assets.Ioc.extensions.injector.impl;
using UnityEngine;
using System.Reflection;

namespace Assets.Ioc.test.injector
{
    public enum EnemyType
    {
        BASIC,
        ADVANCE,
    }

    public interface IEnemy
    {
        void Attack();
        void Beattack();
    }

    public class Boss : IEnemy
    {
        public void Attack() { }
        public void Beattack() { }
    }

    public class Monster : IEnemy
    {
        public void Attack() { }
        public void Beattack() { }
    }

    public class EnemyManager
    {
        [Inject(EnemyType.BASIC)]
        public IEnemy Monster { get; set; }

        [Inject(EnemyType.ADVANCE)]
        public IEnemy Boss { get; set; }
    }

    public class TestInjector : MonoBehaviour
    {
        void Start()
        {
            InjectionBinder injectionBinder = new InjectionBinder();
            injectionBinder.Bind<IEnemy>().To<Boss>().ToName(EnemyType.ADVANCE);
            injectionBinder.Bind<IEnemy>().To<Monster>().ToName(EnemyType.BASIC);
            injectionBinder.Bind<EnemyManager>().To<EnemyManager>().ToSingleton();
            //injectionBinder.ReflectAll();

            EnemyManager manager = injectionBinder.GetInstance<EnemyManager>();

            //List < object >
            ////EnemyManager manager = new EnemyManager();
            ////injectionBinder.injector.Inject(manager);
            //int a = 1;
        }
    }
}
