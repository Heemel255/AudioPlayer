using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;

namespace AudioEditor
{
    class AudioFile
    {
        private String path;

        private WaveOut audioOutput;
        private MeteringSampleProvider msp;
        private AudioFileReader audio;
        
        private float volume;
        public double Pace { get; set; }

        public AudioFile(String p)
        {
            path = p;

            Pace = 1.0;
            volume = 0;

            try
            {
                audioOutput = new WaveOut();

                audio = new AudioFileReader(path);

                msp = new MeteringSampleProvider(audio);
                msp.StreamVolume += Msp_StreamVolume;

                audioOutput.Init(new SampleToWaveProvider(msp));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Source);
            }
        }

        private void Msp_StreamVolume(object sender, StreamVolumeEventArgs e)
        {
            //get volume of first channel as a percentage
            volume = e.MaxSampleValues[0];
        }

        public float GetVolume()
        {
            return volume;
        }

        public double GetCurrentTime()
        {
            return audio.CurrentTime.TotalSeconds;
        }

        public void Play()
        {
            audioOutput.Play();
        }

        public void Stop()
        {
            audioOutput.Stop();
        }

        //start from the beginning of file, time = 0
        public void Reset()
        {
            audio.CurrentTime = TimeSpan.FromSeconds(0.0);
        }

        //change time of file
        public void ChangeTime(int time)
        {
            audio.CurrentTime = TimeSpan.FromSeconds(time);
        }

        public void Close()
        {
            audio.Dispose();
            audioOutput.Dispose();
        }

        //returns time of audio in seconds
        public int GetTotalTime()
        {
            return (int)audio.TotalTime.TotalSeconds;
        }

        //adjust based on change to the skip trackbar (needs adjustment)
        //audio movies forward by pace, if pace = 2, then audio will play every other second moving the track faster
        public void SetSpeed()
        {
            if(Pace != 1.0)
            {

                TimeSpan audioTime = audio.CurrentTime;

                int q = (int)((Pace - 1.0) * 1000.0);
                TimeSpan addToAudio = new TimeSpan(0, 0, 0, 0, q);

                TimeSpan newTime = audioTime + addToAudio;

                if (newTime.TotalMilliseconds > audio.TotalTime.TotalMilliseconds)
                {
                    audio.CurrentTime = TimeSpan.FromSeconds(0.0);
                }
                else
                {
                    audio.CurrentTime = newTime;
                }
            }
        }
    }
}
