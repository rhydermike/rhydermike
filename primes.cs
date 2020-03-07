using System;

namespace Primes
{

class prime 
    {
        static void Main(string[] args)
        {
        bool prime;
        int TotalAttempts = 5000;

        for (int x=2;x<TotalAttempts;x++) // the number to be tested
        {
            prime = true;
            for (int y=2;y<(x-1);y++) // the number to divide by
            {
                float FloatResult = (float)x/(float)y;
                int IntResult = x/y;
                if (FloatResult==(float)IntResult)
                   {
                      prime=false;
                 
                      break;
                   }            
            }
            if (prime == true)
            {
                Console.WriteLine(x + " is a prime!");
            }

        }
        }

    }
}
