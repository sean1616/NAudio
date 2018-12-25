using System;
using System.IO;
using System.Windows.Forms;

using NAudio.Wave;

namespace Tutorial9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private DirectSoundOut output = null;

        private BlockAlignReductionStream stream = null;

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Wave File (*.wav)|*.wav;";
            if (open.ShowDialog() != DialogResult.OK) return;

            WaveChannel32 wave = new WaveChannel32(new WaveFileReader(open.FileName));
            EffectStream effect = new EffectStream(wave);
            stream = new BlockAlignReductionStream(effect);
            for (int i = 0; i < wave.WaveFormat.Channels; i++) effect.Effects.Add(new Echo());

            output = new DirectSoundOut(200);
            output.Init(stream);
            output.Play();
        }
    }
}
