using System;

namespace BasicCoreProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Program number which is to be executed \n 1. flipCoin \n 2. LeapYear \n 3. Power");
            Console.WriteLine(" 4. Harmonic \n 5. Factors \n 6. QuotientRemainder \n 7. Exit");
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
                        BasicPrograms sum = new BasicPrograms();
                        sum.Harmonic();
                        break;

                    case 5:
                        BasicPrograms calculation = new BasicPrograms();
                        calculation.Factors();
                        break;

                    case 6:
                        BasicPrograms result = new BasicPrograms();
                        result.QuotientRemainder();
                        break;

                    case 7:
                        flag = false;
                        break;

                }
            }
        }
    }
}