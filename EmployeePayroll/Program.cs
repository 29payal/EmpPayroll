using System;

namespace EmployeePayroll
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Employee wage");
            Console.WriteLine("Choose option\n 1. Check absent present");
            int option=Convert.ToInt32(Console.ReadLine());
             switch(option)
            {             
                case 1:EmployeePresentAbsent.EmployeeAttenanceCheck();
                       break;
                default:
                    Console.WriteLine("Entered wrong choice");
                    break;

             }
        }
    }
}
