using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPattern.Demo.AbstractFactory
{
    public interface IDataAccess
    {
        IUser GetUser();

        IDepartment GetDepartment();
    }
    public class OracleAccess: IDataAccess
    {
        public IUser GetUser() { return new OracelUser(); }

        public IDepartment GetDepartment() { return new OracelDepartment(); }
        public void Test() { Console.WriteLine(".."); }
    }

    public class MySQLAccess : IDataAccess
    {
        public IUser GetUser() { return new MySQLUser(); }

        public IDepartment GetDepartment() { return new MySQLDepartment(); }
    }

    public interface IUser {
        void Print();
    }
    public class OracelUser :IUser{
        public void Print() {
            Console.WriteLine("Oracel的user");
        }
    }
    public class MySQLUser : IUser
    {
        public void Print()
        {
            Console.WriteLine("MySQL的user");
        }
    }
    public interface IDepartment {
        void Print();
    }
    public class OracelDepartment : IDepartment
    {
        public void Print()
        {
            Console.WriteLine("Oracel的Department");
        }
    }
    public class MySQLDepartment : IDepartment
    {
        public void Print()
        {
            Console.WriteLine("MySQL的Department");
        }
    }
}
