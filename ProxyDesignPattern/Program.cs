namespace DesignPattrenPractice
{
    public class Porgram
    {
        public static void Main(String[] args)
        {
            IEmployee emp = new EmployeeProxy();

            emp.createEmployee("ADMI", "tasdid");
            emp.createEmployee("ADMI", "bishal");
            emp.createEmployee("ADMIN", "mehedi");
            emp.createEmployee("ADMIN", "ishmam");

        }
    }
    public interface IEmployee
    {
        void createEmployee(string client,string name);
        void GetEmployee(string client);
        void DeleteEmployee(string client , int id);
    }
    public class EmployeeProxy : IEmployee
    {
        private Employee employee;
        public bool isObjeCreated = false;

       
        public void createEmployee(string client, string name)
        {
            //make a restriction only admin can access.
            // Lazy Instantiation.
            if (client is "ADMIN")
            {
                if (isObjeCreated)
                {
                    employee.createEmployee(client, name);
                }
                else
                {
                    employee = new Employee();
                    employee.createEmployee(client, name);
                    isObjeCreated = true;
                }
            }
            else
            {
                Console.WriteLine("access denied");
            }
        }

        public void DeleteEmployee(string client, int id)
        {
            if (client is "ADMIN")
            {
                if (isObjeCreated)
                {
                    employee.DeleteEmployee(client, id);
                }
                else
                {
                    employee = new Employee();
                    employee.DeleteEmployee(client, id);
                    isObjeCreated = true;
                }
               
            }
            else
            {
                Console.WriteLine("access denied");
            }
        }

        public void GetEmployee(string client)
        {
            if (client is "ADMIN")
            {
                if (isObjeCreated)
                {
                    employee.GetEmployee(client);
                }
                else
                {
                    employee = new Employee();
                    employee.GetEmployee(client);
                    isObjeCreated = true;
                }
                
            }
            else
            {
                Console.WriteLine("access denied");
            }
        }
    }

    public class Employee : IEmployee
    {
        public Employee()
        {
            Console.WriteLine("i am created");
        }
        public void createEmployee(string client, string name)
        {
            Console.WriteLine($"employee {name} is created");
            
        }

        public void DeleteEmployee(string client , int id)
        {
            Console.WriteLine($"employee {id} is deleted");
        }

        public void GetEmployee(string client)
        {
            Console.WriteLine($"List of Employee!");
        }
    }
}