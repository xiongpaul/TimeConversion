/*
 * Name: Paul Xiong
 * Course: PROG2070
 * Assignment#3 - Project C
 * 
 * Purpose: Class that define TimeConversion and associated methods
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PXAssignment3C
{
    public static class TimeConversion
    {
        public static double Convert(double value, string convertFrom, string convertTo)
        {
            if (value <= 0)
            {
                string msg = "Invalid numeric value. " +
                    "Input must be integer greater than 0\n";
                ArgumentException e = new ArgumentException(msg);
                throw e;
            }
            else
            {
                //declare variables used by method
                string fromString, toString;
                double multiplier, result;

                //obtain values and calculate the time conversion
                fromString = ModifyInput(convertFrom);
                toString = ModifyInput(convertTo);
                multiplier = GetMultiplier(fromString, toString);
                result = value * multiplier;

                //return the result of calculations
                return result;
            }
        }

        private static string ModifyInput(string input)
        {
            //variable to store formatted string
            string formattedUnit;
            
            //switch to determine the unit type based on input string
            switch (input)
            {
                default:
                    //create and throw an ArgumentException if no cases match the input
                    ArgumentException e = new ArgumentException("Incorrect time unit");
                    throw e;
                case "seconds":
                case "Seconds":
                case "s":
                case "S":
                    formattedUnit = "seconds";
                    break;
                case "minutes":
                case "Minutes":
                case "m":
                case "M":
                    formattedUnit = "minutes";
                    break;
                case "hours":
                case "Hours":
                case "h":
                case "H":
                    formattedUnit = "hours";
                    break;
                case "days":
                case "Days":
                case "d":
                case "D":
                    formattedUnit = "days";
                    break;
            }
            //return the formatted string
            return formattedUnit;
        }

        private static double GetMultiplier(string convertFrom, string convertTo)
        {
            //declare variables used by method
            double multiplier = 0;
            float dividend = 1;

            //switch to determine multiplier
            switch (convertFrom)
            {
                case "seconds":
                    if (convertTo == "minutes")
                    {
                        multiplier = dividend / 60;
                    }
                    else if (convertTo == "hours")
                    {
                        multiplier = (dividend / 60) / 60;
                    }
                    else if (convertTo == "days")
                    {
                        multiplier = ((dividend / 60) / 60) / 24;
                    }
                    else
                    {
                        multiplier = 1;
                    }
                    break;
                case "minutes":
                    if (convertTo == "seconds")
                    {
                        multiplier = 60;
                    }
                    else if (convertTo == "hours")
                    {
                        multiplier = dividend / 60;
                    }
                    else if (convertTo == "days")
                    {
                        multiplier = (dividend / 60) / 24;
                    }
                    else
                    {
                        multiplier = 1;
                    }
                    break;
                case "hours":
                    if (convertTo == "seconds")
                    {
                        multiplier = 3600;
                    }
                    else if (convertTo == "minutes")
                    {
                        multiplier = 60;
                    }
                    else if (convertTo == "days")
                    {
                        multiplier = dividend / 24;
                    }
                    else
                    {
                        multiplier = 1;
                    }
                    break;
                case "days":
                    if (convertTo == "seconds")
                    {
                        multiplier = 86400;
                    }
                    else if (convertTo == "minutes")
                    {
                        multiplier = 1440;
                    }
                    else if (convertTo == "hours")
                    {
                        multiplier = 24;
                    }
                    else
                    {
                        multiplier = 1;
                    }
                    break;
            }
            //return the multiplier value
            return multiplier;
       }
    }
}
