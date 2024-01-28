using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATKINO
{
    public class Sieve
    {
        public List<int> FindPrimes(int limit)
        {
            List<int> primes = new List<int>();
            bool[] isPrime = new bool[limit + 1];
            int sqrtLimit = (int)Math.Sqrt(limit);
            for (int x = 1; x <= sqrtLimit; x++)
            {
                for (int y = 1; y <= sqrtLimit; y++)
                {
                    int n = (4 * x * x) + (y * y);
                    if (n <= limit && (n % 12 == 1 || n % 12 == 5))
                        isPrime[n] = !isPrime[n];

                    n = (3 * x * x) + (y * y);
                    if (n <= limit && n % 12 == 7)
                        isPrime[n] = !isPrime[n];

                    n = (3 * x * x) - (y * y);
                    if (x > y && n <= limit && n % 12 == 11)
                        isPrime[n] = !isPrime[n];
                }
            }
            for (int n = 5; n <= sqrtLimit; n++)
            {
                if (isPrime[n])
                {
                    int square = n * n;
                    for (int k = square; k <= limit; k += square)
                        isPrime[k] = false;
                }
            }
            if (limit >= 2)
            {
                primes.Add(2);
            }
            if (limit >= 3)
            {
                primes.Add(3);
            }
            for (int n = 5; n <= limit; n++)
            {
                if (isPrime[n])
                    primes.Add(n);
            }
            return primes;
        }
    }
}
