using System;

namespace Palidrome
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (string arg in args)
            {
                Console.WriteLine($"{arg}");
                IsPalidrome(arg);
            }
        }

        private bool IsPalidrome(string word)
        {
            if (word == null)
            {
                word = word ?? throw new ArgumentNullException("Test");
            }

            return false;
        }

    }
}
