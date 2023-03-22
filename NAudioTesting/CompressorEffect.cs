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
    class CompressorEffect : SoundModifier
    {
        public WaveFormat standardFormat;
        public AudioHandler audioHandler;
        public CompressorEffect(AudioHandler audioHandler)
        {
            this.audioHandler = audioHandler;
            standardFormat = audioHandler.mixerProvider.WaveFormat;
        }
        public ISampleProvider applyEffect(ISampleProvider input)
        {
            IWaveProvider tempProvider;
            tempProvider = new MediaFoundationResampler(input.ToWaveProvider(), new WaveFormat(standardFormat.SampleRate/10, 4, standardFormat.Channels));

            return new MediaFoundationResampler(tempProvider, standardFormat).ToSampleProvider();
        }
    }
}
