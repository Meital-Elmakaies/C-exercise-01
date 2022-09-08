using System;
using System.Text;

namespace C21_Ex01_1
{
   public class Program
   {
        public static void Main()
        {
            GetInputFromUser();
        }

        public static void GetInputFromUser()
        {
            Console.WriteLine("Please enter 3 binary numbers with 9 digit each");
            string binaryStr;
            StringBuilder binaryStrBuilder = new StringBuilder();

            for (int i = 0; i < 3; i++)
            {
                binaryStr = Console.ReadLine();
                while (!BinaryValidation(binaryStr))
                {
                    Console.WriteLine("Wrong Input... try again enter binary [0/1] number with 9 digit");
                    binaryStr = Console.ReadLine();
                }

                binaryStrBuilder.Append(binaryStr + ",");
            }

            // split the input by ',' delimeter
            string[] binarySubs = binaryStrBuilder.ToString().Split(',');

            // parse each number to Int and check if TryParse works
            if (int.TryParse(binarySubs[0], out int binNum1) && int.TryParse(binarySubs[1], out int binNum2) &&
                int.TryParse(binarySubs[2], out int binNum3))
            {
                int decNum1 = BinaryToDecimal(binNum1);
                int decNum2 = BinaryToDecimal(binNum2);
                int decNum3 = BinaryToDecimal(binNum3);

                DigitsAverage(binaryStrBuilder);
                PowerOfTwo(decNum1, decNum2, decNum3);
                AscendingSeries(decNum1, decNum2, decNum3);
                MinMax(decNum1, decNum2, decNum3);
            }
        }

        // check if the binary number is in the right format
        public static bool BinaryValidation(string i_BinaryStr)
        {
            if (!(i_BinaryStr.Length == 9))
            {
                return false;
            }

            for (int i = 0; i < i_BinaryStr.Length; i++)
            {
                char currentDigit = i_BinaryStr[i];

                if (!(currentDigit.Equals('0') || currentDigit.Equals('1')))
                {
                    return false;
                }
            }

            return true;
        }

        // convert Binary number to Decimal number
        public static int BinaryToDecimal(int i_Num)
        {
            int num = i_Num;
            int decimalNumber = 0, basis = 1, remainder;

            while (i_Num > 0)
            {
                remainder = i_Num % 10;
                decimalNumber += remainder * basis;
                i_Num /= 10;
                basis *= 2;
            }

            string msg = string.Format("The Binary number= {0}\tis in decimal= {1} ", num.ToString("D9"), decimalNumber);
            Console.WriteLine(msg);
            return decimalNumber;
        }

        // find average of ones and zeroes
        public static void DigitsAverage(StringBuilder i_AllInputs)
        {
            int countOfZeroes = 0;
            int countOfOnes = 0;

            for (int i = 0; i < i_AllInputs.Length; i++)
            {
                char digit = i_AllInputs[i];
                if (digit.Equals('1'))
                {
                    countOfOnes++;
                }
                else if (digit.Equals('0'))
                {
                    countOfZeroes++;
                }
            }

            float onesAverage = (float)countOfOnes / 3;
            float zeroesAverage = (float)countOfZeroes / 3;

            string msg = string.Format("The average of zeroes is: {0}\nThe average of ones is: {1} ", zeroesAverage, onesAverage);
            Console.WriteLine(msg);
        }

        public static void PowerOfTwo(int i_Num1, int i_Num2, int i_Num3)
        {
            int countPowerOfTwo = 0;

            // using bitwise operation
            if ((i_Num1 != 0) && ((i_Num1 & (i_Num1 - 1)) == 0))
            {
                countPowerOfTwo++;
            }

            if ((i_Num2 != 0) && ((i_Num2 & (i_Num2 - 1)) == 0))
            {
                countPowerOfTwo++;
            }

            if ((i_Num3 != 0) && ((i_Num3 & (i_Num3 - 1)) == 0))
            {
                countPowerOfTwo++;
            }

            string msg = string.Format("The count of the numbers that are in the power of 2: {0}", countPowerOfTwo);

            Console.WriteLine(msg);
        }

        public static void AscendingSeries(int i_Num1, int i_Num2, int i_Num3)
        {
            int countAscendingSeries = 0;

            if ((i_Num1 % 10) > ((i_Num1 / 10) % 10))
            {
                if (((i_Num1 / 10) % 10) > ((i_Num1 / 100) % 10))
                {
                    countAscendingSeries++;
                }
            }

            if (i_Num2 % 10 > ((i_Num2 / 10) % 10))
            {
                if (((i_Num2 / 10) % 10) > ((i_Num2 / 100) % 10))
                {
                    countAscendingSeries++;
                }
            }

            if ((i_Num3 % 10) > ((i_Num3 / 10) % 10))
            {
                if (((i_Num3 / 10) % 10) > ((i_Num3 / 100) % 10))
                {
                    countAscendingSeries++;
                }
            }

            string msg = string.Format("The count of the numbers that are ascending series is: {0}", countAscendingSeries);
            Console.WriteLine(msg);
        }

        public static void MinMax(int i_Num1, int i_Num2, int i_Num3)
        {
            int max = Math.Max(i_Num1, Math.Max(i_Num2, i_Num3));
            int min = Math.Min(i_Num1, Math.Min(i_Num2, i_Num3));

            string msg = string.Format("The Max number is: {0}\t The Min number is: {1}", max, min);
            Console.WriteLine(msg);
        }
    }
}