using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.CoreAudioApi;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;

namespace NAudioTesting
{
    class WavePlayer
    {
        AudioHandler audioHandler;
        ISampleProvider providedWave;

        public int pitch = 0;
        public int soundType = 0;
        public double duration = 5;
        public bool limitedDuration = false;

        public WavePlayer(AudioHandler handler)
        {
            audioHandler = handler;
        }
        public void playWave()
        {
            SignalGenerator sineWave = new SignalGenerator(audioHandler.output.OutputWaveFormat.SampleRate, audioHandler.output.OutputWaveFormat.Channels)
            {
                Gain = 0.2,
                Frequency = pitch,
                Type = (SignalGeneratorType)soundType,
                SweepLengthSecs = .5,
                FrequencyEnd = pitch * 2
            };
            if(providedWave != null)
            {
                audioHandler.removeInputFromMixer(providedWave);
            }
            if (limitedDuration)
                providedWave = sineWave.Take(TimeSpan.FromSeconds(duration));
            else
                providedWave = sineWave;
            audioHandler.addInputToMixer(providedWave);
            //Might have to make a custom class and override the read functionality?
        }
    }
}
