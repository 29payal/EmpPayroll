using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeePayroll
{
    internal class EmployeePresentAbsent
    {
        public static void EmployeeAttenanceCheck()
        {
            Random random = new Random();
            int empCheck=random.Next(0, 2);//0,1
            Console.WriteLine("Random generated value "+ empCheck);
            if(empCheck==0)
            {
                Console.WriteLine("Employee Present");
            }
            else
            {
                Console.WriteLine("Employee Absent");
            }
        }
    }
}
