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
using NAudio.Dmo.Effect;

namespace NAudioTesting
{
    class EchoEffect : SoundModifier
    {
        public DmoEffectWaveProvider<DmoEcho, DmoEcho.Params> echoEffect;
        public ISampleProvider applyEffect(ISampleProvider input)
        {
            echoEffect = new DmoEffectWaveProvider<DmoEcho, DmoEcho.Params>(input.ToWaveProvider());
            //Applying this currently causes no audio to be fed through
            return echoEffect.ToSampleProvider();
        }
    }
}
