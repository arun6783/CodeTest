﻿namespace Model
{
    public class PrimeNumberFinder
    {
        public static bool IsNumberPrime(int number)
        {
            if (number == 1) return false;
            if (number == 2) return true;

            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                    return false;
            }

            return true;

        }

    }
}