﻿using System;

namespace EmployeeWageCoputation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Employee Wages Computation ");
            int fullTime = 1;
            int empRate = 20;

            int empHrs = 0;
            int empWage = 1;
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == fullTime)
                empHrs = 8;

            empWage = empHrs * empRate;
            Console.WriteLine("Emp Wage: " + empWage);
            Console.ReadKey();
        }
    }
}
