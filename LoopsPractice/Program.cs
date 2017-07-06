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
            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine();
            while (firstName.ToUpper() == "DANIEL") 
            {
                Console.WriteLine("Dude, you are amazing"); //infinite repeats this statement if TRUE without break;
                break; //takes you back out of the loop
            }



        }   

    }
}

