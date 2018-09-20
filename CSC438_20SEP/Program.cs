using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC438_20SEP
{
    class Program
    {
        static void Main(string[] args)
        {
            // Training data:
            double T_kilo = 100;
            double T_mile = 62.137;

            // What we're looking for:
            double kilo = 100;
            double mile = 62.137;
            double guessX = 0.5;

            double error = 12.137;

            Console.WriteLine("> K = {0}; M = {1}; errror = {2} with {3};", kilo, mile, error, guessX);
        }
    }
}
