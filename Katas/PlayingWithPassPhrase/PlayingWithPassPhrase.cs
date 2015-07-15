﻿using System;
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
                if (item == 'z')
                {
                    sb.Append('a');
                    continue;
                }
                if (char.IsNumber(item))
                {
                    sb.Append((9 - int.Parse(item.ToString())));
                    continue;
                }
                if (char.IsLetter(item))
                {
                    sb.Append((char)(item + shift));
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
