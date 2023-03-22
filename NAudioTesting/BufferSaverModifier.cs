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
    class BufferSaverModifier : SoundModifier
    {
        public BufferSaver bufferSaver;
        AudioHandler handler;

        public BufferSaverModifier(AudioHandler audioHandler)
        {
            handler = audioHandler;
        }
        public ISampleProvider applyEffect(ISampleProvider input)
        {
            bufferSaver = new BufferSaver(input.ToWaveProvider());
            return bufferSaver.ToSampleProvider();
        }
    }
}
