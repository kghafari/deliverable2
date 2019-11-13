using System;
using System.Text;

namespace Deliverable2
{
    class Program
    {
        static void Main(string[] args)
        {
            //prompt user
            Console.WriteLine("Please enter the message you would like to encrypt: ");

            //setup variables
            string input = Console.ReadLine().ToUpper();
            StringBuilder message = new StringBuilder();
            int checksum = 0;

            //main loop
            foreach (char c in input)
            {
                //for each iteration, add c to the total of checksum. Implicit conversion from char to unicode(int).
                checksum += c;

                //for each iteration, subtract 64, append it to the end of the string 'message' and add a "-".
                int i = c - 64;
                message.Append($"{i}");
                message.Append("-");
            }
            //output message and checksum
            Console.WriteLine($"\nYour encoded message is {message}");
            Console.WriteLine($"Message checksum is {checksum}");
            Console.ReadLine();
        }
    }
}