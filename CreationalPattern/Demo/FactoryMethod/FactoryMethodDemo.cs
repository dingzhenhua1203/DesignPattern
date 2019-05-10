using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPattern.Demo.FactoryMethod
{
    public class FactoryMethodDemo
    {
        public void TestDemo()
        {
            IMobileFactory factory = new SamSungFactory();
            IMobile mobile = factory.Creator();
            mobile.Call();
            factory = new HuaWeiFactory();
            mobile = factory.Creator();
            mobile.Call();
            factory = new IPhoneFactory();
            mobile = factory.Creator();
            mobile.Call();
            Console.ReadKey();
        }
    }

}
