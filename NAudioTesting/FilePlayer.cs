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
    namespace GridElements
    {
        class FilePlayer
        {
            ISampleProvider providedWave;
            AudioHandler audioHandler;
            string filePath;
            MediaFoundationReader fileReader;
            public bool stackAudio = false;
            public bool loopAudio = false;

            public FilePlayer(AudioHandler handler)
            {
                audioHandler = handler;
            }
            public void setFile(string path)
            {
                filePath = path;
                fileReader = new MediaFoundationReader(filePath);
            }
            public void playFile()//Add looping and trimming
            {
                if (fileReader == null)
                    return;
                fileReader.Position = 0;
                if(providedWave != null && !stackAudio)
                    audioHandler.removeInputFromMixer(providedWave);
                providedWave = new MediaFoundationResampler(fileReader, Program.audioHandler.mixerProvider.WaveFormat).ToSampleProvider();
                //if(loopAudio)
                audioHandler.addInputToMixer(providedWave);
            }
            public WaveStream getWaveStream()
            {
                return new MediaFoundationReader(filePath);
            }
        }
    }
}
