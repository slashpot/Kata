namespace Kata
{
    public class SumStringsAsNumbers
    {
        public string SumStrings(string firstInput, string secondInput)
        {
            var sum = "";
            for (int i = firstInput.Length - 1; i >= 0; i--)
            {
                var firstNum = GetNumberFromChar(firstInput[i]);
                var secondNum = GetNumberFromChar(secondInput[i]);
                sum = sum.Insert(0, (firstNum + secondNum).ToString());
            }
            return sum;
        }

        private static int GetNumberFromChar(char firstChar)
        {
            return firstChar - 48;
        }
    }
}