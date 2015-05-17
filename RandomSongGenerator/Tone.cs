using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomSongGenerator
{
    /// <summary>
    /// Define the frequencies of notes in an octave, as well as  silence (rest). 
    /// </summary>
    public enum Tone
    {
        REST    = 0,
        GbelowC = 196,
        A       = 220,
        Asharp  = 233,
        B       = 247,
        C       = 262,
        Csharp  = 277,
        D       = 294,
        Dsharp  = 311,
        E       = 330,
        F       = 349,
        Fsharp  = 370,
        G       = 392,
        Gsharp  = 415
    }
}
