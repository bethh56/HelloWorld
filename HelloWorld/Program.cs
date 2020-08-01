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

            string name;

            do
            {
                Console.WriteLine("Please enter your name");
                name = Console.ReadLine();
                Console.WriteLine($"Select a greeting {name}:");

            } while (name != $"{name}");

            
            Console.WriteLine("Southern");
            Console.WriteLine("Spanish");
            Console.WriteLine("German");

            var input = Console.ReadLine();

            if (input == "Southern")
            {
                Console.WriteLine($"Howdy {name}!!");
            }
            else if (input == "Spanish")
            {
                Console.WriteLine($"Hola {name}!");
            }
            else if (input == "German")
            {
                Console.WriteLine($"Hallo {name}!");
            }
            else
            {
                Console.WriteLine($"Howdy {name}!!");
            }

            string color;

            Random rand = new Random();
            int index = rand.Next(animals.Length);

            do
            {
                Console.WriteLine($"{name}, what is your favorite color?");
                color = Console.ReadLine();
                Console.WriteLine($"{name}, would you like to have a {color} {animals[index]}?");

            } while (color != $"{color}");

            Console.WriteLine("Please enter yes or no:");

            var wantsAnimal = Console.ReadLine();

            if (wantsAnimal == "yes")
            {
                Console.WriteLine($"Too bad {name}! We are all out! Look at some words with 3 or more syllables instead! ");
            } else
            {
                Console.WriteLine($"{name}, check out some words with 3 or more syllables instead!");
            }

            foreach (var animal in animals)
            {
                CountSyllables(animal);
            };

        }
    }
 }

