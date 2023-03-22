using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;
using NAudio.Dsp;
using NAudio;
using NAudio.Utils;

namespace NAudioTesting
{
    class ClipCapturer
    {
        AudioHandler audioHandler;
        public float clipLength = 30;
        ISampleProvider savedBuffer;
        ISampleProvider liveBuffer
        {
            get
            {
                //Maybe make another mixer for buffers or something
                return audioHandler.mixerProvider.Take(TimeSpan.FromSeconds(clipLength));
                //Will need to use skip to get to just the last 30 seconds
            }
        }
        public bool recording = false;

        public ClipCapturer(AudioHandler audioHandler)
        {
            this.audioHandler = audioHandler;
            //visualizerAmplitudes = new (int min, int max)[(int)((audioHandler.mixerProvider.WaveFormat.SampleRate * bufferLength) + 0.5f)];
            
        }//Needs to not capture itself
        public void stopRecording()
        {
            recording = false;
            //savedBuffer = liveBuffer;
            //if (savedBuffer != null)
            //{
            //    GridElements.TempFilePlayerBlock newElement = new GridElements.TempFilePlayerBlock();
            //    MainForm.main.ToolsContainer.Controls.Add(newElement);
            //    newElement.filePlayer.setFile(audioHandler.finalOutput.exportBuffer());

            //}   //audioHandler.addInputToMixer(savedBuffer);//Need to change this to make a temp file player instead, as this causes a crash
        }
        public void saveRecording()
        {
            GridElements.TempFilePlayerBlock newBlock = new GridElements.TempFilePlayerBlock();
            newBlock.FilePlayer.fileReader = new LoopWrapper(audioHandler.finalOutput.exportBuffer());
            MainForm.main.ToolsContainer.Controls.Add(newBlock);
            newBlock.FileVisualizer.generateMap();
            newBlock.FileVisualizer.WaveStream = newBlock.FilePlayer.getWaveStream();
            newBlock.FileVisualizer.stream = newBlock.FilePlayer.fileReader;
            newBlock.FileVisualizer.generateMap();
            newBlock.FileVisualizer.Refresh();
        }
        public void startRecording()
        {
            recording = true;
            //audioHandler.removeInputFromMixer(savedBuffer);
        }
        
        
    }
}
