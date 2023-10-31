// See https://aka.ms/new-console-template for more informatio


using System;

namespace StringsAndArrays
{
    class Program
    {
        static void Main(string[] args)
        {
         
            string helloWorld = "Hello, World!";

            Console.WriteLine("1.1 String Length: " + helloWorld.Length);

            Console.WriteLine("1.2 First Character: " + helloWorld[0]);
            Console.WriteLine("1.2 Last Character: " + helloWorld[helloWorld.Length - 1]);

            Console.Write("Please enter your name: ");
     
            string name = Console.ReadLine();

            Console.WriteLine("2.2 Welcome, " + name + "!");

    
            Console.WriteLine("2.3 Uppercase: " + name.ToUpper());

            Console.WriteLine("2.4 Lowercase: " + name.ToLower());

      
            bool containsWorld;

            containsWorld = helloWorld.Contains("World");

            if (containsWorld)
            {
                int index = helloWorld.IndexOf("World");
                Console.WriteLine("3.3 Word 'World' found at index: " + index);
            }
            else
            {
                Console.WriteLine("3.3 Word 'World' not found.");
            }

    
            int[] numbers = { 2, 3, 5, 7, 11 };

      
            string numbersStr = string.Join(", ", numbers);
            Console.WriteLine("1.2 Numbers: " + numbersStr);
            int thirdItem = numbers[2];
            Console.WriteLine("1.3 Third Item: " + thirdItem);

            Console.WriteLine("Please enter five names:");
         
            string[] names = new string[5];

        
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter name " + (i + 1) + ": ");
                names[i] = Console.ReadLine();
            }

            Console.WriteLine("2.3 Names:");
            foreach (string n in names)
            {
                Console.WriteLine(n);
            }

            Array.Reverse(names);
            Console.WriteLine("2.4 Reversed Names:");
            foreach (string n in names)
            {
                Console.WriteLine(n);
            }

        
            Console.Write("Please enter a name to search: ");
            string searchName = Console.ReadLine();
          
            int position = Array.IndexOf(names, searchName);

    
            if (position != -1)
            {
            
                Console.WriteLine("3.2.1 Name '" + searchName + "' found at position " + position);
            }
            else
            {
                Console.WriteLine("3.2.2 Name '" + searchName + "' was not found.");

            }

   
            string[] words;

            words = helloWorld.Split(new char[] { ' ', ',', '!' }, StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine("BONUS 1.3 Words:");
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
