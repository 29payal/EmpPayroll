using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeePayroll
{
    internal class ParttimewageSwitchCase
    {
        public static void CalculateWAges()
        {

            const int IS_FULL_TIME = 1;
            const int IS_PART_TIME = 2;
            const int EMP_RATE_PER_HOUR = 20;

            int empHrs = 0;
            Random random = new Random();
            int empCheck = random.Next(1, 3);//1 ,2

            switch (empCheck)
            {
                case 1:
                    empHrs = 8;
                    Console.WriteLine("Employee is present for full time ");
                    break;
                    case 2:
                    empHrs = 4;
                    Console.WriteLine("employee is present for part time");
                    break;
                    default:
                    empHrs = 0;
                    Console.WriteLine("employee is absent");
                    break;
            }
            int empWage=empHrs*EMP_RATE_PER_HOUR;
            Console.WriteLine("Employee daily wage including the part time is " +empWage);  

        }
    }

}