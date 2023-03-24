using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var date = DateTime.Now;
            Console.WriteLine(date);

            var mask = "#&##*###**&&&";

            var excludeList = new SortedSet<string>() { { "ArGS2RYN54elv" }, { "ThJG6JMH96tkn" }, { "ThJG6YJM96tkn" }, { "ErJG6YJM96tkn" } };

            var res = GeneratorStringByMask.MaskedRandom(mask, "", 500000, excludeList);
            Console.WriteLine(res.Count);
            Console.WriteLine(DateTime.Now - date);
        }

        
    }
}
