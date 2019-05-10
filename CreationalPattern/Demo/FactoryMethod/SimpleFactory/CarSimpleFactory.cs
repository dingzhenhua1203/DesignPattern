using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPattern.Demo.FactoryMethod.SimpleFactory
{
    public class CarSimpleFactory
    {
        public static ICar Create(string type)
        {
            ICar result = null;
            switch (type)
            {
                case "SuperCar":
                    result = new SuperCar(); break;
                case "SUV":
                    result = new SUV(); break;
                case "Bus":
                    result = new Bus(); break;
                default:
                    result = new Bus(); break;
            }
            return result;
        }
    }
}
