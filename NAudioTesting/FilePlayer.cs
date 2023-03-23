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
        public class FilePlayer : IDisposable
        {
            protected ISampleProvider providedWave;
            protected AudioHandler audioHandler;
            string filePath;
            public LoopWrapper fileReader;
            public bool stackAudio = false;

            //public long position
            //{
            //    get { return fileReader.Position; }
            //    set { fileReader.Position = value; }
            //}
            public bool loopAudio
            {
                get
                {
                    if (fileReader != null)
                        return fileReader.looping;
                    else
                        return false;
                }
                set
                {
                    if (fileReader != null)
                        fileReader.looping = value;
                }
            }

            public FilePlayer(AudioHandler handler)
            {
                audioHandler = handler;
            }
            public virtual void setFile(string path)
            {
                filePath = path;
                fileReader = new LoopWrapper(new MediaFoundationReader(filePath));
            }
            public virtual void playFile()//Add looping and trimming
            {
                if (fileReader == null)
                    return;
                if(providedWave != null && !stackAudio)
                    audioHandler.removeInputFromMixer(providedWave);
                providedWave = new MediaFoundationResampler(fileReader, Program.audioHandler.mixerProvider.WaveFormat).ToSampleProvider();
                
                //if(loopAudio)
                
                audioHandler.addInputToMixer(providedWave);
            }
            /// <summary>
            /// Returns a new copy of the reader
            /// </summary>
            /// <returns></returns>
            public virtual WaveStream getWaveStream()
            {
                return new MediaFoundationReader(filePath);
            }

            public virtual void Dispose()
            {
                fileReader.DeleteStream();
                fileReader.Close();
                fileReader.Dispose();
                fileReader = null;
                audioHandler.removeInputFromMixer(providedWave);
                providedWave = null;
                
                
            }
        }
    }
}
