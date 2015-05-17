using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomSongGenerator
{
    static class PreLoadedSongs
    {
        // Declare the first few notes of the song, "Mary Had A Little Lamb".
        public static Note[] Mary = 
        {
            new Note(Tone.B, Duration.QUARTER),
            new Note(Tone.A, Duration.QUARTER),
            new Note(Tone.GbelowC, Duration.QUARTER),
            new Note(Tone.A, Duration.QUARTER),
            new Note(Tone.B, Duration.QUARTER),
            new Note(Tone.B, Duration.QUARTER),
            new Note(Tone.B, Duration.HALF),
            
            new Note(Tone.A, Duration.QUARTER),
            new Note(Tone.A, Duration.QUARTER),
            new Note(Tone.A, Duration.HALF),
            
            new Note(Tone.B, Duration.QUARTER),
            new Note(Tone.D, Duration.QUARTER),
            new Note(Tone.D, Duration.HALF)
        };

        // Declare the first few notes of the song, "Mary Had A Little Lamb".
        public static Note[] HotCrossBuns = 
        {
            new Note(Tone.E, Duration.QUARTER),
            new Note(Tone.D, Duration.QUARTER),
            new Note(Tone.C, Duration.HALF),
            
            new Note(Tone.E, Duration.QUARTER),
            new Note(Tone.D, Duration.QUARTER),
            new Note(Tone.C, Duration.HALF),

            new Note(Tone.C, Duration.EIGHTH),
            new Note(Tone.C, Duration.EIGHTH),
            new Note(Tone.C, Duration.EIGHTH),
            new Note(Tone.C, Duration.EIGHTH),

            new Note(Tone.D, Duration.EIGHTH),
            new Note(Tone.D, Duration.EIGHTH),
            new Note(Tone.D, Duration.EIGHTH),
            new Note(Tone.D, Duration.EIGHTH),

            new Note(Tone.E, Duration.QUARTER),
            new Note(Tone.D, Duration.QUARTER),
            new Note(Tone.C, Duration.HALF)
        };
    }
}
