using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public static class GeneratorStringByMask
    {
        public static List<string> MaskedRandom(string mask, string prefix, int count, SortedDictionary<string, bool> excludList)
        {
            int limit = 3;
            var crowdList = new SortedDictionary<string, int>();
            var result = new List<string>();
            var str = new StringBuilder();
            bool flag = false;

            int i = 0;

            while (i < count)
            {
                GetRandomString(ref str, mask, prefix);
                var id = str.ToString();
                flag = excludList.ContainsKey(str.ToString());

                if (flag && crowdList.ContainsKey(id) && crowdList[id] > limit)
                {
                    i++;
                }
                else if (flag)
                {
                    excludList[id] = false;

                    if (!crowdList.ContainsKey(id))
                    {
                        crowdList.Add(id, 1);
                    }
                    else
                    {
                        crowdList[id]++;
                    }
                }
                else
                {
                    result.Add(str.ToString());
                    excludList.Add(str.ToString(), true);
                    i++;
                }
            }

            return result;
        }

        private static void GetRandomString(ref StringBuilder str, string mask, string prefix)
        {
            str.Clear();
            str.Append(prefix);

            foreach (var c in mask)
            {
                str.Append(GetRandomCharacter(c));
            }
        }

        private static string GetRandomCharacter(char characterType)
        {
            var random = new Random();
            switch (characterType)
            {
                case '*':
                    return random.Next(0, 10).ToString();
                case '#':
                    return ((char)random.Next(65, 91)).ToString();
                case '&':
                    return ((char)random.Next(97, 123)).ToString();
                default:
                    return string.Empty;
            }
        }
    }
}
