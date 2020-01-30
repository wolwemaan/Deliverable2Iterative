//
// Author: Ettienne Voges
// Program Week 3 Iteration program
//
//
using System;

namespace Deliverable2Iterative
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Ask the user to enter an integer value between 1 and 100.
            Console.WriteLine("Enter an integer value between 1 and 100:");

            // Read the grade from standard input
            int count = 0;

            try
            {

                count = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                // Extract information from this exception, and exit
                if (e.Source != null)
                    Console.WriteLine("Exception source: {0}", e.Source);
                Environment.Exit(1);
            }

            // Exit with 1 failure exit code if the user ignore the bracket of accepted integers requested
            if (count < 1 || count > 100)
            {
                Console.WriteLine("Require an integer value between 1 and 100.. Exiting.");
                Environment.Exit(1);
            }
            
            // Using a for loop, display a  message showing the number of times the user has entered 
            // for the integer value: 
            // "You have entered #. This is the current integer value in the loop: #

            for (int i = 1; i <= count; i++)
            {
                Console.WriteLine("You have entered {0}. This is the current integer value in the loop: {1}", count , i);
            }

            // Read bogus input to give the user a change to see the output 
            // Console.ReadLine();

            // Exit with 0 success exit code
            Environment.Exit(0);
        }
    }
}
