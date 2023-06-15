using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fractions
{
    /// <summary>
    /// Represents a fraction with a numerator and denominator.
    /// </summary>
    public class Fraction
    {
        private int numer;
        private int denom;

        /// <summary>
        /// Initializes a new instance of the <see cref="Fraction"/> class with default values of 0/1.
        /// </summary>
        public Fraction()
        {
            numer = 0;
            denom = 1;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Fraction"/> class with the specified numerator and a denominator of 1.
        /// </summary>
        /// <param name="num">The numerator of the fraction.</param>
        public Fraction(int num)
        {
            numer = num;
            denom = 1;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Fraction"/> class with the specified numerator and denominator.
        /// </summary>
        /// <param name="num">The numerator of the fraction.</param>
        /// <param name="den">The denominator of the fraction.</param>
        public Fraction(int num, int den)
        {
            numer = num;
            denom = den;
        }

        // Getters & Setters

        /// <summary>
        /// Gets the numerator of the fraction.
        /// </summary>
        /// <returns>The numerator of the fraction.</returns>
        public int getNumer()
        {
            return numer;
        }

        /// <summary>
        /// Gets the denominator of the fraction.
        /// </summary>
        /// <returns>The denominator of the fraction.</returns>
        public int getDenom()
        {
            return denom;
        }

        /// <summary>
        /// Sets the numerator of the fraction.
        /// </summary>
        /// <param name="tmpNumer">The desired numerator.</param>
        public void setNumer(int tmpNumer)
        {
            numer = tmpNumer;
        }

        /// <summary>
        /// Sets the denominator of the fraction.
        /// </summary>
        /// <param name="tmpDenom">The desired denominator.</param>
        public void setDenom(int tmpDenom)
        {
            denom = tmpDenom;
        }

        /// <summary>
        /// Sets the value of the fraction to the specified numerator and denominator.
        /// </summary>
        /// <param name="tmpNumer">The desired numerator.</param>
        /// <param name="tmpDenom">The desired denominator.</param>
        public void setValue(int tmpNumer, int tmpDenom)
        {
            numer = tmpNumer;
            denom = tmpDenom;
        }

        /// <summary>
        /// Sets the value of the fraction to the value of the specified fraction.
        /// </summary>
        /// <param name="f">The fraction to set the value to.</param>
        public void setValue(Fraction f)
        {
            numer = f.numer;
            denom = f.denom;
        }

        /// <summary>
        /// Converts the fraction to its real number equivalent.
        /// </summary>
        /// <returns>The real number equivalent of the fraction.</returns>
        public double toDouble()
        {
            double dNumer = numer;
            double dDenom = denom;
            return dNumer / dDenom;
        }

        /// <summary>
        /// Converts the fraction to a string in the format Numerator/Denominator.
        /// </summary>
        /// <returns>The fraction as a string.</returns>
        public String toString()
        {
            String sFraction = (numer + "/" + denom);
            return sFraction;
        }

        /// <summary>
        /// Adds the specified fraction to the current fraction.
        /// </summary>
        /// <param name="f">The fraction to add.</param>
        /// <returns>The result of the addition of both fractions.</returns>
        public Fraction add(Fraction f)
        {
            int newNumer = numer * f.denom + f.numer * denom;
            int newDenom = denom * f.denom;
            Fraction result = new Fraction(newNumer, newDenom);
            return result;
        }

        /// <summary>
        /// Adds the specified integer to the current fraction.
        /// </summary>
        /// <param name="i">The integer to add.</param>
        /// <returns>The result of the addition of the fraction and integer.</returns>
        public Fraction add(int i)
        {
            int newNumer = denom * i + numer;
            Fraction result = new Fraction(newNumer, denom);
            return result;
        }

        /// <summary>
        /// Subtracts the specified fraction from the current fraction.
        /// </summary>
        /// <param name="f">The fraction to subtract.</param>
        /// <returns>The result of the subtraction of both fractions.</returns>
        public Fraction subtract(Fraction f)
        {
            int newNumer = numer * f.denom - f.numer * denom;
            int newDenom = denom * f.denom;
            Fraction result = new Fraction(newNumer, newDenom);
            return result;
        }

        /// <summary>
        /// Multiplies the specified fraction by the current fraction.
        /// </summary>
        /// <param name="f">The fraction to multiply.</param>
        /// <returns>The result of the multiplication of both fractions.</returns>
        public Fraction multiply(Fraction f)
        {
            int newNumer = numer * f.numer;
            int newDenom = denom * f.denom;
            Fraction result = new Fraction(newNumer, newDenom);
            return result;
        }

        /// <summary>
        /// Divides the current fraction by the specified fraction.
        /// </summary>
        /// <param name="f">The fraction to divide by.</param>
        /// <returns>The result of the division of both fractions.</returns>
        public Fraction divide(Fraction f)
        {
            int newNumer = numer * f.denom;
            int newDenom = denom * f.numer;
            Fraction result = new Fraction(newNumer, newDenom);
            return result;
        }

        /// <summary>
        /// Compares the current fraction to the specified fraction.
        /// </summary>
        /// <param name="f">The fraction to compare to.</param>
        /// <returns>If they are equal, this method should return 0. If the calling Fraction is less than the Fraction f, the method should return a negative number. If the calling Fraction is greater, the method should return a positive number.</returns>
        public int compareTo(Fraction f)
        {
            double f1 = numer / denom;
            double f2 = f.numer / f.denom;
            if (f1 > f2)
            {
                return 1;
            }
            else if (f2 > f1)
            {
                return -1;
            }
            else // f2 == f1
            {
                return 0;
            }
        }
    }
}