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
            return phrase;
        }

        public bool IsAlphabetic(char asciiCode)
        {
            return (asciiCode >= 65 && asciiCode <= 90) || (asciiCode >= 97 && asciiCode <= 122);
        }
    }
}
