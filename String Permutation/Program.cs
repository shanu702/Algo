using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Permutation("dog");
            Console.Read();
        }

        static void Permutation(string rest, string prefix = "")
        {
            if (string.IsNullOrEmpty(rest)) Console.WriteLine(prefix);

            // Each letter has a chance to be per mutated
            for (int i = 0; i < rest.Length; i++)
            {
                Permutation(rest.Remove(i, 1), prefix + rest[i]);
            }
        }
    }
}
