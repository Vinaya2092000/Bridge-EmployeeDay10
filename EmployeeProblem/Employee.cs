using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeProblem
{
    // Already using class 
    public class Employee  
    {
        const int FULL_TIME = 1;
        const int PART_TIME = 2;
        int empHr = 0;
        int empWage = 0;
        int totalWage = 0;

        public object company { get; internal set; }

        public int Wage(string company, int wagePerHr, int totalWorkingDays, int totalWorkingHrs)
        {
            for (int i = 0; i < totalWorkingDays; i++)
            {
                Random random = new Random();
                int aCheck = random.Next(0, 3);
                switch (aCheck)
                {
                    case FULL_TIME:
                        empHr += 8;
                        break;
                    case PART_TIME:
                        empHr += 4;
                        break;
                    default:
                        empHr = 0;
                        break;
                }
                totalWorkingHrs += empHr;
                empWage = empHr * wagePerHr;
                Console.WriteLine(empWage);
                totalWage = totalWorkingHrs * wagePerHr;
                Console.WriteLine(" totalEmpWage for the company : " + company + "is: " + totalWage);
                return totalWage;
            }
            return totalWage;
        }
    }
}
