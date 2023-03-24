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



            var excludeList = new SortedDictionary<string, bool>() { { "ArGS2RYN54elv", true }, { "ThJG6JMH96tkn", true }, { "ThJG6YJM96tkn", true }, { "ErJG6YJM96tkn", true } };
            //Console.WriteLine(string.Join("\n", excludeList));

            var res = GeneratorStringByMask.MaskedRandom(mask, "", 500000, excludeList);
            Console.WriteLine(res.Count);
            Console.WriteLine(DateTime.Now - date);
        }

        
    }
}
