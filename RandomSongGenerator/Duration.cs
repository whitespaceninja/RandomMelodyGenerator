using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomSongGenerator
{
    /// <summary>
    /// Define the duration of a note in units of milliseconds. 
    /// </summary>
    public enum Duration
    {
        WHOLE       = 4000, //60 bpm
        HALF        = WHOLE / 2,
        QUARTER     = HALF / 2,
        EIGHTH      = QUARTER / 2,
        SIXTEENTH   = EIGHTH / 2,
    }
}
