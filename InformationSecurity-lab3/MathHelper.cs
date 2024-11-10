using System;
using System.Collections.Generic;
using System.Numerics;

namespace InformationSecurity_lab3
{
    public static class MathHelper
    {
        public static int RandomSimpleNumber(BigInteger maxValue)
        {
            int k = 70;

            Random rnd = new Random();

            List<int> simple_numbers = new ();
            int current_number = 2;
            while (true)
            {
                if (simple_numbers.Count >= k)
                {
                    break;
                }
                foreach (int simple_number in simple_numbers)
                {
                    if (current_number % simple_number == 0)
                    {
                        goto next_number;
                    }
                }
                if(current_number >= maxValue)
                {
                    break;
                }
                simple_numbers.Add(current_number);
                next_number:;
                current_number++;
            }

            int index = rnd.Next(0, simple_numbers.Count-1);
            return simple_numbers[index];
        }

        public static BigInteger InverseNumber(int n, BigInteger m)
        {

            BigInteger r1 = m;
            BigInteger r2 = n;
            BigInteger t1 = 0;
            BigInteger t2 = 1;
            BigInteger r = r1 % r2;
            BigInteger q = r1 / r2;
            BigInteger t = t1 - t2 * q;
            while(true)
            {
                r1 = r2;
                r2 = r;
                if(r2 == 0)
                {
                    break;
                }
                r = r1 % r2;
                q = r1 / r2;
                t1 = t2;
                t2 = t;
                t = t1 - t2 * q;
            }

            
            return NormalizeNumber(t2, m);
        }

        private static BigInteger NormalizeNumber(BigInteger number, BigInteger n)
        {
            if(number >= 0)
            {
                return number;
            }

            var factor = ((-number) / n) + 1;

            return number + factor * n;
        }
    }
}
