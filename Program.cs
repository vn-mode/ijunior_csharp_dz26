using System;

namespace vn_mode_csharp_dz26
{
    class Program
    {
        static void Main(string[] args)
        {
            string fishString = "Приветствую вас в моём демо коде.";
            string[] arrayWords = fishString.Split(' ');

            foreach (string item in arrayWords)
            {
                Console.WriteLine(item);
            }
        }
    }
}
