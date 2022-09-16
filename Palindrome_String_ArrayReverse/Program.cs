namespace ArrayReverse
{
    class Program
    {
        public static void Main (string[] args)
        {
            string name = "madam";
            
            char[] input = name.ToCharArray(); 
            Array.Reverse(input);
            string reverse = new string (input);

            if (name.Equals(reverse, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("{0} is Palindrome", name);
            }
            else
            {
                Console.WriteLine("{0} is not Palindrome", name);
            }
        }
    }
}