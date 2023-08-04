//factory design pattern
namespace AbstractFactoryDesignPattern
{
    public class Program
    {
        public static void Main(String[] args)
        {
            IEmployeeFactory factory = new ContractualEmployeeFactory();
            IEmployee emp = factory.GetEmployee();

            emp.EmployeeDetails();
        }
    }
    public interface IEmployee
    {
        void EmployeeDetails();
    }
    public class PermanantEmployee : IEmployee
    {
        public void EmployeeDetails()
        {
            Console.WriteLine("this is a permanant Employee!");
        }
    }
    public class ContractualEmployee : IEmployee
    {
        public void EmployeeDetails()
        {
            Console.WriteLine("this is a Contractutal Employee!");
        }
    }
    public class Internship : IEmployee
    {
        public void EmployeeDetails()
        {
            Console.WriteLine("this is an internship Employee!");
        }
    }
    public interface IEmployeeFactory
    {
        IEmployee GetEmployee();
    }
    public class PermanantEmployeeFactory : IEmployeeFactory
    {
        public IEmployee GetEmployee()
        {
            return new PermanantEmployee();
        }
    }
    public class ContractualEmployeeFactory : IEmployeeFactory
    {
        public IEmployee GetEmployee()
        {
            return new ContractualEmployee();
        }
    }
    public class InternshipEmployeeFactory : IEmployeeFactory
    {
        public IEmployee GetEmployee()
        {
            return new Internship();
        }
    }
}