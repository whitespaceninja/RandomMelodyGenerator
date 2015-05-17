using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace RandomSongGenerator
{
    class MelodyGenerator
    {
        Random rand = new Random();

        /// <summary>
        /// Gets a random Tone, including REST. All Tones are equally likely to be returned.
        /// </summary>
        public Tone GetRandomTone()
        {
            int toneRand = rand.Next(0, 14);
            Tone tone = Tone.REST;
            switch (toneRand)
            {
                case 0: tone = Tone.REST; break;
                case 1: tone = Tone.GbelowC; break;
                case 2: tone = Tone.GbelowC; break;
                case 3: tone = Tone.A; break;
                case 4: tone = Tone.Asharp; break;
                case 5: tone = Tone.B; break;
                case 6: tone = Tone.C; break;
                case 7: tone = Tone.Csharp; break;
                case 8: tone = Tone.D; break;
                case 9: tone = Tone.Dsharp; break;
                case 10: tone = Tone.E; break;
                case 11: tone = Tone.F; break;
                case 12: tone = Tone.Fsharp; break;
                case 13: tone = Tone.G; break;
                case 14: tone = Tone.Gsharp; break;
            }

            return tone;
        }

        /// <summary>
        /// Gets a random Duration. All Durations are equally likely to be returned.
        /// </summary>
        public Duration GetRandomDuration()
        {
            int durationRand = rand.Next(0, 4);
            Duration duration = Duration.WHOLE;
            switch (durationRand)
            {
                case 0: duration = Duration.WHOLE; break;
                case 1: duration = Duration.HALF; break;
                case 2: duration = Duration.QUARTER; break;
                case 3: duration = Duration.EIGHTH; break;
                case 4: duration = Duration.SIXTEENTH; break;
            }

            return duration;
        }

        /// <summary>
        /// Gets a random Note. All Durations and Tones are equally likely to be used.
        /// </summary>
        public Note GetRandomNote()
        {
            Tone tone = GetRandomTone();
            Duration duration = GetRandomDuration();
            Note note = new Note(tone, duration);
            return note;
        }
    }
}

