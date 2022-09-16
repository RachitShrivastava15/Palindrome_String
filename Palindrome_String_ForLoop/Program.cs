using System;

namespace ForLoop
{
    class Program
    {
        public static void Main(string[] args)
        {
            string name = "Madam";
            string reverse = string.Empty;

            for(int i = name.Length - 1 ; i >= 0 ; i--)
            {
                reverse += name[i];
            }
            if(name.ToLower() == reverse.ToLower())
            {
                Console.WriteLine("{0} is palindrome", name);
            }
            else
            {
                Console.WriteLine("{0} is not palindrome", name);
            }
           
        }
    }
}