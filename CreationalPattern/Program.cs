using CreationalPattern.Demo.AbstractFactory;
using CreationalPattern.Demo.FactoryMethod;
using CreationalPattern.Demo.FactoryMethod.SimpleFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 说明
            /* 
             * “创建型模式”关心对象的创建过程；
             * “结构型模式”涉及类或对象的组合；
             * “行为型模式”刻画了类和对象交互及分配职责的方式
             * 创建型模式，共五种：工厂方法模式、抽象工厂模式、单例模式、建造者模式、原型模式。
             * 结构型模式，共七种：适配器模式、装饰器模式、代理模式、外观模式、桥接模式、组合模式、享元模式。
             * 行为型模式，共十一种：策略模式、模板方法模式、观察者模式、迭代子模式、责任链模式、命令模式、备忘录模式、状态模式、访问者模式、中介者模式、解释器模式。
             * 简单工厂模式（Simple Factory Pattern）属于类的创新型模式，又叫静态工厂方法模式（Static FactoryMethod Pattern）,
             * 是通过专门定义一个类来负责创建其他类的实例，被创建的实例通常都具有共同的父类。
            */
            #endregion
            //简单工厂模式
            SimpleFactoryDemo simpleDemo = new SimpleFactoryDemo();
            simpleDemo.TestDemo();
            Console.ReadKey();
            //工厂方法模式
            FactoryMethodDemo factoryDemo = new FactoryMethodDemo();
            factoryDemo.TestDemo();
            Console.ReadKey();
            //抽象工厂模式
            AbstractFactoryDemo abstractDemo = new AbstractFactoryDemo();
            abstractDemo.TestDemo();
            Console.ReadKey();
        }
    }
}
