using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Katas
{
    public class PlayingWithPassPhrase
    {
        public String CreateNewPhrase(string phrase, int shift)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char item in phrase)
            {
                if (char.IsLetter(item))
                {
                    sb.Append((char)(item + 1));
                }
                else
                {
                    sb.Append(item);
                }
            }
            return sb.ToString();
        }

    }
}
