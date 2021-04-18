using System;

namespace EmployeeWageCoputation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Employee Wages Computation ");

            int fullTime = 1;
            int partTime = 0;
            int empRate = 20;

            int empHrs = 0;
            int empPartHrs = 0;
            int empWage = 1;
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == fullTime)
                empHrs = 8;
            else if (empCheck == partTime)
                empPartHrs = 4;

            empWage = empHrs * empRate;
            empPartHrs = empPartHrs * empRate;
            Console.WriteLine("Emp full Time Wage: " + empWage);
            Console.WriteLine("Emp part time Wage :" + empPartHrs);
            Console.ReadKey();
        }
    }
}
