using EmployeeProblem;
namespace EmployeeProblem
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee wage computation");
            Employee emp = new Employee();
            emp.Wage("Zoro", 20, 10, 100);
            emp.Wage("Airo", 15, 10, 100);
            emp.Wage("Gojo", 10, 10, 100);
        }
    }
}
