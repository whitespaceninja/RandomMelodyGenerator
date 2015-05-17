using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RandomSongGenerator
{
    class AudioPlayer
    {
        /// <summary>
        /// Maximum tempo that we support
        /// </summary>
        public const int MAX_TEMPO = 300;

        /// <summary>
        /// Minimum tempo that we support
        /// </summary>
        public const int MIN_TEMPO = 60;

        /// <summary>
        /// Plays an array of Notes at the given tempo
        /// </summary>
        public void Play(Note[] tune, int tempo)
        {
            foreach (Note n in tune)
            {
                Play(n, tempo);
            }
        }

        /// <summary>
        /// Plays a single Note at the given tempo
        /// </summary>
        public void Play(Note note, int tempo)
        {
            if (note.NoteTone == Tone.REST)
                Thread.Sleep(ConvertDuration(note.NoteDuration, tempo));
            else
                Console.Beep((int)note.NoteTone, ConvertDuration(note.NoteDuration, tempo));
        }

        /// <summary>
        /// Translates an original duration into the new tempo specified
        /// </summary>
        /// <returns>Milliseconds of the duration</returns>
        private int ConvertDuration(Duration originalDuration, int userTempo)
        {
            // user putting in 120 bpm will give us 2.0 since it is twice as fast
            float tempoRatio = userTempo / 60.0f;

            // reverse the number because twice as fast is half the duration (change 2.0 to 0.5)
            float multiplier = 1 / tempoRatio;

            // our new duration in milliseconds
            int milliseconds = (int)((int)originalDuration * multiplier);

            return milliseconds;
        }
    }
}
