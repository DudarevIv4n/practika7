using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическая_7
{
    class Fraction : Pair
    {
        private int _integerPart;
        private double _fractionalPart;

        public Fraction(int integer, int fractional) : base(integer, fractional)
        {
            _integerPart = integer;
            _fractionalPart = fractional;
        }

        public bool AreEqual(Fraction fraction)
        {
            if (_integerPart == _fractionalPart && fraction._fractionalPart == fraction._integerPart && _integerPart == fraction._integerPart)
            {
                return true;
            }
            else
                return false;
        }
    }
}
