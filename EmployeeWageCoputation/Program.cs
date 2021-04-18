using System;

namespace EmployeeWageCoputation
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome To Employee Wages Computation ");

            int WagePerHour = 20;
            int FullDay = 8;
            Random random = new Random();
            int Hours = 0;
            int days = 0;
            int totalOneMonth = 0;
            while (days < 20 && Hours < 100)
            {
                int Check = random.Next(0, 2);
                if (Check == 0)
                {
                    days++;
                }
                else
                {
                    Hours++;
                }
                totalOneMonth = totalOneMonth + FullDay * WagePerHour;
            }
            Console.WriteLine(totalOneMonth);


            Console.ReadKey();
        }
    }
}
