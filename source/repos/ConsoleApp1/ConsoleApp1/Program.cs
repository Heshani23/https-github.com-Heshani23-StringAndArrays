// See https://aka.ms/new-console-template for more informatio


using System;

namespace StringsAndArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // PART 1: Strings

            // 1. Basic String Operations
            string helloWorld = "Hello, World!";

            // 1.1 Print the length of the string.
            Console.WriteLine("1.1 String Length: " + helloWorld.Length);

            // 1.2 Print the first and the last character of the string.
            Console.WriteLine("1.2 First Character: " + helloWorld[0]);
            Console.WriteLine("1.2 Last Character: " + helloWorld[helloWorld.Length - 1]);

            // 2. String Manipulation

            Console.Write("Please enter your name: ");
            // 2.1 Get the input from and assign it to a new string variable called name
            string name = Console.ReadLine();

            // 2.2 Print a personalized welcome message including the name.
            Console.WriteLine("2.2 Welcome, " + name + "!");

            // 2.3 Convert name variable to uppercase and output the result
            Console.WriteLine("2.3 Uppercase: " + name.ToUpper());

            // 2.4 Convert name variable to lowercase and output the result
            Console.WriteLine("2.4 Lowercase: " + name.ToLower());

            // 3. String Searching
            // 3.1 Create a new boolean variable called containsWorld
            bool containsWorld;

            // 3.2 Check that the helloWorld variable contains the word "World".
            // Assign the result to the created containsWorld variable
            containsWorld = helloWorld.Contains("World");

            // 3.3 If the word is found, get the index of the word from helloWorld string
            if (containsWorld)
            {
                int index = helloWorld.IndexOf("World");
                Console.WriteLine("3.3 Word 'World' found at index: " + index);
            }
            else
            {
                Console.WriteLine("3.3 Word 'World' not found.");
            }

            // PART 2: Arrays

            // 1. Basic Array Operations
            // 1.1 Initialize an array called numbers containing an array of int values
            // Add these values to the array -> 2 3 5 7 11
            int[] numbers = { 2, 3, 5, 7, 11 };

            // 1.2 Output the numbers array -> hint use Join
            // Expected outcome: 2, 3, 5, 7, 11
            string numbersStr = string.Join(", ", numbers);
            Console.WriteLine("1.2 Numbers: " + numbersStr);

            // 1.3 Output the value of the third (3rd) item in the numbers array
            // Expected outcome: 5
            int thirdItem = numbers[2];
            Console.WriteLine("1.3 Third Item: " + thirdItem);

            // 2. Array Manipulation
            Console.WriteLine("Please enter five names:");
            // 2.1 Initialize a new names string array variable that has room for 5 items
            string[] names = new string[5];

            // 2.2 Ask the user to input new names 5 times
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter name " + (i + 1) + ": ");
                names[i] = Console.ReadLine();
            }

            // 2.3 Output the array of given names.
            Console.WriteLine("2.3 Names:");
            foreach (string n in names)
            {
                Console.WriteLine(n);
            }

            // 2.4 Reverse the order of the items in the names array and output the result
            Array.Reverse(names);
            Console.WriteLine("2.4 Reversed Names:");
            foreach (string n in names)
            {
                Console.WriteLine(n);
            }

            // 3. Array Searching
            Console.Write("Please enter a name to search: ");
            string searchName = Console.ReadLine();
            // 3.1 Try to find out the searchName from the Task 2 names string array
            // by finding out its index.
            // Assign the index value to a new position integer variable
            int position = Array.IndexOf(names, searchName);

            // 3.2 Check that the index position was found
            if (position != -1)
            {
                // 3.2.1 If position is found, output the searchName and the found position
                Console.WriteLine("3.2.1 Name '" + searchName + "' found at position " + position);
            }
            else
            {
                // 3.2.2 Else output that the searchName was not found
                Console.WriteLine("3.2.2 Name '" + searchName + "' was not found.");

            }

            // 4. BONUS

            // 1. String to Array
            // 1.1 Create a new empty words string array
            string[] words;

            // 1.2 Try to get each word from the helloWorld variable and assign the values to
            // the created words string array
            words = helloWorld.Split(new char[] { ' ', ',', '!' }, StringSplitOptions.RemoveEmptyEntries);

            // 1.3 Output the values of the words array
            Console.WriteLine("BONUS 1.3 Words:");
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
