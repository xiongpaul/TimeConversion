/*
 * Name: Paul Xiong
 * Course: PROG2070
 * Assignment#3 - Project A
 * 
 * Purpose: Console Application that works with TimeConversion class
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PXAssignment3A
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare variable to force program loop
            bool programLoop = true;

            while (programLoop)
            {
                //input menu
                Console.WriteLine("Please select an operation:");
                Console.WriteLine("1. Do a time conversion");
                Console.WriteLine("2. Exit");
                string input = Console.ReadLine();

                //switch to select operation
                switch (input)
                {
                    default:
                        Console.WriteLine("Invalid selection");
                        break;
                    case "1":
                        BeginConversion();
                        break;
                    case "2":
                        //turn off the program loop
                        programLoop = false;
                        break;
                }
            }
        }

        static void BeginConversion()
        {
            //declare variables
            string msg;
            double value, result;

            //obtain user input
            Console.WriteLine("Please enter a numeric value");
            double.TryParse(Console.ReadLine(), out value);
            Console.WriteLine("Please choose the unit of time to convert from");
            string convertFrom = Console.ReadLine();
            Console.WriteLine("Please choose the unit of time to convert to");
            string convertTo = Console.ReadLine();

            //attempt conversion with all_
            //values provided by user
            try
            {
                result = TimeConversion.Convert(value, convertFrom, convertTo);
                msg = value + " " + convertFrom + " to " + convertTo + " is " + result.ToString("n8") + "\n";
            }
            //handle thrown exception
            catch (ArgumentException e)
            {
                msg = e.Message;
            }
            Console.WriteLine(msg);
        }
    }
}
