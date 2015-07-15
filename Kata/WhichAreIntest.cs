using System;
using System.Collections.Generic;
using System.Linq;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Katas;

namespace Kata
{
 /*
Given two arrays of strings a1 and a2 return a sorted array in lexicographical order and without duplicates of the 
strings of a1 which are substrings of strings of a2.

Example: a1 = ["arp", "live", "strong"]

a2 = ["lively", "alive", "harp", "sharp", "armstrong"]

returns ["arp", "live", "strong"]

a1 = ["tarp", "mice", "bull"]

a2 = ["lively", "alive", "harp", "sharp", "armstrong"]

returns []

Note: Arrays are written in "general" notation. See "Your Test Cases" for examples in your language.
  */ 
    [TestClass]
    public class WhichAreInTest
    {
        private WhichAreIn wai { get; set; } 
        [TestInitialize]
        public void setup()
        {
            wai = new WhichAreIn();
        }
        [TestMethod]
        public void GetLexOrderedArray_GivenOneMatch_ReturnsAnArrayWithOneElement()
        {
            string [] result = wai.GetLexOrderedArray(new String[]{"arp", "mice", "bull"},new String[]{"lively", "alive", "harp",  "armstrong"});
            Assert.AreEqual(1, result.Length);
        }
        [TestMethod]
        public void GetLexOrderedArray_GivenOneMatch_ReturnsMatch()
        {
            string[] result = wai.GetLexOrderedArray(new String[] { "arp", "mice", "bull" }, new String[] { "lively", "alive", "harp", "sharp", "armstrong" });
            Assert.AreEqual(result[0], "arp");
        }
        [TestMethod]
        public void GetLexOrderedArray_GivenOneMatch_ReturnsMatchWithNoDuplicates()
        {
            string[] result = wai.GetLexOrderedArray(new String[] { "arp", "mice", "bull" }, new String[] { "lively", "alive", "harp", "sharp", "armstrong" });
            Assert.AreEqual(1, result.Length);
        }
        [TestMethod]
        public void GetLexOrderedArray_GivenMatches_ReturnsMatchesInOrder()
        {
            string[] result = wai.GetLexOrderedArray(new String[] { "live", "strong", "arp" }, new String[] { "lively", "alive", "harp", "sharp", "armstrong" });
            Assert.IsTrue(result[0] == "arp"&&result[1]=="live"&&result[2]=="strong",
                String.Format("Expect : arp,live,strong. Actual : {0},{1},{2}",result[0],result[1],result[2]));
        }
        [TestMethod]
        public void GetLexOrderedArray_GivenNoMatches_ReturnsEmptyArray()
        {
            string[] result = wai.GetLexOrderedArray(new String[] { "tarp", "mice", "bull" }, new String[] { "lively", "alive", "harp", "armstrong" });
            Assert.AreEqual(0, result.Length);
        }
    }
}
