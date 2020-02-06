using System;

namespace Methods
{


    class Program
    {
        static void Main(string[] args)
        {

            Theresult(); // I am calling the method that I created right here
            Console.ReadKey(true); // it waits for a key to be pushed

        }

        public static void Theresult() // I have created my own method here
        {
            Console.Write("Hello, please enter your first and last name, separated by a space." + "\n" + "\n"); // prompts the user
            string input = Console.ReadLine();
            // input is recorded

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Invalid input. Push a key to exit.");
            }
            else
            {
                Console.WriteLine("\n" + "Hello " + input +  "!" + "\n" + "\n" + "Press any key to exit now."); // output
            }
        }

    } // end of program here.
}