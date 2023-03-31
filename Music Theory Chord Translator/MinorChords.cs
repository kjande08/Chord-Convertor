using System;
namespace Music_Theory_Chord_Translator
{
	public class MinorChords : MajMajSeventhChords
	{
        public static Dictionary<string, string> MinChords { get; set; }

        static MinorChords()
        {
            MinChords = new Dictionary<string, string>(StringComparer.InvariantCultureIgnoreCase)
            {
			
                { "C minor", "C Eb G" },
                { "C# minor", "C# E G#" },
                { "Db minor", "Db Fbb Ab" },
                { "D minor", "D F A" },
                { "D# minor", "D# F# A#"},
                { "Eb minor", "Eb Gb Bb" },
                { "E minor", "E G B" },
                { "F minor", "F Ab C" },
                { "F# minor", "F# A C#" },
                { "Gb minor", "Gb Bbb Db" },
                { "G minor", "G Bb D" },
                { "G# minor", "G# B D#" },
                { "Ab minor", "Ab Cb Eb" },
                { "A minor", "A C E" },
                { "A# minor", "A# C# E#" },
                { "Bb minor", "Bb Db F" },
                { "B minor", "B D F#" },
            };
		}
	}
}