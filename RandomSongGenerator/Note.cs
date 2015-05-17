using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomSongGenerator
{
    // Define a note as a frequency (tone) and the amount of  
    // time (duration) the note plays. 
    public struct Note
    {
        Tone toneVal;
        Duration durVal;

        // Define a constructor to create a specific note. 
        public Note(Tone frequency, Duration time)
        {
            toneVal = frequency;
            durVal = time;
        }

        // Define properties to return the note's tone and duration. 
        public Tone NoteTone { get { return toneVal; } }
        public Duration NoteDuration { get { return durVal; } }
    }

}
