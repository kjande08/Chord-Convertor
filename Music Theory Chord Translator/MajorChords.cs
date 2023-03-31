using System;
using System.Collections.Generic;
namespace Music_Theory_Chord_Translator
{
    public class MajorChords : MinorChords
    {
        public static Dictionary<string, string> MajChords { get; set; }

        static MajorChords()
        {
            MajChords = new Dictionary<string, string>(StringComparer.InvariantCultureIgnoreCase)
                {
                    { "C Major", "C E G" },
                    { "C# Major", "C# E# G#" },
                    { "Db Major", "Db Fb Ab" },
                    { "D Major", "D F# A" },
                    { "D# Major", "D# Fx A#"},
                    { "Eb Major", "Eb G Bb" },
                    { "E Major", "E G# B" },
                    { "F Major", "F A C" },
                    { "F# Major", "F# A# C#" },
                    { "Gb Major", "Gb Bb Db" },
                    { "G Major", "G B D" },
                    { "G# Major", "G# B# D#" },
                    { "Ab Major", "Ab C Eb" },
                    { "A Major", "A C# E" },
                    { "A# Major", "A# Cx E#" },
                    { "Bb Major", "Bb D F" },
                    { "B Major", "B D# F#" },
                };
            }
        }
    }