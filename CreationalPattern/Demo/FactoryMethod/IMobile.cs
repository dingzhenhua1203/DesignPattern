using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPattern.Demo.FactoryMethod
{
    public interface IMobile
    {
        void Call();
    }
    public class SamSung : IMobile {
        public void Call() {
            Console.WriteLine("三星手机");
        }
    }
    public class IPhone : IMobile
    {
        public void Call()
        {
            Console.WriteLine("苹果手机");
        }
    }
    public class HuaWei : IMobile
    {
        public void Call()
        {
            Console.WriteLine("华为手机");
        }
    }
}
