using System;
namespace Music_Theory_Chord_Translator
{
	public class MinMajSeventhChords : HalfDiminishedSeventhChords
	{
        public static Dictionary<string, string> MinMajChords { get; set; }

        static MinMajSeventhChords()
        {
            MinMajChords = new Dictionary<string, string>(StringComparer.InvariantCultureIgnoreCase)
            {

                { "C mM Seventh", "C Eb G Bb" },
                { "C# mM Seventh", "C# E G# B" },
                { "Db mM Seventh", "Db Fbb Ab Cb" },
                { "D mM Seventh", "D F A C" },
                { "D# mM Seventh", "D# F# A# C#" },
                { "Eb mM Seventh", "Eb Gb Bb Db" },
                { "E mM Seventh", "E G B D" },
                { "F mM Seventh", "F Ab C Eb" },
                { "F# mM Seventh", "F# A C# E" },
                { "Gb mM Seventh", "Gb Bbb Db Fb" },
                { "G mM Seventh", "G Bb D F" },
                { "G# mM Seventh", "G# B D# F#" },
                { "Ab mM Seventh", "Ab Cb Eb Gb" },
                { "A mM Seventh", "A C E G" },
                { "A# mM Seventh", "A# C# E# G#" },
                { "Bb mM Seventh", "Bb Db F Ab" },
                { "B mM Seventh", "B D F# A" },
            };
        }
    }
}