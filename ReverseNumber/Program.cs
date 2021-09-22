using System;

namespace ReverseNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //1234 = 4321

            //declare necessary variables
            int number, reverse = 0, remainder, temp;

            //print message to show the user
            Console.Write("Please Enter a number: ");

            //get the input from user
            number = int.Parse(Console.ReadLine());

            //store it in a temporary variable
            temp = number;

            //continue the programe until number not equal to 0
            while (number != 0)
            {
                remainder = number % 10;
                reverse = (reverse * 10) + remainder;
                number = number / 10;

            }
            //print the message to show the user
            Console.Write("Reverse number of "+temp + " is " + reverse);
        }
    }
}
