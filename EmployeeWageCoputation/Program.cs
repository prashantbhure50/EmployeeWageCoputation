using System;

namespace EmployeeWageCoputation
{
    class Program
    {
        static void Main(string[] args)
        {
            CConsole.WriteLine("Welcome To Employee Wages Computation ");

            int WagePerHour = 20;
            int FullDay = 8;
            int Month = 20;
            int totalOneMonth = Month * FullDay * WagePerHour;
            Console.WriteLine(totalOneMonth);
            Console.ReadKey();

        }
    }
}
