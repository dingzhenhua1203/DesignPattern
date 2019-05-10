using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPattern.Demo.Stragety
{
    public interface IEatBehavior
    {
        void Eat();
    }
    public class PeopleEat : IEatBehavior
    {
        public void Eat()
        {
            Console.WriteLine("吃米饭");
        }
    }
    public class DogEat : IEatBehavior
    {
        public void Eat()
        {
            Console.WriteLine("吃骨头");
        }
    }
}
