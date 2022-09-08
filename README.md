# C-exercise-01
(*) Practice writing a program in #C syntax . (*) Work with I/O in the Console environment. (*) Introduction to the classes: string, int, float, char, math, StringBuilder.

----------------------EX1. Binary series -----------------------
Write a program that receives from the user 3 numbers in binary format of 9 digits each.
After each number, the user presses enter (invalid input will be reported to the user as invalid and the program will wait for valid input).
The program will convert the entered numbers into decimal numbers and print them in decimal format.
In addition, the program will print statistics about the input:
* What is the average number of zeros / ones in each number that is a convention
(In other words, you have to allow all the zeros entered from all the inputs divided by the number of inputs and the same should be done on unity)
* How many strengths have been absorbed, 2.
* How many of their absorbed digits, in representation, constitute a real ascending order 4
* Who you have arrived at is the greatest.

Run examples must be provided on the following inputs:
a.) 111010100, 111010010, 111011000
The numbers are: 468, 466, 472 - none of them is a power of 2, in 1 of them there is an ascending series in the digits,
The largest is 472, the smallest is 466)
b.) 001001110, 011010000, 001110000 
c.)101111110, 110001111, 011010110. 


------------------------ EX2. Hourglass for beginners--------------------
Write a program that prints an hourglass of stars to the screen as follows:
*****
***
*
***
*****
must be realized with the help of recursion.


-------------------------EX3. Hourglass for advanced students----------------------------------
Write a program that will work like the hourglass program for beginners, but will accept the requested height of the clock as input
from the user (the user must be warned about incorrect input!).
(Try to realize this by referring to the assembly you created in section 2 (Hourglass for beginners) by adding
Reference from the project of this section to the project of the previous section.
In the case of double input, at your discretion: add another line in the middle or add/remove 1.
Run examples must be provided on the inputs: 4, 5, 6, 7


----------------------EX4. Parsing a string---------------------------------------
5. Write a program that accepts as input a string of size 8 characters (for example: abaccaba) and provides the following details:
1. Is the string a palindrome (must be realized with the help of recursion)
2. If it is a number - is it divisible by 4 without a remainder.
3. If it is an English string - the number of uppercase letters in it
4. The user must be warned about incorrect input.
Please note, the string must consist of only English letters (uppercase or lowercase), or numbers only.
Strings such as ab45abr6 are invalid. Note that uppercase letters are considered different from lowercase letters.


-------------------------------EX6. Statistics numbers-------------------------------
Write a program that accepts a positive 9-digit whole number from the user and provides the following details:
1. What is the largest digit in the number
2. What is the average of the digits
3. How many of the digits in the number are divisible by 3 without a remainder
4. How many digits are smaller than the number of unity in the number
(Note, the input 000000123 is a valid input)
5. The user must be warned about incorrect input.



---------------------------pay attention: ---------------------------------
1. It is mandatory to use the following classes and methods:
 StringBuilder - we did not know. Requires independent research.
string.Format 
 TryParse.int - there is an example in the sample code on the website.
 Math - we did not meet in class. Requires independent research.
 char - we did not meet in class. Requires independent research.
 Additional methods of the string class that can help.
2. There is no obligation to use arrays and it is better to avoid using arrays because we have not yet learned to use arrays.
3. Code snippets presented in the lectures and training videos are on the website under the "code examples" category.
4. The section of binary to decimal must be implemented by yourself, and not use an existing method that performs this.
5. We have not yet studied topics related to departments, therefore at this stage the code must be implemented using methods
Static only, and without division into departments. All methods will be defined in the Program class of each one
of the sections.
6. Do not implement the entire program in the Main method, but call other methods from the Main method.
The role of the Main method is to be an entry point to the program and nothing else.
7. A correct division into methods must be demonstrated.
