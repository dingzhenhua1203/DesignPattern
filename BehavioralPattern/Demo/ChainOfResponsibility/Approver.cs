using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPattern.Demo.ChainOfResponsibility
{
    public abstract class Approver
    {
        public Approver NextApprover { get; set; }

        public abstract void HandleRequest(PurchaseRequest request);

    }
    /// <summary>
    /// 组长
    /// </summary>
    public class Manager : Approver
    {
        public override void HandleRequest(PurchaseRequest request)
        {
            if (request.Money <= 10000)
            {
                Console.WriteLine("组长处理");
            }
            else if(this.NextApprover!=null){
                this.NextApprover.HandleRequest(request);
            }
        }
    }
    /// <summary>
    /// 副总
    /// </summary>
    public class VicePresident: Approver
    {
        public override void HandleRequest(PurchaseRequest request)
        {
            if (request.Money <= 20000)
            {
                Console.WriteLine("副总处理");
            }
            else if (this.NextApprover != null)
            {
                this.NextApprover.HandleRequest(request);
            }
        }
    }
    /// <summary>
    /// 总经理
    /// </summary>
    public class President : Approver
    {
        public override void HandleRequest(PurchaseRequest request)
        {
            if (request.Money <= 30000)
            {
                Console.WriteLine("总经理处理");
            }
            else if (this.NextApprover != null)
            {
                this.NextApprover.HandleRequest(request);
            }
        }
    }
    public class Meeting : Approver
    {
        public override void HandleRequest(PurchaseRequest request)
        {
            if (request.Money > 30000)
            {
                Console.WriteLine("会议处理");
            }
        }
    }
}
