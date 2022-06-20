using System;

namespace vn_mode_csharp_dz26
{
    class Program
    {
        static void Main(string[] args)
        {
            string fishString = "Приветствую вас в моём демо коде.";
            string[] tempArray = fishString.Split(' ');

            foreach (var item in tempArray)
            {
                Console.WriteLine(item);
            }
        }
    }
}
