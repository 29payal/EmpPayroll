using System;

namespace EmployeePayroll
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Employee wage");
            //if(condition)
            //{

            //}
            //else
            //{

            //}
            // Random random = new Random();
            //Console.WriteLine(Random.Next(10));//0-9
            // Console.WriteLine(random.Next(10,20));//10-19
            //Console.WriteLine(random.NextDouble());//0.0-1.0
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
