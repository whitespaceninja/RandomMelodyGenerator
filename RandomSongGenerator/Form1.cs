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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            var p1 = new System.Media.Windows.MediaPlayer();
            p1.Open(new System.Uri(@"C:\windows\media\tada.wav"));
            p1.Play();

            // this sleep is here just so you can distinguish the two sounds playing simultaneously
            System.Threading.Thread.Sleep(500);

            var p2 = new System.Windows.Media.MediaPlayer();
            p2.Open(new System.Uri(@"C:\windows\media\tada.wav"));
            p2.Play();

            new System.Threading.Thread(() =>
            {
                var c = new System.Windows.Media.MediaPlayer();
                c.Open(new System.Uri(@"C:\windows\media\tada.wav"));
                c.Play();
            }).Start();

            System.Threading.Thread.Sleep(500);

            new System.Threading.Thread(() =>
            {
                var c = new System.Windows.Media.MediaPlayer();
                c.Open(new System.Uri(@"C:\windows\media\tada.wav"));
                c.Play();
            }).Start();
        }

        
        
    }
}
