namespace homework_7
{
    using System;
    using System.Text;

   class Program
    {
        // --- homework-7 ---

        static void Main()
        {
            string input;

            // do-while loop to ensure non-empty input 
            do
            {
                Console.WriteLine("Enter your text (cannot be empty):");
                input = Console.ReadLine();
            }
            while (string.IsNullOrWhiteSpace(input));

            string result = SentenceCapitalaizer(input);

            Console.WriteLine("\nResult:");
            Console.WriteLine(result);
        }

        static string SentenceCapitalaizer(string text)
        {
            StringBuilder result = new StringBuilder(text.Length);
            bool capitalizer = true;

            foreach (char c in text)
            {
                if (capitalizer && char.IsLetter(c))
                {
                    result.Append(char.ToUpper(c));
                    capitalizer = false;
                }
                else
                {
                    result.Append(c);
                }

                if (c == '.' || c == '!' || c == '?')
                    capitalizer = true;
            }

            return result.ToString();
        }
    }

}
