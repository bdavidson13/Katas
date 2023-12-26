using Katas.Standard.EasyMathematicalCallback;

namespace Katas.Nunit.Test
{
    public class EasyMathematicalCallbackTests
    {
        [Test]
        public void GivenAnArrayOfIntegersAndACallbackThatDoesNothingProcessArrayReturnsSameValuesThatWherePassedIn()
        {
            int[] input = { 1, 2, 3 };
            int[] expectedOutput = input;

            var result = EasyMathematicalCallback.ProcessArray(input, (v) => { return v; });
            for (int i = 0; i < expectedOutput.Length; i++)
            {
                Assert.AreEqual(expectedOutput[i], result[i]);
            }
        }

        [Test]
        public void GivenAnArrayOfIntsAndACallbackThatAddsOneToEachNumberProcessArraryReturnsArrayWithOneAddedToEachNumber()
        {

            int[] input = { 1, 2, 3 };
            int[] expectedOutput = { 2, 3, 4 };

            var result = EasyMathematicalCallback.ProcessArray(input, (v) => { return v + 1; });
            for (int i = 0; i < expectedOutput.Length; i++)
            {
                Assert.AreEqual(expectedOutput[i], result[i]);
            }
        }
        private static IEnumerable<TestCaseData> testCases
        {
            get
            {
                yield return new TestCaseData(new int[] { 4, 8, 2, 7, 5 }, (Func<int, int>)((v) => v * 2)).Returns(new int[] { 8, 16, 4, 14, 10 });
                yield return new TestCaseData(new int[] { 7, 8, 9, 1, 2 }, (Func<int, int>)((v) => v + 5)).Returns(new int[] { 12, 13, 14, 6, 7 });
                yield return new TestCaseData(new int[] { -1, 1, 2, 3, 4, 5 }, (Func<int, int>)((v) => v * v * v)).Returns(new int[] { -1, 1, 8, 27, 64, 125 });
                yield return new TestCaseData(new int[] { }, (Func<int, int>)((v) => v + 1)).Returns(new int[] { });
            }
        }
        [Test, TestCaseSource("testCases")]
        public int[] Test(int[] arr, Func<int, int> callback) => EasyMathematicalCallback.ProcessArray(arr, callback);
    }
}
