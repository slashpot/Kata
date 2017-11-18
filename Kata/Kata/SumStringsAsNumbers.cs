namespace Kata
{
    public class SumStringsAsNumbers
    {
        private static bool _hasCarry;
        private static string _sum = "";
        private static string _firstInput = "";
        private static string _secondInput = "";

        public static string SumStrings(string firstInput, string secondInput)
        {
            _secondInput = secondInput;
            _firstInput = firstInput;
            Calculate();
            CalculateSumIfInputHasUncheckedDigit();
            return _sum;
        }

        public static void Initialize()
        {
            _hasCarry = false;
            _sum = "";
            _firstInput = "";
            _secondInput = "";
        }

        private static void Calculate()
        {
            while (CheckInputsIsNotFinished())
            {
                CalculateSumFromLastDigit();
            }
        }

        private static void CalculateSumIfInputHasUncheckedDigit()
        {
            InsertDigitsFromRemainInput(ref _firstInput);
            InsertDigitsFromRemainInput(ref _secondInput);
        }

        private static void InsertDigitsFromRemainInput(ref string input)
        {
            if (input.Length != 0)
            {
                _sum = _sum.Insert(0, input);
            }
        }

        private static void CalculateSumFromLastDigit()
        {
            var firstNum = ExtractLastDigitFromInput(ref _firstInput);
            var secondNum = ExtractLastDigitFromInput(ref _secondInput);
            var sumOfDigit = CalculateSumOfDigit(firstNum, secondNum);
            AddDigitToSum(sumOfDigit);
        }

        private static void AddDigitToSum(int sumOfDigit)
        {
            _sum = _sum.Insert(0, sumOfDigit.ToString());
        }

        private static int CalculateSumOfDigit(int firstNum, int secondNum)
        {
            var sumOfDigit = firstNum + secondNum;
            AddCarryIfExist(ref sumOfDigit);
            RecordCarryIfExist(ref sumOfDigit);
            return sumOfDigit;
        }

        private static void RecordCarryIfExist(ref int sumOfDigit)
        {
            if (sumOfDigit > 9)
            {
                _hasCarry = true;
                sumOfDigit -= 10;
                if (_firstInput == "")
                {
                    _firstInput = "1";
                    _hasCarry = false;
                }
                else if (_secondInput == "")
                {
                    _secondInput = "1";
                    _hasCarry = false;
                }
            }
        }

        private static void AddCarryIfExist(ref int sumOfDigit)
        {
            if (_hasCarry)
            {
                sumOfDigit += 1;
                _hasCarry = false;
            }
        }

        private static bool CheckInputsIsNotFinished()
        {
            return _firstInput.Length != 0 && _secondInput.Length != 0;
        }

        private static int ExtractLastDigitFromInput(ref string input)
        {
            var numberOfLastDigit = input[input.Length - 1] - 48;
            input = input.Substring(0, input.Length - 1);
            return numberOfLastDigit;
        }
    }
}