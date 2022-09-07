using System;

namespace EmployeePayroll
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Employee wage");
            Console.WriteLine("Choose option\n 1. Check absent present\t 2. Daily emp wage\t 3.Part time Wages\t 4.Parttime Wage SwitchCase\t 5. Emp wage for month\t 6. Num of working days or totalworkinghrs for a month\t 7.Refactor ");
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
                case 5:
                    WageForMonth.CalculateWageForMonth();
                    break;
                case 6:
                    HrsOrDaysForAMonth.CalculateEmployeeWage();
                    break;
                case 7:
                    Refactor.CalculateEmployeeWage();
                    break;
                default:
                    Console.WriteLine("Entered wrong choice");
                    break;

             }
        }
    }
}
