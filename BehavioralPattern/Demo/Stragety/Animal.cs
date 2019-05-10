using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPattern.Demo.Stragety
{
    public abstract class Animal
    {
        public IEatBehavior behavior;
        public abstract void Eat();

    }
    public class People : Animal
    {
        public People(IEatBehavior behavior)
        {
            this.behavior = behavior;
        }
        public override void Eat()
        {
            this.behavior.Eat();
        }
        public void Play()
        {
            Console.WriteLine("玩CF");
        }
    }
    public class Dog : Animal
    {
        public Dog(IEatBehavior behavior)
        {
            this.behavior = behavior;
        }
        public override void Eat()
        {
            this.behavior.Eat();
        }
    }
}
