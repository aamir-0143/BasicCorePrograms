using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCoreProblems  
{
    public class BasicPrograms
    {
        public void FlipCoin() 
        {
            Console.WriteLine("Enter the number of times to flip coin");
            double num = Convert.ToDouble(Console.ReadLine());
            Random random = new Random();
            double headCount = 0, tailCount = 0;
            for (int i = 0; i < num; i++)
            {
                double flip = random.NextDouble();
                if (flip < 0.5)
                {
                    Console.WriteLine("Tails");
                    tailCount++;
                }
                else
                {
                    Console.WriteLine("Heads");
                    headCount++;
                }
            }
            headCount *= (100 / num);
            tailCount *= (100 / num);
            Console.WriteLine("The Percentage of Heads vs Tails is {0}% and {1}%", headCount, tailCount);
            Console.ReadKey();

        }
            public void LeapYear() 
            {
                Console.WriteLine("Enter the year");
                int year = Convert.ToInt32(Console.ReadLine());
                if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
                {
                    Console.WriteLine("{0} is a Leap Year", year);
                }
                else
                {
                    Console.WriteLine("{0} is not a Leap Year", year);
                }
            }
        public void PowerOfTwo() 
        {
            Console.WriteLine("Enter the power value");
            int exponent = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= exponent; i++)
            {
                Console.WriteLine("2^{0} " + " " + "= {1}", i, Math.Pow(2, i));
            }
        }
        public void Harmonic()
        {
                Console.WriteLine("Enter the last harmonic number");
                double num = Convert.ToDouble(Console.ReadLine());
                double harmonicSum = 0;
                for (double i = 1; i <= num; i++)
                {
                    Console.WriteLine("1/" + i + "=" + (1 / i));
                    harmonicSum += (1 / i);
                }
                Console.WriteLine("The Sum of harmonic number is :" + harmonicSum);
        }
        
    }
}