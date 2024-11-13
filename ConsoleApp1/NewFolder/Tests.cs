using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LexicographicStringTests
{
    [TestClass]
    public class LexicographicallyMinimalStringTests
    {
        [TestMethod]
        public void TestExampleCase()
        {
            int K = 2;
            string s = "aababac";
            string expected = "aaaabbc";
            string result = Program.GetLexicographicallyMinimalString(s, K);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestZeroShift()
        {
            int K = 0;
            string s = "abcde";
            string expected = "abcde";
            string result = Program.GetLexicographicallyMinimalString(s, K);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestAllSameCharacters()
        {
            int K = 1;
            string s = "aaaaa";
            string expected = "aaaaa";
            string result = Program.GetLexicographicallyMinimalString(s, K);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMaxShift()
        {
            int K = 5;
            string s = "bacdef";
            string expected = "abcdef";
            string result = Program.GetLexicographicallyMinimalString(s, K);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestLargeInput()
        {
            int K = 100;
            string s = new string('z', 100000);
            string expected = new string('z', 100000);
            string result = Program.GetLexicographicallyMinimalString(s, K);
            Assert.AreEqual(expected, result);
        }
    }
}
