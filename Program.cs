using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Music_Theory_Chord_Translator;

class Program : AllChords
{
    public static void Main(string[] args)
    {

        Console.WriteLine("Welcome to the Console Chord Translator!");
        Console.WriteLine("Please use the numbers 1-3 to select which function you would like to use:");
        Console.WriteLine("1. Notes to Chord");
        Console.WriteLine("2. Chord to Notes");
        Console.WriteLine("3. Roman Numeral Analysis");

        var userInput = int.Parse(Console.ReadLine());
        for (int i = 0; i < userInput; i++)
        {
            if (userInput == 1)
            {
                Console.WriteLine("Welcome to the Notes to Chord Translator!");
                Console.WriteLine("This application will translate notes into triads and seventh chords.");
                Console.WriteLine("To do so, please follow the formatting below when entereing your notes:");
                Console.WriteLine("Use \"#\" for sharp, \"b\" for flat, \"x\" for double sharp, and \"bb\" for double flat.");
                Console.WriteLine("Enter three or four notes in closed form (root position) with a space in between each.");
                Console.WriteLine("For example:\"C# Ex D#\" as an input will return 'C# Major'");
                Console.WriteLine("Type \"Exit\" at any time to quit. Type \"Main Menu\" to choose another function");

                var userChord = Console.ReadLine();
                {
                    if (userChord.ToLower() == "exit")
                    {
                        Console.WriteLine("Thank you for using the Console Chord Translator!");
                        return;
                    }

                    if (userChord.ToLower() == "main menu")
                    {

                    }

                    else
                    {
                        var chordOutput = Chords.FirstOrDefault(pair => pair.Value == userChord).Key;
                        Console.WriteLine($"{userChord} is {chordOutput}");
                        Console.WriteLine("Please input a new chord, return to the Main Menu, or exit.");
                    }

                }

                if (userInput == 2)
                {
                    Console.WriteLine("Welcome to the Chord to Notes Translator!");
                }

                if (userInput == 3)
                {
                    Console.WriteLine("Welcome to the Roman Numeral Analysis!");
                }
            }
        }
    }
}