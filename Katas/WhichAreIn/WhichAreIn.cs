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
            Order(result);
            return result.ToArray();
        }

        private static void Order(List<String> result)
        {
            bool swap = true;
            while (swap)
            {
                swap = false;
                for (int i = 0; i < result.Count - 1; i++)
                {
                    if (String.Compare(result[i + 1], result[i]) < 0)
                    {
                        swap = true;
                        string temp = result[i];
                        result[i] = result[i + 1];
                        result[i + 1] = temp;
                    }
                }
            }
        }
    }
}
