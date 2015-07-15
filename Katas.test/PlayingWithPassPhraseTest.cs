using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Katas;

namespace Kata
{
    [TestClass]
    public class PlayingWithPassPhraseTest
    {
    /*
     Everyone knows passphrases. One can choose passphrases from poems, songs, movies names and so on but frequently they can be guessed due to common 
     cultural references. You can get your passphrases stronger by different means. One is the following:
     choose a text in capital letters including or not digits and non alphabetic characters,
        1. shift each letter by a given number but the transformed letter must be a letter (circular shift),
        2. replace each digit by its complement to 9,
        3. keep such as non alphabetic and non digit characters,
        4. downcase each letter in odd position, upcase each letter in even position (the first character is in position 0),
        5. reverse the whole result.
     Example:

            your text: "BORN IN 2015!", shift 1
            1 + 2 + 3 -> "CPSO JO 7984!"
            4 "CpSo jO 7984!"
            5 "!4897 Oj oSpC"

     With longer passphrases it's better to have a small and easy program. Would you write it?
     https://en.wikipedia.org/wiki/Passphrase
        */
        private PlayingWithPassPhrase passPhrase { get; set; }
        private String phrase { get; set; }
        [TestInitialize]
        public void Setup()
        {
            passPhrase = new PlayingWithPassPhrase();
            phrase = "BORN IN 2015!";
        }

        [TestMethod]
        public void CreateNewPhrase_PassInStringAndInt_ReturnsAString()
        {
            int shift = 1;
            var result = passPhrase.CreateNewPhrase(phrase, shift);
            Assert.IsTrue(!String.IsNullOrEmpty(result));
        }
        [TestMethod]
        public void CreateNewPhrase_PassInStringAndAShiftOfOne_ShiftsAllLettersby1()
        {
            int shift = 1;
            var result = passPhrase.CreateNewPhrase(phrase, shift);
            Assert.AreEqual("CPSO JO 2015!", result);
        }
        [TestMethod]
        public void IsAlphabetic_GivenALowerCaseAlphbetChar_ReturnsTrue()
        {
            var result = passPhrase.IsAlphabetic('a');
            Assert.IsTrue(result);
        }
        public void IsAlphabetic_GivenAnUpperCaseAlphbetChar_ReturnsTrue()
        {
            var result = passPhrase.IsAlphabetic('X');
            Assert.IsTrue(result);
        }
        public void IsAlphabetic_GivenANumberChar_ReturnsFalse()
        {
            var result = passPhrase.IsAlphabetic('6');
            Assert.IsFalse(result);
        }
        public void IsAlphabetic_GivenANonAlphaNumericChar_ReturnsFalse()
        {
            var result = passPhrase.IsAlphabetic('%');
            Assert.IsFalse(result);
        }
        public void IsAlphabetic_GivenASpaceChar_ReturnsFalse()
        {
            var result = passPhrase.IsAlphabetic(' ');
            Assert.IsFalse(result);
        }
    }
}
