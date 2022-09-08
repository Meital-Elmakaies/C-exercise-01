namespace C21_Ex01_6
{
    using System;

    public class Program
    {
        public static void Main()
        {
            GetInputFromUser();
        }

        public static void GetInputFromUser()
        {
            Console.WriteLine("Please enter a 9 digits positive integer number: ");    
            string numStr = Console.ReadLine();
            while (!InputValidation(numStr))
            {
                Console.WriteLine("Invalid input... try again");
                numStr = Console.ReadLine();
            }

            MaxDigit(numStr);
            DigitsAverage(numStr);
            DivideByThreeDigits(numStr);
            SmallerThanUnitDigit(numStr);
        }

        public static bool InputValidation(string i_Str)
        {
            if (!(i_Str.Length == 9))
            {
                return false;
            }
            
            for (int i = 0; i < i_Str.Length; i++)
            {
                char currentChar = i_Str[i];
                if (!char.IsDigit(currentChar))
                {
                    return false;
                }
                else
                {
                    if (int.TryParse(i_Str, out int num))
                    {
                        if (num < 0)
                        {
                            return false;
                        }
                    }
                }
            }

            return true;
        }

        public static void MaxDigit(string i_NumStr)
        {
            if(int.TryParse(i_NumStr, out int num))
            {
                int max = 0;
                for (int i = 0; i < 9; i++, num /= 10)
                {
                    int digit = num % 10;
                    max = Math.Max(digit, max);
                    num /= 10;
                }

                string msg = string.Format("The max digit is: {0}", max);
                Console.WriteLine(msg);
            }
        }

        public static void DigitsAverage(string i_NumStr)
        {
            if (int.TryParse(i_NumStr, out int num))
            {
                int sumOfDigits = 0;
                for (int i = 0; i < 9; i++, num /= 10)
                {
                    int digit = num % 10;
                    sumOfDigits += digit;
                    num /= 10;
                }

                float average = (float)sumOfDigits / 9;
                string msg = string.Format("The average of the digits is: {0}", average);
                Console.WriteLine(msg);
            }
        }

        public static void DivideByThreeDigits(string i_NumStr)
        {
            if (int.TryParse(i_NumStr, out int num))
            {
                int countDivideByThreeDigits = 0;
                for (int i = 0; i < 9; i++, num /= 10)
                {
                    int digit = num % 10;
                    if(digit % 3 == 0)
                    {
                        countDivideByThreeDigits++;
                    }
                }

                string msg = string.Format("The count of digits that divide by three without remainder is: {0}", countDivideByThreeDigits);
                Console.WriteLine(msg);
            }
        }

        public static void SmallerThanUnitDigit(string i_NumStr)
        {
            if (int.TryParse(i_NumStr, out int num))
            {
                int countSmallThanUnit = 0;
                int unitDigit = num % 10;
                for(int i = 0; i < 9; i++, num /= 10)
                {
                    int currentDigit = num % 10;
                    if (currentDigit < unitDigit )
                    {
                        countSmallThanUnit++;
                    }
                }

                string msg = string.Format("The count of digits that smaller than the unit digit is: {0}", countSmallThanUnit);
                Console.WriteLine(msg);
            }
        }
    }
}
