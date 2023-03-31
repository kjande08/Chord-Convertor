using System;
namespace Music_Theory_Chord_Translator
{
    public class AllChords : MajorChords
    {
        public static Dictionary<string, string> Chords { get; set; }

        static AllChords()
        {
            Chords = new Dictionary<string, string>(StringComparer.InvariantCultureIgnoreCase);
            {
                foreach (var kvp in MajChords)
                {
                    Chords.Add(kvp.Key, kvp.Value);
                }

                foreach (var kvp in MinChords)
                {
                    Chords.Add(kvp.Key, kvp.Value);
                }

                foreach (var kvp in HDimChords)
                {
                    Chords.Add(kvp.Key, kvp.Value);
                }

                foreach (var kvp in DimChords)
                {
                    Chords.Add(kvp.Key, kvp.Value);
                }

                foreach (var kvp in DomChords)
                {
                    Chords.Add(kvp.Key, kvp.Value);
                }

                foreach (var kvp in MinMajChords)
                {
                    Chords.Add(kvp.Key, kvp.Value);
                }

                foreach (var kvp in MajMajChords)
                {
                    Chords.Add(kvp.Key, kvp.Value);
                }
            };
        }
    }
}

