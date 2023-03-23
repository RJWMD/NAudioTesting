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
        public class TempFilePlayer : FilePlayer
        {

            public TempFilePlayer(AudioHandler handler) : base(handler)
            {

            }

            public override void playFile()
            {
                if (fileReader == null)
                    return;
                if (providedWave != null && !stackAudio)
                    audioHandler.removeInputFromMixer(providedWave);
                providedWave = new MediaFoundationResampler(fileReader, Program.audioHandler.mixerProvider.WaveFormat).ToSampleProvider();
                //The above works because it is the resampler, not the reader
                audioHandler.addInputToMixer(providedWave);
            }
            public void saveToFile(string path)
            {//Allow for trimming the file before saving
                using (WaveFileWriter writer = new WaveFileWriter(path, fileReader.WaveFormat))
                {
                    byte[] buffer = new byte[(int)fileReader.Length];
                    fileReader.Position = 0;
                    fileReader.Read(buffer, 0, buffer.Length);
                    writer.Write(buffer, 0, buffer.Length);
                    writer.Flush();
                }
            }
            public void setFile(WaveStream source)
            {
                //be sure to give it a copy only
                fileReader = new LoopWrapper(source);
            }
            public override WaveStream getWaveStream()
            {
                System.IO.MemoryStream returnStream = new System.IO.MemoryStream();
                fileReader.CopyTo(returnStream);
                return new RawSourceWaveStream(returnStream, fileReader.WaveFormat);
            }

            public override void Dispose()
            {
                base.Dispose();   
            }
        }

    }
}
