using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPattern.Demo.AbstractFactory
{
    public class AbstractFactoryDemo
    {
        public void TestDemo() {
            IDataAccess dataAccess = new MySQLAccess();
            //dataAccess = new OracleAccess();
            IUser user =dataAccess.GetUser();
            user.Print();
            IDepartment department = dataAccess.GetDepartment();
            department.Print();
        }
    }
}
