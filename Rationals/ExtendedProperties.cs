﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Rationals
{
    public partial struct Rational
    {
        /// <summary>
        /// True if the number is equal to zero
        /// </summary>
        public bool IsZero
        {
            get { return Numerator.IsZero; }
        }

        /// <summary>
        /// True if the number is equal to one
        /// </summary>
        public bool IsOne
        {
            get { return Numerator == Denominator; }
        }

        /// <summary>
        /// Gets a number that indicates the sign (negative, positive, or zero) of the rational number
        /// </summary>
        public int Sign
        {
            get { return Numerator.Sign * Denominator.Sign; }
        }

        /// <summary>
        /// Indicates whether the value of the rational number is a power of two.
        /// </summary>
        public bool IsPowerOfTwo { get { return Numerator.IsPowerOfTwo && Denominator.IsPowerOfTwo; } }

        /// <summary>
        /// Represents the exponent of 10 if the number was written in scientific notation.
        /// </summary>
        /// <example>
        /// Magnitude of 0 is 0.<br />
        /// Magnitude of 5 is 0.<br />
        /// Magnitude of 12 is 1.<br />
        /// Magnitude of 3 988 222 is 6.<br />
        /// Magnitude of 0.2223 is -1.<br />
        /// Magnitude of 0.04 is -2.<br />
        /// </example>
        public int Magnitude
        {
            get
            {
                if (IsZero)
                    return 0;

                double numLog = BigInteger.Log10(BigInteger.Abs(Numerator));
                double denLog = BigInteger.Log10(BigInteger.Abs(Denominator));
                return (int)Math.Floor(numLog - denLog);
            }
        }
    }
}