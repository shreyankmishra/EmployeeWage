using System;

namespace UC2
{
    class Program
    {
        static void Main(string[] args)
        {
            int isPresent = 1;
            int dailyWage, dailyHours;

            Random random = new Random();

            int checkValue = random.Next(2);

            if (checkValue == isPresent)
            {
                dailyHours = 8;
            }
            else
            {
                dailyHours = 0;
            }

            dailyWage = dailyHours * 20;

            Console.WriteLine("Daily wage is : " + dailyWage);
        }
    }
}
