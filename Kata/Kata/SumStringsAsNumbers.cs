namespace Kata
{
    public class SumStringsAsNumbers
    {
        public string SumStrings(string firstInput, string secondInput)
        {
            var sum = "";
            while (firstInput.Length != 0 && secondInput.Length != 0)
            {
                var firstNum = GetNumberFromChar(firstInput[firstInput.Length - 1]);
                var secondNum = GetNumberFromChar(secondInput[secondInput.Length - 1]);
                sum = sum.Insert(0, (firstNum + secondNum).ToString());
                firstInput = firstInput.Substring(0, firstInput.Length - 1);
                secondInput = secondInput.Substring(0, secondInput.Length - 1);
            }
            if (firstInput.Length != 0)
            {
                sum = sum.Insert(0, firstInput);
            }
            if (secondInput.Length != 0)
            {
                sum = sum.Insert(0, secondInput);
            }
            return sum;
        }

        private static int GetNumberFromChar(char firstChar)
        {
            return firstChar - 48;
        }
    }
}