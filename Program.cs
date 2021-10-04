using System;
using System.Linq;
using static System.Console;

namespace Prime_Number
{
    class Program
    {
        static long MaxPrime(long num)
        {
            long CurrMaxPrime = -1;

            //If num is divisible by 2, store CurrMaxPrime
            //as 2. Keep on dividing num until it is not 
            //divisible by 2. After each division, update num as num/2
            if (num % 2 == 0){
                CurrMaxPrime = 2;
                while(num %2 == 0){
                    num = num/2;
                }
            }

            //At this point, num must be odd. Starting with 
            //3 to the square root of num, if divisible, divide
            //and update num, and update CurrMaxPrime
            for( long i = 3; i <= Math.Sqrt(num); i += 2){
                while (num % i == 0){
                    CurrMaxPrime = i;
                    num = num/i;
                }
            }

            //if the modified num is greater than 2,
            //update the CurrMaxPrime with num
            if (num > 2)
            {
                CurrMaxPrime = num;
            }

            return CurrMaxPrime;
        }
        static void Main(string[] args)
        {
            WriteLine("Largest prime factor of " + 600851475143 + "is: " + MaxPrime(600851475143));
        }
        //Solution found below
        //https://www.alphacodingskills.com/cs/pages/cs-program-find-the-largest-prime-factor-of-a-number.php
    }
}
