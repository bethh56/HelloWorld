using System;
using System.Linq;

namespace HelloWorld
{
    class Program
    {
        static void CountSyllables(string word)
        {
            var vowels = new string[] { "a", "e", "i", "o", "u", "y" };
            int numberOfVowels = 0;
            foreach (var letter in vowels)
            {
                if (word.Contains(letter))
                {
                    numberOfVowels++;
                }
            }
            if (numberOfVowels >= 3)
            {
                Console.WriteLine(word);
            }
        }
        static void Main(string[] args)
        { 

            var animals = new string[] { "Triceratops", "Gorilla", "Corgi", "Toucan" };


            Console.WriteLine("Select a greeting:");
            Console.WriteLine("Southern");
            Console.WriteLine("Spanish");
            Console.WriteLine("German");

            var input = Console.ReadLine();

            if (input == "Southern")
            {
                Console.WriteLine("Howdy Y'all!!");
            }
            else if (input == "Spanish")
            {
                Console.WriteLine("Hola!");
            }
            else if (input == "German")
            {
                Console.WriteLine("Hallo!");
            }
            else
            {
                Console.WriteLine("Howdy Y'all!!");
            }


            Console.WriteLine("Here are some words with 3 or more syllables:");

            foreach (var animal in animals)
            {
                CountSyllables(animal);
            };

        }
    }
 }

