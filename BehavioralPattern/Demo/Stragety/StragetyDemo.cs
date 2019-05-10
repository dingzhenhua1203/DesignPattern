using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPattern.Demo.Stragety
{
    public class StragetyDemo
    {
        public void TestDemo()
        {
            Animal people = new People(new PeopleEat());
            Animal dog = new Dog(new DogEat());
            people.Eat();
            dog.Eat();
        }
    }
}
