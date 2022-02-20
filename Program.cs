using System;
namespace StringEX
{
    class Xyz
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a string");
            string str = Console.ReadLine();
            string reverse = "";

            int length = str.Length - 1;
            while (length >= 0)
            {
                reverse = reverse + str[length];
                length--;
            }
            if (str == reverse)
                Console.WriteLine("palindrome");
            else
                Console.WriteLine("not a palindrome");


            Console.ReadLine();
        }
    }
}