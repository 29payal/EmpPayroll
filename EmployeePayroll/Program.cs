﻿using System;

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