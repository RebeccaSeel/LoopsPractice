using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //loops: for loops, foreach loops, while loops, do-while loops
            //when would you use a loop? - repeition of a fragment of code
            //why would you use a loop?
            //nested loops ex. clock - seconds, minutes, hours, days
            //infinite loops
            //keywords break and continue

            //For Loop - for counting  and/or ... iterating (going from one index to next, etc., doing same activity) 
            //through an array (or other collection type)
            //Looks like this:
            //for(initializer; condition; updater)
            //{
            //  do something
            //}

            //CONTINUED ON 7.6.2017

            //example of for loop == i stands for iterator, ++ means add 1 (i doesn't exist outsite scope)
            //some people call i "counter" instead of "i"
            //for(int i=0; i <=10; i++) //starts at 0, applies the condition, then adds 1, at end it updates i
            //{
            //    Console.WriteLine(i); //keep adding 1 so start at 0, add 1, etc. will write 0, 1,2,3,4,5,6,7,8,9,10,11 where it breaks
            //}

            ////another example
            //for (int i = 15; i > 0; i--)
            //{
            //    Console.WriteLine(i);
            //}

            ////another example
            //for (int i = 15; i > 0; i++) //you get an infinite loop because every +1 is greater than 0
            //{
            //    Console.WriteLine(i);
            //}

            //another example, usually not like this, this is not a good practice
            //int i; //now i exists outside of loop
            //for (i = 15; i > 0; i--) //-- means decremant
            //{
            //    Console.WriteLine(i); //shows what happens in loop
            //}
            //Console.WriteLine("After the loop has run, i now has the value of " + i);

            //example = print 50-100
            //for(int i = 50; i <= 100; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //use a loop to print out an array
            //split - each word is separated, splits on spaces/white spaces, delimited
            //string greeting = "My name is Little Bill.";
            ////the .Split() method takes a string and turns it into an array of smaller
            ////strings (substrings). It defaults the split on spaces.
            //string[] wordsInGreeting = greeting.Split(); //hover over () to get additional options for the .Split (other than default)
            ////for loop to print the words (int i = 0 refers to the index value 
            //for(int i = 0; i < wordsInGreeting.Length; i++)
            //{
            //    Console.WriteLine(wordsInGreeting[i]); //prints each word on a separate line
            //} 

            //IN-CLASS PRACTICE PROBLEMS
            //Problem #1
            //Create an array called days with the elements Monday, Tuesday, and Wednesday.
            //Using a For Loop, print the elements of the days array.
            //string[] days = { "Monday", "Tuesday", "Wednesday" };
            //for(int i = 0; i < days.Length; i++)
            //{
            //    Console.WriteLine(days[i]);
            //}

            //Problem #2
            //Start with the string "Once upon a time" and create an array called
            //storyWords using the Split method. Reverse the order of the elements in
            //the array and using a For Loop, print each word
            //string story = "Once upon a time";
            //string[] storyWords = story.Split();
            //Array.Reverse(storyWords); //need to know how to do this without the .Reverse method
            //for (int i = 0; i < storyWords.Length; i++)
            //{
            //    Console.WriteLine(storyWords[i]);
            //}

            //Problem #3
            //Determine the product (multiplication) of 1 through 10 using a For Loop
            //Print the product to the screen

            //int product;
            //product = 1;
            //for (int i = 1; i <= 10; i++)
            //{
            //    product = product * i;
            //}
            //Console.WriteLine(product);

            //or

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int product = numbers[1];
            //for (int i = 1; i < numbers.Length; i++)
            //{
            //    product = product * numbers[1];
            //}
            //Console.WriteLine(product);

            //foreach loop - used to iterate over a collection (ex. list or array)
            //You can think of the structure of a foreach loop as the statement:
            //for each item in the collection, do something
            //Looks like this:
            //foreach(datatype variable in collection)
            //{
            //    do something
            //}

            //Example:
            //int[] studentGrades = { 4, 4, 3, 4, 3 };
            //foreach(int grade in studentGrades)
            //{
            //    Console.WriteLine(grade);
            //}

            //Example:
            //string[] firstMonths = { "Jan", "Feb", "Mar", "Apr", "May", "June" };
            ////always start with the keyword foreach
            //foreach(string month in firstMonths) //month works as a temporary variable
            //{
            //    Console.WriteLine(month);
            //}

            //Example:
            //string[] calendar = { "Jan", "Dog", "Mar", "Apr", "May", "June" };
            ////always start with the keyword foreach
            ////foreach knows to take temporary variable and assign it to each element in the collection, one at a time
            ////foreach loops always go from first element to last element, no breaking
            //foreach (string month in calendar) //month works as a temporary variable
            //{
            //    Console.WriteLine(month);
            //}

            //create an array of 6 musicians (bands or solo artists)
            //using a foreach loop, print each musician's name
            //string[] musicianNames = { "Adele", "Dean Martin", "Black Stone Cherry", "Blue Edmondson", "Beth Hart", "Johnny Lang" };
            //foreach (string artist in musicianNames)
            //{
            //    Console.WriteLine(artist);
            //}

            //**While Loops - when you want a chunk of code to run only if a condition is met
            //can be used for counting (though usually counting is done with a for loop)
            //ex. must be a certain height to ride a roller coaster (while true, do this code)
            //While and do-while loops rely on boolean true/false to execute
            //While something is TRUE, do this thing.

            //example, playing arcade games, while you still have money, you can continue to play
            //example, easy to understand, but less useful -- not used often
            //Console.WriteLine("What is your first name?");
            //string firstName = Console.ReadLine();
            //while (firstName.ToUpper() == "DANIEL") 
            //{
            //    Console.WriteLine("Dude, you are amazing"); //infinite repeats this statement if TRUE without break;
            //    break; //takes you back out of the loop
            //}


            //another example of while loop ex. to see if a gamer wants to continue playing game
            //Console.WriteLine("Do you want to play the game? YES/NO");
            //string playAgain = Console.ReadLine().ToUpper();
            //while (playAgain == "YES")
            //{
            //    Console.WriteLine("It's a rematch!");
            //    Console.WriteLine("Do you want to play again? YES/NO");
            //    playAgain = Console.ReadLine();
            //}

            //DO-WHILE LOOPS
            //similar to a while loop, however the do-while loop is used when you want a chunk of code to run
            //at least one, but repeat only if the while condition is met
            //real life: let netflex user watch movies as long as their subscription in valid
            //real life: try ice cream, do try ice cream once, eat again if you like it

            //The structure of a do-while loop looks like this:
            //do
            //{
            //    do something
            //}
            //while (condition);

            //string playAgain;
            //do
            //{
            //    Console.WriteLine("Welcome to my game!");
            //    //let's preten the code for the game is here
            //    Console.WriteLine("Great game!!");
            //    Console.WriteLine("Do you want to play again? YES/NO");
            //    playAgain = Console.ReadLine();
            //}
            //while (playAgain == "YES");
            //for Fortune Teller project, do-while loop for data validation such as birth month, age, etc.
            //for Fortune Teller project, put all code in do, let user play again in while, etc. to continue game

            //Practice: ask the user for the class (in school) they would like to add to their GPA calculation
            //ask the user for the letter grade for the class (no + or -)
            //ask the user if they have another class they would like to add to their GPA calculation
            //Using a do-while loop, repeat the code if the user says "YES"

            //string newClass;
            //string newGrade;
            //string anotherEntry;
            //do
            //{
            //    Console.WriteLine("What class do you want to add to your GPA calculation?");
            //    newClass = Console.ReadLine();
            //    Console.WriteLine("What is the letter grade for the class?");
            //    newGrade = Console.ReadLine();
            //    Console.WriteLine("Do you want to add another class to add to your GPA calculation? YES/NO");
            //    anotherEntry = Console.ReadLine();
            //}
            //while (anotherEntry == "YES");

            //break = ends loop
            //continue = allows program to continue after pulling out a specific condition -- see slide

            //NESTED LOOPS
            //a loop inside another loop
            //the inner loop is executed more times than the outer loop
            //ex. a clock -- count up starting with seconds, then minutes, then hours, then day

            //simple example
            //create a nested loop structure that prints: 2 rows, 4 columns
            //1234
            //1234

            //for(int rows = 1; rows <= 2; rows++) //i = rows, rows are not an array
            //{
            //    for(int columns = 1; columns <=4; columns++) //j = columns
            //    {
            //        Console.Write(columns); //write, not write.line to keep on same line
            //    }
            //    Console.WriteLine(); //empty to separate first row from second row, etc. == new line
            //}

            //columns in inner loop because 4 columns and only 2 rows

            //print a triangle
            //outer loop will go line by line
            //the inner loop will go over different elements in the line
            //1
            //12
            //123
            //1234

            //for(int rows = 1; rows <= 4; rows++)
            //{
            //    for(int columns = 1; columns <= 1; columns++)
            //    {
            //        Console.Write(columns);
            //    }
            //    Console.WriteLine();
            //    for (int columns = 1; columns <= 2; columns++)
            //    {
            //        Console.Write(columns);
            //    }
            //    Console.WriteLine();
            //    for (int columns = 1; columns <= 3; columns++)
            //    {
            //        Console.Write(columns);
            //    }
            //    Console.WriteLine();
            //    for (int columns = 1; columns <= 4; columns++)
            //    {
            //        Console.Write(columns);
            //    }
            //    Console.WriteLine();
            //    break;
            //}

            ////A CLEANER WAY TO DO THIS!!
            //for(int rows = 1; rows <=4; rows++)
            //{
            //    for(int columns = 1; columns <= rows; columns++)
            //    {
            //        Console.WriteLine(columns);
            //    }
            //    Console.WriteLine();
            //}

            //LET USER SELECT NUMBER OF ROWS
            //Console.WriteLine("How many rows to you want in your triangle?");
            //int n = int.Parse(Console.ReadLine());
            //for (int row = 1; row <= n; row++)
            //{
            //    for (int col = 1; col <= row; col++)
            //    {
            //        Console.Write(col + " ");
            //    }
            //    Console.WriteLine();
            //}

            //DANIEL'S FIZZBUZZ
            //Remember that in FizzBuzz, if it is not a FizzBuzz, Fizz, or Buzz number
            //you print the number itself.
            //Console.WriteLine("Let's Play FizzBuzz!");
            //Console.WriteLine("Please enter your FIZZ number");
            //int fizz = int.Parse(Console.ReadLine());
            //Console.WriteLine("Please enter your BUZZ number");
            //int buzz = int.Parse(Console.ReadLine());
            //Console.WriteLine("What number would you like me to count to? (Pick a high one)");
            //int endNumber = int.Parse(Console.ReadLine());
            //for (int i = 0; i <= endNumber; i++)
            //{
            //    if (i % fizz == 0 && i % buzz == 0)
            //    {
            //        Console.WriteLine("Fizz Buzz!");
            //    }
            //    else if (i % fizz == 0)
            //    {
            //        Console.WriteLine("Fizz!");
            //    }
            //    else if (i % buzz == 0)
            //    {
            //        Console.WriteLine("Buzz!");
            //    }
            //    else
            //    {
            //        Console.WriteLine(i);
            //    }
            //}


            //HOMEWORK DO IT PROBLEM
            //Create an array of lucky numbers(just any numbers you like). Using a foreach loop, print the following:
            //If the array holds the numbers 3, 5, 7, 11, 15, then the printed result should say
            //Your Lucky Number is: 3
            //Your Lucky Number is: 5
            //Your Lucky Number is: 7
            //Your Lucky Number is: 11
            //Your Lucky Number is: 15

            //int[] luckyNumbers = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21 };
            //foreach(int matchNumber in luckyNumbers)
            //{
            //    if (matchNumber.Equals(3))
            //    {
            //        Console.WriteLine("Your lucky number is: 3");
            //    }
            //    else if (matchNumber.Equals(5))
            //    {
            //        Console.WriteLine("Your lucky number is: 5");
            //    }
            //    else if (matchNumber.Equals(7))
            //    {
            //        Console.WriteLine("Your lucky number is: 7");
            //    }
            //    else if (matchNumber.Equals(11))
            //    {
            //        Console.WriteLine("Your lucky number is: 11");
            //    }
            //    else if (matchNumber.Equals(15))
            //    {
            //        Console.WriteLine("Your lucky number is: 15");
            //    }
            //}


            //HOMEWORK PROBLEM #2
            //Write a program that prints a multiplication table (5 x 5, for example) using a nested loops.

            


            //HOMEWORK PROBLEM #3
            //Create an array of your favorite movies.Print out each movie in the list, unless the move starts with a vowel. 
            //Hint: Research.startsWith()



            //HOMEWORK #4
            //Write a console application that asks the user for an integer. 
            //If that integer is evenly divisible by 3, then write “You Won!” If it isn’t, write “You Lost.” 
            //Keep asking them for a number (looping)until they win.



        }




    }   

    }


