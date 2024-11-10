using System;
using System.Collections.Generic;
using System.Numerics;

namespace InformationSecurity_lab3
{
    public static class VectorHelper
    {
        public static BigInteger Multiply(bool[] a, BigInteger[] b)
        {
            BigInteger sum = 0;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i])
                {
                    sum += b[i];
                }
            }

            return sum;
        }

        public static bool[] ExtractBits(BigInteger[] privateKey, BigInteger number)
        {
            List<bool> bits = new();

            BigInteger residue = number;

            for (int i = privateKey.Length-1; i >= 0 ; i--)
            {
                if(privateKey[i] <= residue)
                {
                    bits.Add(true);
                    residue -= privateKey[i];
                }
                else
                {
                    bits.Add(false);
                }
            }

            bits.Reverse();

            return bits.ToArray();
        }
    }
}
