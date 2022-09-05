namespace EmployeeWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee wage computation");
            Employee employee1 = new Employee();
            employee1.Wage("Zoro", 20,20,100);
            Employee employee2 = new Employee();
            employee1.Wage("Airo", 15,20,100);
            Employee employee3 = new Employee();
            employee3.Wage("Gojo", 30,30,100);
            Console.WriteLine($"Total wage for an employee of Zoro is {employee1.totalWage}");
            Console.WriteLine($"Total wage for an employee of Airo is {employee2.totalWage}");
            Console.WriteLine($"Total wage for an employee of Gojo is {employee3.totalWage}");
        }
    }
}