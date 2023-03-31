using System;
namespace Music_Theory_Chord_Translator
{
    public class MajMajSeventhChords : DominantSeventhChords
    {
        public static Dictionary<string, string> MajMajChords { get; set; }

        static MajMajSeventhChords()
        {
            MajMajChords = new Dictionary<string, string>(StringComparer.InvariantCultureIgnoreCase)
            {

                { "C MM Seventh", "C E G B" },
                { "C# MM Seventh", "C# E# G# B#" },
                { "Db MM Seventh", "Db Fb Ab C" },
                { "D MM Seventh", "D F# A C#" },
                { "D# MM Seventh", "D# Fx A# Cx" },
                { "Eb MM Seventh", "Eb G Bb D" },
                { "E MM Seventh", "E G# B D#" },
                { "F MM Seventh", "F A C E" },
                { "F# MM Seventh", "F# A# C# E#" },
                { "Gb MM Seventh", "Gb Bb Db F" },
                { "G MM Seventh", "G B D F#" },
                { "G# MM Seventh", "G# B# D# Fx" },
                { "Ab MM Seventh", "Ab C Eb G" },
                { "A MM Seventh", "A C# E G#" },
                { "A# MM Seventh", "A# Cx E# Gx" },
                { "Bb MM Seventh", "Bb D F A" },
                { "B MM Seventh", "B D# F# A#" },
            };
        }
    }
}