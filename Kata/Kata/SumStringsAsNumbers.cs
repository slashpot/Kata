namespace Kata
{
    public class SumStringsAsNumbers
    {
        private string _finalResult = "";
        private bool _hasCarry = false;

        public string sumStrings(string a, string b)
        {
            AddCharToFinalResult(a, b);
            return _finalResult;
        }

        private void AddCharToFinalResult(string a, string b)
        {
            var firstNum = a[a.Length - 1] - 48;
            var secondNum = b[b.Length - 1] - 48;

            var sum = firstNum + secondNum;
            if (_hasCarry)
            {
                sum++;
                _hasCarry = false;
            }
            if (sum >= 10)
            {
                _hasCarry = true;
                sum -= 10;
            }

            _finalResult = sum + _finalResult;

            var substringOfA = a.Substring(0, a.Length - 1);
            var substringOfB = b.Substring(0, b.Length - 1);

            if (substringOfA.Equals(""))
            {
                if (_hasCarry)
                    AddCharToFinalResult(substringOfB, "1");
                _finalResult = substringOfB + _finalResult;
                return;
            }

            if (substringOfB.Equals(""))
            {
                if (_hasCarry)
                    AddCharToFinalResult(substringOfA, "1");
                _finalResult = substringOfA + _finalResult;
                return;
            }

            AddCharToFinalResult(substringOfA, substringOfB);
        }
    }
}