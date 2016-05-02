using System;
using System.Linq;

namespace Rovarspraket
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string output = EncodeRovarspraket(Console.ReadLine());
                Console.WriteLine(output);

                output = DecodeRovarspraket(output);
                Console.WriteLine(output);
            }
        }

        private static string EncodeRovarspraket(string input)
        {
            string vowels = "AEIOUYÅÄÖ",
                   output = string.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsLetter(input[i]) && !vowels.Contains(char.ToUpper(input[i])))
                {
                    string token = input[i] + "o" + char.ToLower(input[i]);
                    output += token;
                }
                else
                {
                    output += input[i];
                }
            }
            return output;
        }

        private static string DecodeRovarspraket(string input)
        {
            string vowels = "AEIOUYÅÄÖ",
                   output = string.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                output += input[i];

                if (char.IsLetter(input[i]) && !vowels.Contains(char.ToUpper(input[i])))
                {
                    i += 2;
                }
            }
            return output;
        }
    }
}
