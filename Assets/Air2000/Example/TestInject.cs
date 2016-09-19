/*----------------------------------------------------------------
            // Copyright © 2014-2016 Air2000
            // 
            // FileName: TestInject.cs
			// Describle:
			// Created By:  Wells Hsu
			// Date&Time:  2016/9/18 10:36:37
            // Modify History:
            //
//----------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Air2000.IoC.Extensions.Injector;
using UnityEngine;

namespace Assets.Air2000.Example
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

        [PostConstruct]
        public void PostConstructor()
        {
            int a = 1;
        }
    }
    public class TestInject : MonoBehaviour
    {
        void Start()
        {
            InjectionBinder injectionBinder = new InjectionBinder();
            injectionBinder.Bind<IEnemy>().To<Boss>().ToName(EnemyType.ADVANCE);
            injectionBinder.Bind<IEnemy>().To<Monster>().ToName(EnemyType.BASIC);
            injectionBinder.Bind<EnemyManager>().To<EnemyManager>().ToSingleton();

            EnemyManager manager = injectionBinder.GetInstance<EnemyManager>();
            int a = 1;
        }
    }
}
