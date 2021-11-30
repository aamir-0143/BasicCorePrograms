using System;

namespace BasicCoreProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Program number which is to be executed \n 1. flipCoin \n 2. LeapYear \n 3. Power");
            Console.WriteLine(" 4. Exit");
            int option = Convert.ToInt32(Console.ReadLine());
            bool flag = true;
            while (flag)
            {
                switch (option)
                {
                    case 1:
                        BasicPrograms programs = new BasicPrograms();
                        programs.FlipCoin();
                        break;

                    case 2:
                        BasicPrograms check = new BasicPrograms();
                        check.LeapYear();
                        break;

                    case 3:
                        BasicPrograms res = new BasicPrograms();
                        res.PowerOfTwo();
                        break;

                    case 4:
                        flag = false;
                        break;

                }
            }
        }
    }
}