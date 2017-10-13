namespace Kata
{
    public class SumStringsAsNumbers
    {
        public static string sumStrings(string a, string b)
        {
            return GetFinalResult(a, b);
        }

        private static string GetFinalResult(string a, string b)
        {
            var finalResult = "";
            AddCharToFinalResult(a, b, false, finalResult);
            return finalResult;
        }

        private static void AddCharToFinalResult(string a, string b, bool hasParry, string finalResult)
        {
            var firstNum = a[a.Length - 1] - 48;
            var secondNum = b[b.Length - 1] - 48;
            var sum = firstNum + secondNum;

            if (hasParry)
            {
                sum++;
            }

            var nextBitHasParry = false;

            if (sum >= 10)
            {
                nextBitHasParry = true;
                sum -= 10;
            }

            finalResult = sum + finalResult;

            if (a.Length == 1)
            {
                var substringOfB = b.Substring(0, b.Length - 1);
                AddCharToFinalResult(substringOfB, "1", nextBitHasParry, finalResult);
                return;
            }

            if (b.Length == 1)
            {
                var substringOfA = a.Substring(0, a.Length - 1);
                AddCharToFinalResult(substringOfA, "1", nextBitHasParry, finalResult);
                return;
            }

            AddCharToFinalResult();

        }
    }
}