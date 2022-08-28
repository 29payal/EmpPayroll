using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayroll
{
    internal class HrsOrDaysForAMonth

    {
        public static void CalculateEmployeeWage()
        {

            const int IS_FULL_TIME = 1;
            const int IS_PART_TIME = 2;
            const int EMP_RATE_PER_HOUR = 20;
            const int NUM_Of_WORKING_DAYS = 20;
            const int MAX_HRS_IN_MONTH = 100;
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
                    int empCheck = random.Next(0, 3);
                    switch (empCheck)
                    {
                        case IS_FULL_TIME:
                            empHrs = 8;
                            Console.WriteLine("Employee is Full Time");
                            break;

                        case IS_PART_TIME:
                            empHrs = 4;
                            Console.WriteLine("Employee is Present for Part Time");
                            break;

                        default:
                            empHrs = 0;
                            Console.WriteLine("Employee is Absent");
                            break;
                    }
                    totalEmpHrs += empHrs;
                    Console.WriteLine("Days:" + totalWorkingDays + "Employee Hours: " + empHrs);
                }
                totalEmpWage = totalEmpHrs * EMP_RATE_PER_HOUR;
                Console.WriteLine("Total Employee Wage is: " + totalEmpWage);

            }


        }

    }
}