using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPattern.Demo.ChainOfResponsibility
{
    public class ChainOfResponsibilityDemo
    {
        public void TestDemo()
        {
            PurchaseRequest request1 = new PurchaseRequest() { Money = 9000, RequestName = "买电脑" };
            PurchaseRequest request2 = new PurchaseRequest() { Money = 19000, RequestName = "采购奖品" };
            PurchaseRequest request3 = new PurchaseRequest() { Money = 40000, RequestName = "尾牙经费" };
            
            Approver manager = new Manager();
            Approver vicePresident = new VicePresident();
            Approver president = new President();
            Approver meeting = new Meeting();
            //设置责任链
            manager.NextApprover = vicePresident;
            vicePresident.NextApprover = president;
            president.NextApprover = meeting;
            meeting.NextApprover = null;
            //处理请求
            manager.HandleRequest(request1);
            Console.WriteLine("-------------------请求处理完毕-----------------------");
            manager.HandleRequest(request2);
            Console.WriteLine("-------------------请求处理完毕-----------------------");
            manager.HandleRequest(request3);
            Console.WriteLine("-------------------请求处理完毕-----------------------");
            Console.ReadKey();
        }
    }
}
