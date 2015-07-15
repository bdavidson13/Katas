using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Katas
{
    public class WhichAreIn
    {
        public string[] GetLexOrderedArray(string[] p1, string[] p2)
        {
            List<String> result = new List<string>();
            foreach (var item in p1)
            {
                foreach (var comparer in p2)
                {
                    if (comparer.IndexOf(item) > -1 && result.Contains(item) == false ) result.Add(item);
                }
            }
            return result.ToArray();
        }
    }
}
