using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio;
using NAudio.CoreAudioApi;
using NAudio.Wave;
using NAudio.Utils;
using NAudio.Mixer;
using NAudio.Dmo;
using NAudio.Dsp;
using NAudio.Gui;
using NAudio.Wave.SampleProviders;

namespace NAudioTesting
{
    class AudioProcessor : ISampleProvider
    {
        public MixingSampleProvider mixerProvider;
        public List<WaveIn> inputs;

        public WaveFormat WaveFormat
        {
            get
            {
                return mixerProvider.WaveFormat;
            }
        }
        public void addLiveInput()
        {
            inputs[0].DataAvailable += dataInFromMics;
        }
        public void dataInFromMics(object sender, WaveInEventArgs args)
        {
            
        }
        public void addRecorderInput(ISampleProvider newInput)
        {
            mixerProvider.AddMixerInput(newInput);
        }
        public int Read(float[] buffer, int offset, int count)
        {
            return mixerProvider.Read(buffer, offset, count);
        }
    }
}
