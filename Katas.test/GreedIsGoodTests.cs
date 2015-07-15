using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Katas.GreedUsGood;

namespace Kata
{
    [TestClass]
    public class GreedIsGoodTests
    {
        private int[] dice { get; set; }
        private DiceGame game { get; set; }
        [TestInitialize]
        public void setup()
        {
            game = new DiceGame();
        }

        [TestMethod]
        public void GetScore_PassedArrayWithASingle1_ScoreShouldBe100()
        {
            setDice(new int[] { 1, 2, 3, 4, 6 });
            int score = game.GetScore(dice);
            Assert.AreEqual(score, 100, String.Format("score should be 100 but is {0}", score));
        }
        [TestMethod]
        public void GetScore_PassedArrayWithThreeOnes_scoreShouldBe1000()
        {
            setDice(new int[] { 1, 3, 1, 4, 1 });
            int score = game.GetScore(dice);
            Assert.AreEqual(score, 1000, String.Format("score should be 1000 but is {0}", score));
        }
        [TestMethod]
        public void GetScore_PassedArrayWithALLOnes_scoreShouldBe1200()
        {
            setDice(new int[] { 1, 1, 1, 1, 1 });
            int score = game.GetScore(dice);
            Assert.AreEqual(score, 1200, String.Format("score should be 1200 but is {0}", score));
        }
        [TestMethod]
        public void GetScore_PassedArrayWithASingle5_ScoreShouldBe50()
        {
            setDice(new int[] { 5, 2, 3, 4, 6 });
            int score = game.GetScore(dice);
            Assert.AreEqual(score, 50, String.Format("score should be 50 but is {0}", score));
        }
        [TestMethod]
        public void GetScore_PassedArrayWithThree5s_scoreShouldBe500()
        {
            setDice(new int[] { 5, 3, 5, 4, 5 });
            int score = game.GetScore(dice);
            Assert.AreEqual(score, 500, String.Format("score should be 500 but is {0}", score));
        }
        [TestMethod]
        public void GetScore_PassedArrayWithALLFives_scoreShouldBe600()
        {
            setDice(new int[] { 5, 5, 5, 5, 5 });
            int score = game.GetScore(dice);
            Assert.AreEqual(score, 600, String.Format("score should be 600 but is {0}", score));
        }
        [TestMethod]
        public void GetScore_PassedArrayWithSingleOneAndSingleFive_scoreShouldBe150()
        {
            setDice(new int[] { 5, 1, 3, 6, 4 });
            int score = game.GetScore(dice);
            Assert.AreEqual(score, 150, String.Format("score should be 150 but is {0}", score));
        }
        [TestMethod]
        public void GetScore_PassedArrayWithThreeTwosAndNoFivesOrOnes_scoreShouldBe200()
        {
            setDice(new int[] { 2, 3, 2, 4, 2 });
            int score = game.GetScore(dice);
            Assert.AreEqual(score, 200, String.Format("score should be 200 but is {0}", score));
        }
        [TestMethod]
        public void GetScore_PassedArrayWithThreeThreesAndNoFivesOrOnes_scoreShouldBe300()
        {
            setDice(new int[] { 2, 3, 3, 4, 3 });
            int score = game.GetScore(dice);
            Assert.AreEqual(score, 300, String.Format("score should be 300 but is {0}", score));
        }
        [TestMethod]
        public void GetScore_PassedArrayWithThreeFoursAndNoFivesOrOnes_scoreShouldBe400()
        {
            setDice(new int[] { 2, 4, 3, 4, 4 });
            int score = game.GetScore(dice);
            Assert.AreEqual(score, 400, String.Format("score should be 400 but is {0}", score));
        }
        [TestMethod]
        public void GetScore_PassedArrayWithThreeSixsAndNoFivesOrOnes_scoreShouldBe600()
        {
            setDice(new int[] { 6, 4, 6, 4, 6 });
            int score = game.GetScore(dice);
            Assert.AreEqual(score, 600, String.Format("score should be 600 but is {0}", score));
        }
        private void setDice(int[] p_dice ) 
        {
            dice = p_dice;
        }

    }
}
