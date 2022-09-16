namespace ForeachLoop
{
    class Program
    {
        public static void Main(string[] args)
        {
            string name = "Madam";
            string reverse = string.Empty;
            foreach (char c in name)
            {
                reverse = c + reverse;
            }
            if(name.Equals(reverse, StringComparison.OrdinalIgnoreCase))
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