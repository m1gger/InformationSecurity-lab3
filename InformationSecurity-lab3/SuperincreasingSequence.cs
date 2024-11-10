using System;
using System.Linq;
using System.Numerics;

namespace InformationSecurity_lab3
{
    public class SuperincreasingSequence
    {
        private BigInteger[] _superincreasingSequence;

        private int _size;

        private BigInteger? _summ;

        public int Size
        {
            get => _size;
        }

        public BigInteger Summ 
        {
            get 
            {
                if(_summ == null)
                {
                    _summ = _superincreasingSequence.Aggregate(BigInteger.Add);
                }
                return _summ.Value;
            }
        }

        public SuperincreasingSequence(int size)
        {
            _size = size;
            _superincreasingSequence = new BigInteger[_size];
        }

        public SuperincreasingSequence RandomFill()
        {
            RandomBigInteger rnd = new RandomBigInteger();

            BigInteger sum = 0;

            for (int i = 0; i < _size; i++)
            {
                var nextValue = rnd.NextBigInteger(sum + 1, sum + 4);
                sum += nextValue;
                _superincreasingSequence[i] = nextValue;
            }

            return this;
        }

        public BigInteger[] ToArray()
        {
            return _superincreasingSequence;
        }

        public BigInteger this[int index]
        {
            get => _superincreasingSequence[index];
            set => _superincreasingSequence[index] = value;
        }

        public override string ToString()
        {
            var str = string.Join('\n', _superincreasingSequence.Select((x, index) => $"{index.ToString("d3")} - {x}"));
            return str;
        }
    }
}
