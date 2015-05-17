namespace RandomSongGenerator
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonMaryHadALittleLamb = new System.Windows.Forms.Button();
            this.buttonHotCrossBuns = new System.Windows.Forms.Button();
            this.tempoInput = new System.Windows.Forms.NumericUpDown();
            this.labelTempo = new System.Windows.Forms.Label();
            this.buttonRandom = new System.Windows.Forms.Button();
            this.labelPlay = new System.Windows.Forms.Label();
            this.labelMinMax = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tempoInput)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonMaryHadALittleLamb
            // 
            this.buttonMaryHadALittleLamb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMaryHadALittleLamb.Location = new System.Drawing.Point(68, 84);
            this.buttonMaryHadALittleLamb.Name = "buttonMaryHadALittleLamb";
            this.buttonMaryHadALittleLamb.Size = new System.Drawing.Size(293, 48);
            this.buttonMaryHadALittleLamb.TabIndex = 0;
            this.buttonMaryHadALittleLamb.Text = "Mary had a Little Lamb";
            this.buttonMaryHadALittleLamb.UseVisualStyleBackColor = true;
            this.buttonMaryHadALittleLamb.Click += new System.EventHandler(this.buttonMaryHadALittleLamb_Click);
            // 
            // buttonHotCrossBuns
            // 
            this.buttonHotCrossBuns.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHotCrossBuns.Location = new System.Drawing.Point(68, 158);
            this.buttonHotCrossBuns.Name = "buttonHotCrossBuns";
            this.buttonHotCrossBuns.Size = new System.Drawing.Size(293, 44);
            this.buttonHotCrossBuns.TabIndex = 1;
            this.buttonHotCrossBuns.Text = "Hot Cross Buns";
            this.buttonHotCrossBuns.UseVisualStyleBackColor = true;
            this.buttonHotCrossBuns.Click += new System.EventHandler(this.buttonHotCrossBuns_Click);
            // 
            // tempoInput
            // 
            this.tempoInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tempoInput.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.tempoInput.Location = new System.Drawing.Point(458, 84);
            this.tempoInput.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.tempoInput.Name = "tempoInput";
            this.tempoInput.Size = new System.Drawing.Size(180, 35);
            this.tempoInput.TabIndex = 3;
            // 
            // labelTempo
            // 
            this.labelTempo.AutoSize = true;
            this.labelTempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelTempo.Location = new System.Drawing.Point(452, 29);
            this.labelTempo.Name = "labelTempo";
            this.labelTempo.Size = new System.Drawing.Size(149, 32);
            this.labelTempo.TabIndex = 4;
            this.labelTempo.Text = "at tempo...";
            this.labelTempo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonRandom
            // 
            this.buttonRandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRandom.Location = new System.Drawing.Point(68, 234);
            this.buttonRandom.Name = "buttonRandom";
            this.buttonRandom.Size = new System.Drawing.Size(293, 50);
            this.buttonRandom.TabIndex = 5;
            this.buttonRandom.Text = "Random Shit";
            this.buttonRandom.UseVisualStyleBackColor = true;
            this.buttonRandom.Click += new System.EventHandler(this.buttonRandom_Click);
            // 
            // labelPlay
            // 
            this.labelPlay.AutoSize = true;
            this.labelPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelPlay.Location = new System.Drawing.Point(68, 29);
            this.labelPlay.Name = "labelPlay";
            this.labelPlay.Size = new System.Drawing.Size(204, 32);
            this.labelPlay.TabIndex = 6;
            this.labelPlay.Text = "I want to play...";
            // 
            // labelMinMax
            // 
            this.labelMinMax.AutoSize = true;
            this.labelMinMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.labelMinMax.Location = new System.Drawing.Point(454, 131);
            this.labelMinMax.Name = "labelMinMax";
            this.labelMinMax.Size = new System.Drawing.Size(136, 20);
            this.labelMinMax.TabIndex = 7;
            this.labelMinMax.Text = "Min: 60   Max: 300";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 330);
            this.Controls.Add(this.labelMinMax);
            this.Controls.Add(this.labelPlay);
            this.Controls.Add(this.buttonRandom);
            this.Controls.Add(this.labelTempo);
            this.Controls.Add(this.tempoInput);
            this.Controls.Add(this.buttonHotCrossBuns);
            this.Controls.Add(this.buttonMaryHadALittleLamb);
            this.Name = "MainForm";
            this.Text = "Melody Generator";
            ((System.ComponentModel.ISupportInitialize)(this.tempoInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonMaryHadALittleLamb;
        private System.Windows.Forms.Button buttonHotCrossBuns;
        private System.Windows.Forms.NumericUpDown tempoInput;
        private System.Windows.Forms.Label labelTempo;
        private System.Windows.Forms.Button buttonRandom;
        private System.Windows.Forms.Label labelPlay;
        private System.Windows.Forms.Label labelMinMax;
    }
}

