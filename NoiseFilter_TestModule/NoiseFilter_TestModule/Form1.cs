using System;
using System.Windows.Forms;
using NAudio.Wave;

namespace NoiseFilter_TestModule
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private DirectSoundOut output = null;
        private BlockAlignReductionStream stream = null;

        private void Btn_Start_Tone_Click(object sender, EventArgs e)
        {
            double freq = double.Parse(TxtBox_Frequency.Text);  //取得頻率設定值
            double amp = double.Parse(TxtBox_Amplitude.Text);   //取得振幅設定值

            WaveTone tone = new WaveTone(freq, amp);
            stream = new BlockAlignReductionStream(tone);

            output = new DirectSoundOut();
            output.Init(stream);
            output.Play();
        }

        private void Btn_Stop_Tone_Click(object sender, EventArgs e)
        {
            if (output != null) output.Stop();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (output != null)
            {
                output.Dispose();
                output = null;
            }
            if (stream != null)
            {
                stream.Dispose();
                stream = null;
            }
        }
    }
}
