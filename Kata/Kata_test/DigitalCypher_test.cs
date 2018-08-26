using Codewars;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace Kata_test
{
    [TestFixture()]
    public class DigitalCypher_test
    {
        [TestCase("scout", 1939, ExpectedResult = new[] { 20, 12, 18, 30, 21 })]
        [TestCase("masterpiece", 1939, ExpectedResult = new int[] { 14, 10, 22, 29, 6, 27, 19, 18, 6, 12, 8 })]
        public int[] TestMethod1(string str,int key)
        {
            return DigitalCypher.Encode(str,key);
        }
    }
}