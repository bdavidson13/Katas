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
            phrase = phrase.ToLower();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < phrase.Length;i++ )
            {
                if (phrase[i] == 'z')
                {
                    sb.Append((i+1)%2 == 0?'a':'A');
                    continue;
                }
                if (char.IsNumber(phrase[i]))
                {
                    sb.Append((9 - int.Parse(phrase[i].ToString())));
                    continue;
                }
                if (char.IsLetter(phrase[i]))
                {
                    char newChar = (char)(phrase[i] + shift) ;
                    sb.Append((i + 1) % 2 == 0 ? newChar.ToString() : newChar.ToString().ToUpper());
                }
                else
                {
                    sb.Append(phrase[i]);
                }
            }
            return sb.ToString();
        }

    }
}
