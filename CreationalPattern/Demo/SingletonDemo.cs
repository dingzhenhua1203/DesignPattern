using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPattern.Demo
{
    /// <summary>
    /// 单例模式
    /// </summary>
    public class SingletonDemo
    {
        //定义私有构造函数，使外界不能创建该类实例
        private SingletonDemo()
        {
        }
        // 定义一个静态变量来保存类的实例
        private static SingletonDemo Instance = null;

        public static readonly object Locker=new object();//readonly只读 ；const常量

        /// <summary>
        /// 定义公有方法来生成类的实例
        /// </summary>
        /// <returns></returns>
        public static SingletonDemo GetInstance()
        {
            //构造函数私有化，外部无法new实例，所以需要提供静态的方法
            if (Instance == null)
            {
                Instance=new SingletonDemo();
            }
            return Instance;
        }

        /// <summary>
        /// 线程安全的单例
        /// </summary>
        /// <returns></returns>
        public static SingletonDemo GetInstanceThreadSafe()
        {
            if (Instance == null)
            {
                lock (Locker)
                {
                    if (Instance == null)
                    {
                        Instance = new SingletonDemo();
                    }
                }
            }
            return Instance;
        }
    }
}
