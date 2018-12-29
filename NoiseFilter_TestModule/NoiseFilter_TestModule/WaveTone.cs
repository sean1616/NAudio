using System;
using System.Windows.Forms;

using NAudio.Wave;

namespace NoiseFilter_TestModule
{
    public class WaveTone : WaveStream
    {
        private double frequency;
        private double amplitude;
        private double time;

        public WaveTone(double f, double a)
        {
            this.time = 0;
            this.frequency = f;
            this.amplitude = a;
        }

        public override long Position
        {
            get;
            set;
        }
                
        public override long Length
        {
            get { return long.MaxValue; }
        }

        public override WaveFormat WaveFormat
        {
            get { return new WaveFormat(44100, 16, 1); }
        }

        public override int Read(byte[] buffer, int offset, int count)
        {
            int samples = count / 2;  //Sample數為總數的一半
            for (int i = 0; i < samples; i++)
            {
                double sine = amplitude * Math.Sin(Math.PI * 2 * frequency * time);  //決定波型，此處為sine波
                time += 1.0 / 44100;   //Sample rate 的倒數
                short truncated = (short)Math.Round(sine * (Math.Pow(2, 15) - 1));   //
                buffer[i * 2] = (byte)(truncated & 0x00ff);
                buffer[i * 2 + 1] = (byte)((truncated & 0xff00) >> 8);
            }

            return count;
        }
    }
}
