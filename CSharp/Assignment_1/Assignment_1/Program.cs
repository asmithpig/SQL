// See https://aka.ms/new-console-template for more information
using Assignment_1;

//
// Playing with Console App
//
Helper.PlayingWithConsoleApp();
/*
 * Output/Input:
   what's your favorite color?
   red
   What's your astrology sign？
   gee
   What's your street address number？
   123123
   Your hacker name is redgee123123.
 */


//
// Practice number sizes and ranges
//
// 1.Create a console application project named /02UnderstandingTypes/ that outputs the number of bytes
// in memory that each of the following number types uses, and the minimum and maximum values they can have:
// sbyte, byte, short, ushort, int, uint, long, ulong, float, double, and decimal.
Helper.PracticeNumberSizesAndRanges1();
/*
 * Output:
 * Data Type | Bytes      Minimum Value                            Maximum Value                           
   -----------------------------------------------------------------------
   sbyte     | 1          -128                                     127                                     
   byte      | 1          0                                        255                                     
   short     | 2          -32768                                   32767                                   
   ushort    | 2          0                                        65535                                   
   int       | 4          -2147483648                              2147483647                              
   uint      | 4          0                                        4294967295                              
   long      | 8          -9223372036854775808                     9223372036854775807                     
   ulong     | 8          0                                        18446744073709551615                    
   float     | 4          -3.4028235E+38                           3.4028235E+38                           
   double    | 8          -1.7976931348623157E+308                 1.7976931348623157E+308                 
   decimal   | 16         -79228162514264337593543950335           79228162514264337593543950335
 */

// 2. Write program to enter an integer number of centuries and convert it to
// years, days, hours, minutes, seconds, milliseconds, microseconds, nanoseconds.
// Use an appropriate data type for every data conversion. Beware of overflows!
Helper.PracticeNumberSizesAndRanges2(1);
Helper.PracticeNumberSizesAndRanges2(5);
Helper.PracticeNumberSizesAndRanges2(2147483647);
/*
 * Output:
 * Input: 1
 * Output: 1 centuries = 100 years = 36524 days = 876582 hours = 52594920 minutes
 * = 3155695200 seconds = 3155695200000 milliseconds = 3155695200000000 microseconds
 * = 3155695200000000000 nanoseconds
 * Input: 5
 * Output: 5 centuries = 500 years = 182621 days = 4382910 hours = 262974600 minutes
 * = 15778476000 seconds = 15778476000000 milliseconds = 15778476000000000 microseconds
 * = 15778476000000000000 nanoseconds
 * Input: 2147483647
 * Output: 2147483647 centuries = 214748364700 years = 78435229593939 days = 1882445510254554 hours
 * = 112946730615273240 minutes = 6776803836916394400 seconds = 6776803836916394400000 milliseconds
 * = 6776803836916394400000000 microseconds = 6776803836916394400000000000 nanoseconds
 */
 

//
// Practice loops and operators
//
// 1. FizzBuzz is a group word game for children to teach them about division. Players take turns to count
// incrementally, replacing any number divisible by three with the word /fizz/, any number divisible by five
// with the word /buzz/, and any number divisible by both with / fizzbuzz/.
// Create a console application in Chapter03 named Exercise03 that outputs a simulated FizzBuzz game
// counting up to 100. The output should look something like the following screenshot:
Helper.FizzBuzz(100);

// What will happen if this code executes?
// int max = 500;
// for (byte i = 0; i < max; i++)
// {
//   WriteLine(i);
// }
//-- This is an infinite loop because the maximum value of byte is 255. When i reaches 255, after i++ operation,
// i becomes 0 and the loop will continue infinitely.
// 
// What code could you add (don’t change any of the preceding code) to warn us about the problem?
// add statement to pre-check the max value before go into the loop
// if (max > byte.MaxValue) {
//      Console.WriteLine("Warning: max value exceeds maximum value of byte 255.");
// }

// Your program can create a random number between 1 and 3 with the following code:
// Write a program that generates a random number between 1 and 3 and asks the user to guess what the number is.
// Tell the user if they guess low, high, or get the correct answer. Also, tell the user if their answer is
// outside of the range of numbers that are valid guesses (less than 1 or more than 3). You can convert the
// user's typed answer from a string to an int using this code:
Helper.GuessNumber();
/* Output/Input:
 * Guess a number between 1 and 3!
   4
   Answer is outside of the range of numbers that are valid guesses (less than 1 or more than 3)!
   0
   Answer is outside of the range of numbers that are valid guesses (less than 1 or more than 3)!
   2
   High.
   1
   You get the correct answer.
 */

// 2. Print-a-Pyramid.Like the star pattern examples that we saw earlier, create a program that will print the following pattern: If you find yourself getting stuck, try recreating the two examples that we just talked about in this chapter first. They’re simpler, and you can compare your results with the code included above.
// This can actually be a pretty challenging problem, so here is a hint to get you going. I used three total loops. One big one contains two smaller loops. The bigger loop goes from line to line. The first of the two inner loops prints the correct number of spaces, while the second inner loop prints out the correct number of stars.
Helper.PrintPyramidLikeStarPattern(5);
Helper.PrintPyramidLikeStarPattern(10);
/*
 * Print a pyramid like star pattern with 5 rows!
       *
      ***
     *****
    *******
   *********
   Print a pyramid like star pattern with 10 rows!
           *
          ***
         *****
        *******
       *********
      ***********
     *************
    ***************
   *****************
 */
 
// 3. Write a program that generates a random number between 1 and 3 and asks the user to guess what the number is. Tell the user if they guess low, high, or get the correct answer. Also, tell the user if their answer is outside of the range of numbers that are valid guesses (less than 1 or more than 3). You can convert the user's typed answer from a string to an int using this code:
Helper.GuessNumber();
/* Output/Input:
 * Guess a number between 1 and 3!
   4
   Answer is outside of the range of numbers that are valid guesses (less than 1 or more than 3)!
   0
   Answer is outside of the range of numbers that are valid guesses (less than 1 or more than 3)!
   2
   High.
   1
   You get the correct answer.
 */
 
// 4. Write a simple program that defines a variable representing a birth date and calculates how many days old the person with that birth date is currently.
// For extra credit, output the date of their next 10,000 day (about 27 years) anniversary. Note: once you figure out their age in days, you can calculate the days until the next anniversary using int daysToNextAnniversary = 10000 - (days % 10000);
DateTime birthday = new DateTime(1984, 2, 19);
Helper.DaysOldAnniversary(birthday);
/*
 * This person is 14610 days old.
   5390 days until this person's next 10,000 day (about 27 years) anniversary.
 */

// 5. Write a program that greets the user using the appropriate greeting for the time of day. Use only if , not else or switch , statements to do so.
Helper.Greetings(DateTime.Now);

// 6. Write a program that prints the result of counting up to 24 using four different increments. First, count by 1s, then by 2s, by 3s, and finally by 4s.
Helper.CountingTo24();
/*
 * 0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24
   0,2,4,6,8,10,12,14,16,18,20,22,24
   0,3,6,9,12,15,18,21,24
   0,4,8,12,16,20,24
 */