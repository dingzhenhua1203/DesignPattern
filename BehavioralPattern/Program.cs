using BehavioralPattern.Demo.ChainOfResponsibility;
using BehavioralPattern.Demo.Stragety;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            StragetyDemo demo = new StragetyDemo();
            demo.TestDemo();
            Console.ReadKey();

            ChainOfResponsibilityDemo chainDemo = new ChainOfResponsibilityDemo();
            chainDemo.TestDemo();
            Console.ReadKey();
        }
    }
}
