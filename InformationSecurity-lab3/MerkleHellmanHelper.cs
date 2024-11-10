using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace InformationSecurity_lab3
{
    public static class MerkleHellmanHelper
    {
        private const char spaceSign = ' ';

        public static (BigInteger, int) GetMN(BigInteger sequenceSumm)
        {
            RandomBigInteger rnd = new RandomBigInteger();

            BigInteger delta = sequenceSumm / 20;
            BigInteger m = rnd.NextBigInteger(sequenceSumm, sequenceSumm + delta);

            int n = MathHelper.RandomSimpleNumber(m);

            return (m, n);
        }

        public static SuperincreasingSequence GetInverseSequence(SuperincreasingSequence sequence, BigInteger m, int n)
        {
            var inverseSequence = new SuperincreasingSequence(sequence.Size);

            for (int i = 0; i < sequence.Size; i++)
            {
                BigInteger currentValue = (sequence[i] * n) % m;
                inverseSequence[i] = currentValue;
            }

            return inverseSequence;
        }

        public static string Encrypt(string str, BigInteger[] publicKey)
        {
            var keyLen = publicKey.Length;
            var bits = BitHelper.StringToBits(str);
            List<BigInteger> encryptedText = new();

            for (int i = 0; i < bits.Length; i += keyLen)
            {
                var currentBits = bits.Skip(i).Take(keyLen).ToArray();

                var encryptBlock = VectorHelper.Multiply(currentBits, publicKey.ToArray());

                encryptedText.Add(encryptBlock);
            }

            return string.Join(spaceSign, encryptedText);
        }

        internal static string Decrypt(string text, BigInteger[] privateKey, BigInteger m, int n)
        {
            var values = text.Split(spaceSign).Select(x => BigInteger.Parse(x)).ToArray();

            BigInteger nInverse = MathHelper.InverseNumber(n, m);

            List<bool> decryptedText = new();

            for (int i = 0; i < values.Length; i++)
            {
                BigInteger value = (values[i] * nInverse) % m;
                var bits = VectorHelper.ExtractBits(privateKey, value);

                decryptedText.AddRange(bits);
            }

            var str = BitHelper.BitsToString(decryptedText.ToArray());

            return str;
        }
    }
}
