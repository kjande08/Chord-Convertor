using System;
namespace Music_Theory_Chord_Translator
{
	public class DominantSeventhChords : MinMajSeventhChords
	{
        public static Dictionary<string, string> DomChords { get; set; }

        static DominantSeventhChords()
        {
            DomChords = new Dictionary<string, string>(StringComparer.InvariantCultureIgnoreCase)
            {

                { "C Dominant Seventh", "C E G Bb" },
                { "C# Dominant Seventh", "C# E# G# B" },
                { "Db Dominant Seventh", "Db Fb Ab Cb" },
                { "D Dominant Seventh", "D F# A C" },
                { "D# Dominant Seventh", "D# Fx A# C#" },
                { "Eb Dominant Seventh", "Eb G Bb Db" },
                { "E Dominant Seventh", "E G# B D" },
                { "F Dominant Seventh", "F A C Eb" },
                { "F# Dominant Seventh", "F# A# C# E" },
                { "Gb Dominant Seventh", "Gb Bb Db Fb" },
                { "G Dominant Seventh", "G B D F" },
                { "G# Dominant Seventh", "G# B# D# F#" },
                { "Ab Dominant Seventh", "Ab C Eb Gb" },
                { "A Dominant Seventh", "A C# E G" },
                { "A# Dominant Seventh", "A# Cx E# G#" },
                { "Bb Dominant Seventh", "Bb D F Ab" },
                { "B Dominant Seventh", "B D# F# A" },
            };
        }
    }
}