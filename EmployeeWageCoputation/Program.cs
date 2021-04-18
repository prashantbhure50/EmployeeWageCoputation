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
            int empHrs = 1;
            int empPartHrs = 1;
            int empWage = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            switch (empCheck)
            {
                case 0:
                    empWage = empHrs * 8 * empRate;
                    break;

                case 1:
                    empPartHrs = empPartHrs * 4 * empRate;
                    break;




            }

            Console.WriteLine("Emp full Time Wage: " + empWage);
            Console.WriteLine("Emp part time Wage :" + empPartHrs);
            Console.ReadKey();
        }
    }
}
