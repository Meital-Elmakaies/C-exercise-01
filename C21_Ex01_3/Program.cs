namespace C21_Ex01_3
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
            Console.WriteLine("Please enter height for the hourglass");
            string input = Console.ReadLine();
            while (!InputValidation(input))
            {
                Console.WriteLine("Invalid input try again...");
                input = Console.ReadLine();
            }

            if(int.TryParse(input, out int height))
            {
                C21_Ex01_2.Program.PrintHourglassRec(height, 0);
            }           
        }

        public static bool InputValidation(string i_HeightStr)
        {
            for (int i = 0; i < i_HeightStr.Length; i++)
            {
                char currentChar = i_HeightStr[i];
                if (!char.IsDigit(currentChar))
                {
                    return false;
                }

                if(int.TryParse(i_HeightStr, out int height))
                {
                    if (height < 0)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
