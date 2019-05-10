using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPattern.Demo.FactoryMethod.SimpleFactory
{
    public interface ICar
    {
        void Print();
    }
    public class Bus : ICar
    {
        public void Print()
        {
            Console.WriteLine("公共汽车");
        }
    }
    public class SUV : ICar
    {
        public void Print()
        {
            Console.WriteLine("SUV");
        }
    }
    public class SuperCar : ICar
    {
        public void Print()
        {
            Console.WriteLine("超跑");
        }
    }
}
