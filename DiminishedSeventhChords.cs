using System;
namespace Music_Theory_Chord_Translator
{
    public class DiminishedSeventhChords
    {
        public static Dictionary<string, string> DimChords { get; set; }

        static DiminishedSeventhChords()
        {
            DimChords = new Dictionary<string, string>(StringComparer.InvariantCultureIgnoreCase)
            {

                { "C diminished", "C Eb Gb Bbb" },
                { "C# diminished", "C# E G Bb" },
                { "Db diminished", "Db Fbb Abb Cbb" },
                { "D diminished", "D F Ab Cb" },
                { "D# diminished", "D# F# A C" },
                { "Eb diminished", "Eb Gb Bbb Dbb" },
                { "E diminished", "E G Bb Db" },
                { "F diminished", "F Ab Cb Ebb" },
                { "F# diminished", "F# A C Eb" },
                { "Gb diminished", "Gb Bbb Dbb Fbb" },
                { "G diminished", "G Bb Db Fb" },
                { "G# diminished", "G# B D F" },
                { "Ab diminished", "Ab Cb Ebb Gbb" },
                { "A diminished", "A C Eb Gb" },
                { "A# diminished", "A# C# E G" },
                { "Bb diminished", "Bb Db Fb Abb" },
                { "B diminished", "B D F Ab" },
            };
        }
    }
}
