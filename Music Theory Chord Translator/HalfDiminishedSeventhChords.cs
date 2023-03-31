using System;
namespace Music_Theory_Chord_Translator
{
	public class HalfDiminishedSeventhChords : DiminishedSeventhChords
	{
        public static Dictionary<string, string> HDimChords { get; set; }

        static HalfDiminishedSeventhChords()
        {
            HDimChords = new Dictionary<string, string>(StringComparer.InvariantCultureIgnoreCase)
            {

                { "C half diminished", "C Eb Gb Bb" },
                { "C# half diminished", "C# E G B" },
                { "Db half diminished", "Db Fbb Abb Cb" },
                { "D half diminished", "D F Ab C" },
                { "D# half diminished", "D# F# A C#" },
                { "Eb half diminished", "Eb Gb Bbb Db" },
                { "E half diminished", "E G Bb D" },
                { "F half diminished", "F Ab Cb Eb" },
                { "F# half diminished", "F# A C E" },
                { "Gb half diminished", "Gb Bbb Dbb Fb" },
                { "G half diminished", "G Bb Db F" },
                { "G# half diminished", "G# B D F#" },
                { "Ab half diminished", "Ab Cb Ebb Gb" },
                { "A half diminished", "A C Eb G" },
                { "A# half diminished", "A# C# E G#" },
                { "Bb half diminished", "Bb Db Fb Ab" },
                { "B half diminished", "B D F A" },
            };
        }
    }
}

