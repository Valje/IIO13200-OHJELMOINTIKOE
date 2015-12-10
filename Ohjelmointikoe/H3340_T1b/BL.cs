using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace H3340_T1b
{
    public struct Result {
        public Dictionary<string, int> resultCount;
        public int goodChars;
        public int amount;
        public List<string> listOfKeys;
    }

    public class BL
    {
        public Result getLetterCounts(string input)
        {
            Dictionary<string, int> counts = new Dictionary<string, int>();
            string source = input.ToLower();
            int goodChars = 0;
            Regex regex = new Regex(@"^[a-ä]$");


            foreach (char c in source)
            {
                Match match = regex.Match(c.ToString());

                if (counts.ContainsKey(c.ToString()) && match.Success)
                {
                    counts[c.ToString()] = counts[c.ToString()] + 1;
                    goodChars++;
                }
                else if (match.Success)
                {
                    counts.Add(c.ToString(), 1);
                    goodChars++;
                }
            }

            var list = counts.Keys.ToList();
            list.Sort();

            Result results;
            results.resultCount = counts;
            results.goodChars = goodChars;
            results.amount = list.Count();
            results.listOfKeys = list;

            return results;
        }
    }
}
