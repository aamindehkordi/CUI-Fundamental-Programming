using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fractions
{
    class Fraction
    {
        private int numer;
        private int denom;

        /**
         *  takes no parameters, and sets the fields to the default values 0/1.
         */
        public Fraction()
        {
            numer = 0;
            denom = 1;
        }

        /**
         * takes 1 parameter, and puts it over 1, e.g. the parameter 5
         * would result in the fraction 5/1
         */
        public  Fraction(int num)
        {
            numer = num;
            denom = 1;
        }

        /**
         * takes 2 parameters, a numerator and a denominator
         */
        public  Fraction(int num, int den)
        {
            numer = num;
            denom = den;
        }

        // Getters & Setters

        /**
         * getNumer() - returns numerator
         *
         * @return    the numerator
         */
        public int getNumer()
        {
            return numer;

        }

        /**
         * getDenom() - returns denominator
         *
         * @return    the denominator
         */
        public int getDenom()
        {
            return denom;

        }

        /**
         * setNumer(int tmpNumer) - sets desired numerator
         * 
         * @param       desired numerator
         */
        public void setNumer(int tmpNumer)
        {
            numer = tmpNumer;
        }

        /**
         * setDenom(int tmpDenom) - sets desired denominator
         * 
         * @param       desired denominator
         */
        public void setDenom(int tmpDenom)
        {
            denom = tmpDenom;
        }

        /**
         * setValue(int numer) - sets desired fraction
         * 
         * @param       desired numerator & denominator
         */
        public void setValue(int tmpNumer, int tmpDenom)
        {
            numer = tmpNumer;
            denom = tmpDenom;
        }

        /**
         * setValue(Fraction f) - sets desired fraction
         * 
         * @param       desired Fraction
         */
        public void setValue(Fraction f)
        {
            numer = f.numer;
            denom = f.denom;
        }

        /**
         * toDouble() -  converts the Fraction to its real number equivalent
         * 
         * @return      Real number Equielant of Fraction
         */
        public double toDouble()
        {
            double dNumer = numer;
            double dDenom = denom;
            return dNumer / dDenom;
        }

        /**
         * toString() -  converts the Fraction to a String, in the format: 
         * Numerator/Denominator
         * 
         * @return      Fraction as a String
         */
        public String toString()
        {
            String sFraction = (numer + "/" + denom);
            return sFraction;
        }

        /**
         * add(Fraction f) – add the Fraction f to the current (calling) Fraction. This
         * should not modify the value of f or the current Fraction. It returns the new value.
         * 
         * @return      The result of the addition of both fractions.
         * @param       Fraction you want to convert into a String.     
         */
        public Fraction add(Fraction f)
        {
            int newNumer = numer * f.denom + f.numer * denom;
            int newDenom = denom * f.denom;
            Fraction result = new Fraction(newNumer, newDenom);
            return result;
        }

        /**
         * add(int i) – add the integer i to the current (calling) Fraction. This should
         * not modify the value of the current Fraction.
         *
         * @return      The result of the addition of the fraction and integer.
         * @param       Fraction you want to convert into a String.
         */
        public Fraction add(int i)
        {
            int newNumer = denom * i + numer;
            Fraction result = new Fraction(newNumer, denom);
            return result;
        }

        /**
         * subtract(Fraction f) – subtract the Fraction f from the current (calling)
         * Fraction. This should not modify the value of f or the current Fraction.
         * add(int i) – add the integer i to the current (calling) Fraction. This should
         * not modify the value of the current Fraction.
         * @return      The result of the subtraction of both fractions.
         * @param       Fraction you want to convert into a String.
         */
        public Fraction subtract(Fraction f)
        {
            int newNumer = numer * f.denom - f.numer * denom;
            int newDenom = denom * f.denom;
            Fraction result = new Fraction(newNumer, newDenom);
            return result;
        }

        /**
         *  multiply(Fraction f) – multiply the Fraction f by the current (calling)
         * Fraction. This should not modify the value of f or the current Fraction.
         *
         * @return      The result of the multiplication of both fractions.
         * @param       Fraction you want to convert into a String.
         */
        public Fraction multiply(Fraction f)
        {
            int newNumer = numer * f.numer;
            int newDenom = denom * f.denom;
            Fraction result = new Fraction(newNumer, newDenom);
            return result;
        }

        /**
         *  divide(Fraction f) – divide the current (calling) Fraction by the Fraction f
         * This should not modify the value of f or the current Fraction.
         *
         * @return      The result of the division of both fractions.
         * @param       Second Fraction.
         */
        public Fraction divide(Fraction f)
        {
            int newNumer = numer * f.denom;
            int newDenom = denom * f.numer;
            Fraction result = new Fraction(newNumer, newDenom);
            return result;
        }

        /**
         * compareTo(Fraction f) - tells you which of two Fractions, the calling Fraction or
         * f, is greater than the other, or are they equal.
         *
         * @return If they are equal, this method should
         * return 0. If the calling Fraction is less than the Fraction f, the method should
         * return a negative number. If the calling Fraction is greater, the method should
         * return a positive number.
         * @param       Second Fraction.
         */
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
