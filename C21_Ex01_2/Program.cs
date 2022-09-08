namespace C21_Ex01_2
{
    using System;

    public class Program
    {
        public static void Main()
        {
            PrintHourglassRec(5, 0);
        }

        public static void PrintHourglassRec(int i_Height, int i_RequiredSpaces)
        {
            PrintAsterisks(i_Height, i_RequiredSpaces);
            if (i_Height > 2)
            {
                PrintHourglassRec(i_Height - 2, i_RequiredSpaces + 1);
                PrintAsterisks(i_Height, i_RequiredSpaces);
            }
        }

        public static void PrintAsterisks(int i_Height, int i_RequiredSpaces)
        {
            if (i_RequiredSpaces > 0)
            {
                Console.Write(" ");
                PrintAsterisks(i_Height, i_RequiredSpaces - 1);
            }
            else if (i_Height > 0)
            {
                Console.Write("*");
                PrintAsterisks(i_Height - 1, i_RequiredSpaces);
            }
            else
            {
                Console.WriteLine();
            }
        }
    }
}
