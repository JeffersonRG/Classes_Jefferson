using System;

namespace Classes_Jefferson
{
    class Program
    {
        static void Main(string[] args)
        {
            //links the Greetings.cs
            Greetings greetings = new Greetings();
            //Welcomes the user
            greetings.Welcome();

            //Asked to use it for the name and assigns it to userName
            Console.WriteLine("what is your name squire?");
            String userName = Console.ReadLine();

            //Grease to user with what name they inputted
            greetings.Hello(userName);
        }
    }
}
