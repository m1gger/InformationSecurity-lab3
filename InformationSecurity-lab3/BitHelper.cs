using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationSecurity_lab3
{
    public static class BitHelper
    {
        public static bool[] StringToBits(string str)
        {
            var bytes = Encoding.BigEndianUnicode.GetBytes(str);
            var bitArray = new BitArray(bytes);
            bool[] bits = new bool[bitArray.Length];
            bitArray.CopyTo(bits, 0);

            return bits;
        }

        public static string BitsToString(bool[] bits)
        {
            var bitArray2 = new BitArray(bits);
            var bytes2 = BitArrayToByteArray(bitArray2);
            var str = Encoding.BigEndianUnicode.GetString(bytes2);

            return str;
        }

        private static byte[] BitArrayToByteArray(BitArray bits)
        {
            byte[] ret = new byte[(bits.Length - 1) / 8 + 1];
            bits.CopyTo(ret, 0);
            return ret;
        }
    }
}
