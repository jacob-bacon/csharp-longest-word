using System;


namespace FindLongestSubstring
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Type a string, any string!");
            var myString = Console.ReadLine();
            char delimiter = ' ';
            string[] substrings = myString.Split(delimiter);
            var longestSubstring = "";

            foreach (var substring in substrings)
            {
                if (substring.Length > longestSubstring.Length)
                {
                    longestSubstring = substring;
                }
                
            }

            Console.WriteLine("The longest substring is \"{0}\", which is {1} characters long.", longestSubstring, longestSubstring.Length);
        }
    }
}
