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
        public void Factors() 
        {
                Console.WriteLine("Enter the Number to Calculate Prime Factorization");
                int num = Convert.ToInt32(Console.ReadLine());
                for (int i = 2; i <= num; i++)
                {
                    if (num % i == 0)
                    {

                        Console.WriteLine(i);
                    }
                }
        }
        public void QuotientRemainder() 
        {
            Console.WriteLine("Enter the Dividend");
            double dividend = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Divisor");
            double divisor = Convert.ToDouble(Console.ReadLine());
            double quotient = dividend / divisor;
            double remainder = dividend % divisor;
            Console.WriteLine("Quotient is : " + quotient);
            Console.WriteLine("Remainder is : " + remainder);
        }
        public void SwappingNumbers() 
        {
            Console.WriteLine("Enter the First number :");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second number :");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            firstNumber = firstNumber + secondNumber;
            secondNumber = firstNumber - secondNumber;
            firstNumber = firstNumber - secondNumber;
            Console.WriteLine("After Swapping these Two Numbers : First number is =" + firstNumber + " and Second number is =" + secondNumber);
        }
        public void EvenOdd()
        {
            Console.WriteLine("Enter the number to Check");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("{0} is an Even number", num);
            }
            else
            {
                Console.WriteLine("{0} is an Odd number", num);
            }
        }
        public void Alphabet()
        {
            Console.WriteLine("Enter an Alphabet :");
            char letter = Convert.ToChar(Console.ReadLine());
            if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
            {
                Console.WriteLine("{0} is a vowel", letter);
            }
            else
            {
                Console.WriteLine("{0} is a Consonant", letter);
            }
        }
        public void LargestNumber() 
        {
            Console.WriteLine("Enter the First number :");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second number :");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Third number :");
            int thirdNumber = Convert.ToInt32(Console.ReadLine());
            if (firstNumber > secondNumber && firstNumber > thirdNumber)
                Console.WriteLine("{0} is the Largest number", firstNumber);
            else if (secondNumber > firstNumber && secondNumber > thirdNumber)
                Console.WriteLine("{0} is the Largest number", secondNumber);
            else if (thirdNumber > firstNumber && thirdNumber > secondNumber)
                Console.WriteLine("{0} is the Largest number", thirdNumber);
            else
                Console.WriteLine("The Three numbers are equal");
        }
    } 
}