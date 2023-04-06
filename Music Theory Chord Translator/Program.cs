using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Music_Theory_Chord_Translator;

class Program : AllChords
{
    public static void Main(string[] args)
    {
        bool showMenu = true;
        while (showMenu)
        {
            showMenu = MainMenu();
        }
    }

    private static bool MainMenu()
    {
        Console.Clear();
        Console.WriteLine("Welcome to the Console Chord Translator!");
        Console.WriteLine("Please use the numbers 1-4 to select which function you would like to use:");
        Console.WriteLine("1. Notes to Chord");
        Console.WriteLine("2. Chord to Notes");
        Console.WriteLine("3. Chord Writing Assistance");
        Console.WriteLine("4. Exit");

        switch (Console.ReadLine())
        {
            case "1":
                NotesToChord();
                return true;
            case "2":
                ChordToNotes();
                return true;
            case "3":
                ChordWritingAssistance();
                return true;
            case "4":
                return false;
            default:
                return true;
        }

        static void NotesToChord()
        {
            Console.WriteLine("Welcome to the Notes to Chord Translator!");
            Console.WriteLine("This application will translate notes into triads and seventh chords.");
            Console.WriteLine("To do so, please follow the formatting below when entereing your notes:");
            Console.WriteLine("Use \"#\" for sharp, \"b\" for flat, \"x\" for double sharp, and \"bb\" for double flat.");
            Console.WriteLine("Enter three or four notes in closed form (root position) with a space in between each.");
            Console.WriteLine("For example:\"C# Ex D#\" as an input will return 'C# Major'");
            Console.WriteLine("Type \"Exit\" at any time to return to the main menu");

            var userNotes = Console.ReadLine();
            {
                if (userNotes.ToLower() == "exit")
                {
                    Console.WriteLine("Thank you for using the Console Chord Translator!");
                    return;
                }

                else
                {
                    var chordOutput = Chords.FirstOrDefault(pair => pair.Value == userNotes).Key;
                    Console.WriteLine($"{userNotes} is {chordOutput}");
                    Console.WriteLine("Please input new notes, or type exit to return to the main menu");
                }

            }
        }

        static void ChordToNotes()
        {
            Console.WriteLine("Welcome to the Chord to Notes Translator!");
            Console.WriteLine("This application wil translate chord names into notes for easy writing.");
            Console.WriteLine("To do so, please follow the formatting below when writing your chord name.");
            Console.WriteLine("Use \"#\" for sharp and \"b\" for flat. An upper. Write exactly the chord you want displayed");
            Console.WriteLine("For example, writing \"C Major\" will return \"C E G\", while \"F# diminished\" will return \"F# A C\"");
            Console.WriteLine("Type \"Exit\" at any time to return to the Main Menu");

            var userChord = Console.ReadLine();
            {
                if (userChord.ToLower() == "exit")
                {
                    Console.WriteLine("Thank you for using the Console Chord Translator!");
                    return;
                }

                else
                {
                    var notesOutput = Chords[userChord];
                    Console.WriteLine($"{userChord} has the following notes: {notesOutput}");
                    Console.WriteLine("Please input a new chord, or type exit to return to the main menu");
                }
            }
        }

        static void ChordWritingAssistance()
        {
            Console.WriteLine("Welcome to the Chord Writing Assistance!");
            Console.WriteLine("This application will take user inputted notes and return all chords that can be written");
            Console.WriteLine("To do so, please follow the formatting below when inputting notes.");
            Console.WriteLine("Use \"#\" for sharp, \"b\" for flat, \"x\" for double sharp, and \"bb\" for double flat.");
            Console.WriteLine("Enter any combination of 1, 2, or 3 notes, and all possible chords will be returned.");

            var userPartialChord = Console.ReadLine();
            if (userPartialChord.ToLower() == "exit")
            {
                Console.WriteLine("Thank you for using the Chord Writing Assistance!");
                return;
            }

            var dictionaryValues = Chords.Values.ToList();
            var dictionaryQuery = from chord in dictionaryValues
                                    where chord.Contains(userPartialChord)
                                    select chord;

            Console.WriteLine("Possible chord options are:");
            foreach (var chord in dictionaryQuery)
                Console.Write(chord + " ");
            Console.WriteLine("Enter new notes, or type exit to return to the main menu"); 
        }
    }
}