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
        BufferSaver bufferSaver;

        public BufferSaverModifier(AudioHandler audioHandler)
        {
            this.audioHandler = audioHandler;
        }
        public ISampleProvider applyEffect(ISampleProvider input)
        {
            bufferSaver = new BufferSaver(input);
            return bufferSaver;
        }
    }
}
