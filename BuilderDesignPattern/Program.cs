namespace BuilderDesignPattern
{
    public class Program
    {
        public static void Main(String[] args)
        {
            EmployeeBuilder builder = new EmployeeBuilder();

            builder.SetId(1)
                   .SetDepartment("software engineer");

            var emp = builder.build();
            emp.ShowDetails();
        }
    }
    public class Employee
    {
        public int Id { get; set; }

        public string? Name { get; set; };

        public string? Department { get; set; }

        public void ShowDetails()
        {
            Console.WriteLine($"ID = {Id} Name = {Name} Department = {Department}");
        }
    }
    public class EmployeeBuilder
    {
        private readonly Employee employee;

        public EmployeeBuilder()
        {
            employee = new Employee();
        }
        public EmployeeBuilder SetId(int id)
        {
            employee.Id = id;
            return this;
        }
        public EmployeeBuilder SetName(string name)
        {
            employee.Name = name;
            return this;
        }
        public EmployeeBuilder SetDepartment(string department)
        {
            employee.Department = department;
            return this;
        }

        public Employee build()
        {
            return employee;
        }


    }
}