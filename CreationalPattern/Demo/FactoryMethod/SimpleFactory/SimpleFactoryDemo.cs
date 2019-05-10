using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPattern.Demo.FactoryMethod.SimpleFactory
{
    /// <summary>
    /// 简单工厂（静态工厂方法）
    /// </summary>
    public class SimpleFactoryDemo
    {
        #region 说明
        /* 
         * 专门定义一个类来负责创建其他类的实例，被创建的实例通常都具有共同的父类。
         * 简单工厂(Simple Factory)模式又称为静态工厂方法(Static Factory Method)模式，属于类的创建型模式，通常它根据变量的不同返回不同的类的实例
         * 简单工厂模式的实质是由一个工厂类根据传入的参量，动态决定应该创建出哪一个产品类的实例。
         * 简单工厂模式实际上不属于23个GoF模式，但它可以作为GoF的工厂方法模式(Factory Method)的一个引导
         */
        #endregion
        public void TestDemo()
        {
            ICar bus = CarSimpleFactory.Create("Bus");
            ICar superCar = CarSimpleFactory.Create("SuperCar");
            ICar suv = CarSimpleFactory.Create("SUV");
            bus.Print();
            superCar.Print();
            suv.Print();
        }
    }
}
