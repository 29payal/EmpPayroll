using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeePayroll
{
    internal class PartTimeWage
    {
        public static void CalculatePercentage()
        {

            const int IS_FULL_TIME = 1;
            const int IS_PART_TIME = 2;
            const int EMP_RATE_PER_HOUR = 20;

            int empHrs = 0;
            Random random = new Random();
            int empCheck=random.Next(1, 3);//1 ,2

            if (empCheck == IS_FULL_TIME)
            {
                empHrs = 8;
                Console.WriteLine("Emp is present for full time");
            }
            else if (empCheck == IS_PART_TIME)
            {
                empHrs = 4;
                Console.WriteLine("Emp is present for part time");
            }
            else
            {
                empHrs = 0;
                Console.WriteLine("Absent");
            }
            int empWage=empHrs*EMP_RATE_PER_HOUR;
            Console.WriteLine("Emp daily wage including part time also is :" +empWage);
        }
    }
}
