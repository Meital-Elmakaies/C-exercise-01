namespace C21_Ex01_4
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
            Console.WriteLine("Please enter a 8 characters [a-zA-Z] or 8 digits [0-9]");
            string strInput = Console.ReadLine();
            while (!InputValidation(strInput))
            {
                Console.WriteLine("Invalid input... try again");
                strInput = Console.ReadLine();
            }

            Console.WriteLine("Is Palindrome? --> " + IsPalindrom(strInput));
            if (IsNumber(strInput))
            {
                Console.WriteLine("Is Divide by Four? --> " + IsDivideByFour(strInput));
            }

            if (IsLetters(strInput))
            {
                Console.WriteLine("The count of the upper letters is --> " + CountUpperLetters(strInput));
            }
        }

        public static bool InputValidation(string i_Str)
        {
            if (!(i_Str.Length == 8))
            {
                return false;
            }

            bool letterFlag = false;
            bool digitFlag = false;

            char firstChar = i_Str[0];
            if (char.IsDigit(firstChar))
            {
                digitFlag = true;
            }

            // the first char is letter
            if (char.IsLetter(firstChar)) 
            {
                letterFlag = true;
            }

            if (!char.IsLetterOrDigit(firstChar))
            {
                return false;
            }

            for (int i = 1; i < i_Str.Length; i++)
            {
                char currentChar = i_Str[i];
                if (!char.IsLetterOrDigit(currentChar))
                {
                    return false;
                }

                if (char.IsDigit(currentChar))
                {
                    // if flag is letter return false
                    if (letterFlag == true)
                    {
                        return false;
                    }
                }

                if (char.IsLetter(currentChar))
                {
                    // if flag is digit return false
                    if (digitFlag == true)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public static bool IsPalindrom(string i_Str)
        {
            int len = i_Str.Length;

            if (len <= 1)
            {
                return true;
            }
            else
            {
                if (i_Str[0] != i_Str[len - 1])
                {
                    return false;
                }
                else
                {
                    return IsPalindrom(i_Str.Substring(1, len - 2));
                }
            }
        }

        public static bool IsNumber(string i_Str)
        {
            if (!char.IsDigit(i_Str[0]))
            {
                return false;
            }

            return true;
        }

        public static bool IsDivideByFour(string i_Str)
        {
            int num;
            bool goodInput = int.TryParse(i_Str, out num);
            if (goodInput)
            {
                if (num % 4 == 0)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool IsLetters(string i_Str)
        {
            if (!char.IsLetter(i_Str[0]))
            {
                return false;
            }

            return true;
        }

        public static int CountUpperLetters(string i_Str)
        {
            int countUpper = 0;

            for (int i = 0; i < i_Str.Length; i++)
            {
                char currentChar = i_Str[i];
                if (char.IsUpper(currentChar))
                {
                    countUpper++;
                }
            }

            return countUpper;
        }
    }
}
