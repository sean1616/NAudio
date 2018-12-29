using System;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;
using NAudio.Wave;

namespace NoiseFilter_TestModule
{
    public partial class Form1 : Form
    {
        // MICROPHONE ANALYSIS SETTINGS
        private int RATE = 44100; // sample rate of the sound card
        private int BUFFERSIZE = (int)Math.Pow(2, 11); // must be a multiple of 2

        // prepare class objects
        public BufferedWaveProvider bwp;
        WaveTone tone;

        public Form1()
        {
            InitializeComponent();

            SetupGraphLabels();
            StartListeningToMicrophone();
            timerReplot.Enabled = true;
        }

        List<DirectSoundOut> outputs = new List<DirectSoundOut>();
        private DirectSoundOut output = null;
        private BlockAlignReductionStream stream = null;

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Tick += timer1_Tick;
            timer1.Interval = 5000;
            timer1.Enabled = true;

        }

        void AudioDataAvailable(object sender, WaveInEventArgs e)
        {
            bwp.AddSamples(e.Buffer, 0, e.BytesRecorded);
        }

        public void SetupGraphLabels()
        {
            scottPlotUC1.fig.labelTitle = "Microphone PCM Data";
            scottPlotUC1.fig.labelY = "Amplitude (PCM)";
            scottPlotUC1.fig.labelX = "Time (ms)";
            scottPlotUC1.Redraw();

            //scottPlotUC2.fig.labelTitle = "Microphone FFT Data";
            //scottPlotUC2.fig.labelY = "Power (raw)";
            //scottPlotUC2.fig.labelX = "Frequency (Hz)";
            //scottPlotUC2.Redraw();
        }

        public void StartListeningToMicrophone(int audioDeviceNumber = 0)
        {
            WaveIn wi = new WaveIn();
            wi.DeviceNumber = audioDeviceNumber;
            wi.WaveFormat = new NAudio.Wave.WaveFormat(RATE, 1);
            wi.BufferMilliseconds = (int)((double)BUFFERSIZE / (double)RATE * 1000.0);
            wi.DataAvailable += new EventHandler<WaveInEventArgs>(AudioDataAvailable);
            bwp = new BufferedWaveProvider(wi.WaveFormat);
            bwp.BufferLength = BUFFERSIZE * 2;
            bwp.DiscardOnBufferOverflow = true;
            try
            {
                wi.StartRecording();
            }
            catch
            {
                string msg = "Could not record from audio device!\n\n";
                msg += "Is your microphone plugged in?\n";
                msg += "Is it set as your default recording device?";
                MessageBox.Show(msg, "ERROR");
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // turn off the timer, take as long as we need to plot, then turn the timer back on
            timerReplot.Enabled = false;
            PlotLatestData();
            timerReplot.Enabled = true;
        }
        public int numberOfDraws = 0;
        public bool needsAutoScaling = true;
        public void PlotLatestData()
        {
            // check the incoming microphone audio
            int frameSize = BUFFERSIZE;
            var audioBytes = new byte[frameSize];
            bwp.Read(audioBytes, 0, frameSize);

            // return if there's nothing new to plot
            if (audioBytes.Length == 0)
                return;
            if (audioBytes[frameSize - 2] == 0)
                return;

            // incoming data is 16-bit (2 bytes per audio point)
            int BYTES_PER_POINT = 2;

            // create a (32-bit) int array ready to fill with the 16-bit data
            int graphPointCount = audioBytes.Length / BYTES_PER_POINT;

            // create double arrays to hold the data we will graph
            double[] pcm = new double[graphPointCount];
            double[] fft = new double[graphPointCount];
            double[] fftReal = new double[graphPointCount / 2];

            // populate Xs and Ys with double data
            for (int i = 0; i < graphPointCount; i++)
            {
                // read the int16 from the two bytes
                Int16 val = BitConverter.ToInt16(audioBytes, i * 2);

                // store the value in Ys as a percent (+/- 100% = 200%)
                pcm[i] = (double)(val) / Math.Pow(2, 16) * 200.0;
            }

            //// calculate the full FFT
            //fft = FFT(pcm);

            //// determine horizontal axis units for graphs
            double pcmPointSpacingMs = RATE / 1000;
            double fftMaxFreq = RATE / 2;
            double fftPointSpacingHz = fftMaxFreq / graphPointCount;

            //// just keep the real half (the other half imaginary)
            //Array.Copy(fft, fftReal, fftReal.Length);

            //// plot the Xs and Ys for both graphs
            scottPlotUC1.Clear();
            scottPlotUC1.PlotSignal(pcm, pcmPointSpacingMs, Color.Blue);
            //scottPlotUC2.Clear();
            //scottPlotUC2.PlotSignal(fftReal, fftPointSpacingHz, Color.Blue);

            //// optionally adjust the scale to automatically fit the data
            if (needsAutoScaling)
            {
                scottPlotUC1.AxisAuto();
                //scottPlotUC2.AxisAuto();
                needsAutoScaling = false;
            }

            ////scottPlotUC1.PlotSignal(Ys, RATE);

            //numberOfDraws += 1;
            //lblStatus.Text = $"Analyzed and graphed PCM and FFT data {numberOfDraws} times";

            //// this reduces flicker and helps keep the program responsive
            //Application.DoEvents();

        }
                
        private void Btn_Start_Tone_Click(object sender, EventArgs e)
        {
            if (outputs.Count == 0)
            {
                double freq = double.Parse(TxtBox_Frequency.Text);  //取得頻率設定值
                double amp = double.Parse(TxtBox_Amplitude.Text);   //取得振幅設定值

                if (output != null) output.Dispose();

                tone = new WaveTone(freq, amp);
                stream = new BlockAlignReductionStream(tone);

                output = new DirectSoundOut();
                output.Init(stream);
                output.Play();

                outputs.Add(output);
            }
            else
            {
                foreach (DirectSoundOut o in outputs) o.Play();
            }

            
        }

        private void Btn_Stop_Tone_Click(object sender, EventArgs e)
        {
            if (outputs.Count > 0)
            {
                foreach (DirectSoundOut o in outputs) { o.Stop(); }
            }
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

        private void autoScaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            needsAutoScaling = true;
        }

        private void Btn_Add_Tone_Click(object sender, EventArgs e)
        {
            double freq = double.Parse(TxtBox_Frequency.Text);  //取得頻率設定值
            double amp = double.Parse(TxtBox_Amplitude.Text);   //取得振幅設定值

            tone = new WaveTone(freq, amp);
            stream = new BlockAlignReductionStream(tone);
            
            output = new DirectSoundOut();
            outputs.Add(output);
            output.Init(stream);
            output.Play();
        }

        private void Btn_Clear_Tone_Click(object sender, EventArgs e)
        {
           outputs = new List<DirectSoundOut>();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            needsAutoScaling = true;
        }
    }
}
