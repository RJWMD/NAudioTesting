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
    class SpeakerCapturer
    {
        public AudioHandler audioHandler;
        public WasapiLoopbackCapture speakerCapturer;
        public int deviceID;
        public ISampleProvider providedSample;
        public static int fftLength = 4096;
        public SampleAggregator aggregator = new SampleAggregator(fftLength);
        public event EventHandler<FftEventArgs> fftFinished
        {
            add
            {
                //aggregator.FftCalculated += value;//Currently removed due to freezing with this
            }
            remove
            {
                //aggregator.FftCalculated -= value;
            }
        }

        public SpeakerCapturer(AudioHandler audioHandler)
        {
            this.audioHandler = audioHandler;
            audioHandler.stopAllSound += reapplySpeaker;
            audioHandler.appClosed += stopRecording;
            //aggregator.FftCalculated += FftCalculated;
            aggregator.PerformFFT = true;
            //aggregator.FftCalculated += fftFinished;
        }

        public void reapplySpeaker(object sender, EventArgs args)
        {
            //speakerCapturer?.StopRecording();
            //speakerCapturer = new WasapiLoopbackCapture(audioHandler.getRenderDevice(deviceID));
            //speakerCapturer.StartRecording();
            //addSpeakerCaptureToMixer();
            removeSpeakerCaptureFromMixer();
            setSpeakerCapture(deviceID, true);
        }

        public void addSpeakerCaptureToMixer()
        {
            IWaveProvider providedWave = new WaveInProvider(speakerCapturer);
            providedSample = new MediaFoundationResampler(providedWave, audioHandler.mixerProvider.WaveFormat).ToSampleProvider();
            audioHandler.addInputToMixer(providedSample);
            //speakerCapturer.DataAvailable += visualizeAudio;
        }
        public void setSpeakerCapture(int deviceNum, bool refreshMixer = false)
        {
            deviceID = deviceNum;
            speakerCapturer?.StopRecording();
            speakerCapturer = new WasapiLoopbackCapture(audioHandler.getRenderDevice(deviceNum));
            //speakerCapturer.RecordingStopped += recordingStopped;
            speakerCapturer.StartRecording();
            if (refreshMixer && providedSample != null)
            {
                removeSpeakerCaptureFromMixer();
            }
            if (providedSample == null || refreshMixer)
                addSpeakerCaptureToMixer();
        }

        public void removeSpeakerCaptureFromMixer()
        {
            audioHandler.removeInputFromMixer(providedSample);
        }
        //public void recordingStopped(object sender, StoppedEventArgs args)
        //{
        //    string reason = args.Exception.Message;
        //}
        //public void FftCalculated(object sender, FftEventArgs args)
        //{
        //    Complex[] results = args.Result;
        //}
        public void stopRecording(object sender, EventArgs args)
        {
            
            speakerCapturer.StopRecording();
            speakerCapturer.Dispose();
        }
        
    }
}
