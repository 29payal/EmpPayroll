using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayroll
{
    internal class HrsOrDaysForAMonth

    {
        public const int IS_FULL_TIME = 2;
        public const int IS_PART_TIME = 1;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUM_Of_WORKING_DAYS = 20;
        public const int MAX_HRS_IN_MONTH = 100;


        public static void CalculateEmployeeWage()

              {
                // Variables
                int empHrs = 0;
                int empWage = 0;
                int totalEmpWage = 0;
                int totalEmpHrs = 0;
                int totalWorkingDays = 0;

                while (totalEmpHrs <= MAX_HRS_IN_MONTH && totalWorkingDays < NUM_Of_WORKING_DAYS)
                {
                    totalWorkingDays++;
                    Random random = new Random();
                    int empCheck = random.Next(1, 3);//1,2
                    switch (empCheck)
                    {
                        case IS_FULL_TIME:
                            empHrs = 8;
                            
                            break;

                        case IS_PART_TIME:
                            empHrs = 4;
                            
                            break;

                        default:
                            empHrs = 0;
                            
                            break;
                    }
                    totalEmpHrs += empHrs;
                    Console.WriteLine("Days {0} and  empHrs {1}" ,totalWorkingDays ,totalEmpHrs);
                }
                totalEmpWage = totalEmpHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine();
                Console.WriteLine("Total Employee Wage is: " + totalEmpWage);
}
}
}
