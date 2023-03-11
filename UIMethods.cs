using System;
namespace new_flooring
{
    public class UIMethods
    {
        /// <summary>
        /// Prints a welcome messages to the user and describes the program
        /// </summary>
        public static void IntroMessage()
        {
            Console.WriteLine("Hello User, this program can calculate the cost of flooring work when given a few inputs.");
            Console.WriteLine("It can only be used with the following shapes: triangle and rectangle (square/ parallelogram).");
        }

        /// <summary>
        /// Takes input checks if its supported by program and returns corners value
        /// </summary>
        /// <returns>User input as integer</returns>
        public static int AskForCorners()
        {
            int corners;
            Console.WriteLine("Please enter a valid number of corners in the room: ");
            int.TryParse(Console.ReadLine(), out corners);

            return corners;
        }
    }
}

