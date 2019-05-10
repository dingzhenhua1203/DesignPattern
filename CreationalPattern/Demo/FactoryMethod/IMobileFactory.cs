using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPattern.Demo.FactoryMethod
{
    public interface IMobileFactory
    {
        IMobile Creator();
    }
    public class SamSungFactory: IMobileFactory
    {
        public IMobile Creator() {
            return new SamSung();
        }
    }
    public class IPhoneFactory: IMobileFactory
    {
        public IMobile Creator()
        {
            return new IPhone();
        }
    }
    public class HuaWeiFactory : IMobileFactory
    {
        public IMobile Creator()
        {
            return new HuaWei();
        }
    }
}
