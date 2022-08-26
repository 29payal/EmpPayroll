using System;

namespace EmployeePayroll
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Employee wage");
            Console.WriteLine("Choose option\n 1. Check absent present\t 2. Daily emp wage\t 3.Part time Wages\t 4.Parttime Wage SwitchCase ");
            int option=Convert.ToInt32(Console.ReadLine());
             switch(option)
            {             
                case 1:
                    EmployeePresentAbsent.EmployeeAttenanceCheck();
                       break;
                case 2:
                    DailyWage.CalculateDailyWage();
                    break;
                case 3:
                    PartTimeWage.CalculatePercentage();
                    break;
                case 4:
                    ParttimewageSwitchCase.CalculateWAges();
                    break;
                default:
                    Console.WriteLine("Entered wrong choice");
                    break;

             }
        }
    }
}
