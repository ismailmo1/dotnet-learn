using System;
namespace Prime.Services;
public class PrimeService
{
    public bool IsPrime(int candidate)
    {
        if (candidate < 2)
        {
            return false;
        }
        // super inefficient way of testing for primes
        // but im not a mathematician lol
        for (int divisor = 2; divisor <= Math.Sqrt(candidate); divisor++)
        {
            if (candidate % divisor == 0)
            {
                // we've found a divisor so it's not prime
                return false;
            }
            // no divisors found - so must be prime
        }
        return true;
    }
}
