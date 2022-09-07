using System;

namespace EmployeePayroll
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Employee wage");
            Console.WriteLine("Choose option\n 1. Check absent present\t 2. Daily emp wage\t 3.Part time Wages\t 4.Parttime Wage SwitchCase\t 5. Emp wage for month\t 6. Num of working days or totalworkinghrs for a month\t 7.Refactor\t 8.Compute Employee wage ");
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
                    Refactor.CalculateEmployeeWagee();
                    break;
                case 8:
                    ComputeEmployeeWage.ComputeEmployeeWagee("DMART" ,20,20,100);
                    Console.ReadLine();
                    ComputeEmployeeWage.ComputeEmployeeWagee("WIPRO" ,20,20,100 );
     
                    break;

                default:
                    Console.WriteLine("Entered wrong choice");
                    break;

             }
        }
    }
}
