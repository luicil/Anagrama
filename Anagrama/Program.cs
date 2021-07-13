using System;
using System.Linq;
using System.Collections.Generic;

namespace isAnagram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a primeira palavra:");
            string p1 = Console.ReadLine();
            Console.WriteLine("Informe a segunda palavra:");
            string p2 = Console.ReadLine();

            if ((String.Concat(p1.OrderBy(c => c))) == (String.Concat(p2.OrderBy(c => c))))
            {
                Console.WriteLine("As palavras " + p1 + " e " + p2 + " são anagramas !");
            }
            else
            {
                Console.WriteLine("A palavras " + p1 + " e " + p2 + " não são anagramas !");
            }
        }
    }
}
