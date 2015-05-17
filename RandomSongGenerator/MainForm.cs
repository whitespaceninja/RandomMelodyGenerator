using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;





namespace RandomSongGenerator
{
    public partial class MainForm : Form
    {
        MelodyGenerator melodyGenerator = new MelodyGenerator();
        AudioPlayer audioPlayer = new AudioPlayer();

        public MainForm()
        {
            InitializeComponent();

            // specify our min/max input values
            tempoInput.Maximum = AudioPlayer.MAX_TEMPO;
            tempoInput.Minimum = AudioPlayer.MIN_TEMPO;
        }

        private void buttonMaryHadALittleLamb_Click(object sender, EventArgs e)
        {
            audioPlayer.Play(PreLoadedSongs.Mary, (int)tempoInput.Value);
        }

        private void buttonHotCrossBuns_Click(object sender, EventArgs e)
        {
            audioPlayer.Play(PreLoadedSongs.HotCrossBuns, (int)tempoInput.Value);
        }

        private void buttonRandom_Click(object sender, EventArgs e)
        {
            // Play random notes forever. User will have to go to the task bar to close this app
            // until it is refactored to play on a separate thread.
            while (true)
            {
                audioPlayer.Play(melodyGenerator.GetRandomNote(), (int)tempoInput.Value);
            }
        }
    }
}
