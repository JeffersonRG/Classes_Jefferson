using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_Jefferson
{
    class Greetings
    {
        /// <summary>
        /// Prints a greeting to the user
        /// </summary>
        public void Welcome()
        {
            Console.WriteLine("Hello Traveler, welcome!");
        }

        /// <summary>
        /// Print out a welcome message with the users name
        /// </summary>
        /// <param name="name">user's name</param>
        public void Hello(string name)
        {
            Console.WriteLine($"{name}, thank you for joining us today!");
        }
    }
}
