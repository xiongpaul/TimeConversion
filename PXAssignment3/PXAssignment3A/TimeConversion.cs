/*
 * Name: Paul Xiong
 * Course: PROG2070
 * Assignment#3 - Project A
 * 
 * Purpose: Class that defines TimeConversion and associated methods
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PXAssignment3A
{
    public static class TimeConversion
    {
        public static double Convert(double value, string convertFrom, string convertTo)
        {
            //input validation for value parameter
            if (value <= 0)
            {
                string msg = "Invalid numeric value. " +
                    "Input must be integer greater than 0\n";
                ArgumentException e = new ArgumentException(msg);
                throw e;
            }
            else
            {
                //declare variables
                string fromString, toString;
                double multiplier, result;

                //obtain values and calculate the time conversion
                fromString = ModifyInputStub(convertFrom);
                toString = ModifyInputStub(convertTo);
                multiplier = GetMultiplierStub(fromString, toString);
                result = value * multiplier;

                //return the result of calculations
                return result;
            }
        }

        private static string ModifyInputStub(string input)
        {
            return "minutes";
        }

        private static double GetMultiplierStub(string convertFrom, string convertTo)
        {
            return 2;
        }
    }
}
