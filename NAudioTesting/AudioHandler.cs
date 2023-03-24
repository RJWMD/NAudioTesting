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
using System.Diagnostics;

namespace NAudioTesting
{
    public class AudioHandler
    {
        //Higher rates may make it more costly. Maybe make a menu for choosing between 44100, 48000, and 96000?
        //44100 has half the visualizer issue, and its more predictable. This only applies for data from the mic though. Data from files still have issues with this.
        public WaveFormat waveFormat = WaveFormat.CreateIeeeFloatWaveFormat(48000, 2);
        public WaveOutEvent output = new WaveOutEvent();
        public List<IWaveProvider> allAudioBeingPlayed;
        public WaveProvider32 waveProvider;
        
        public MixingSampleProvider mixerProvider;

        public WaveInEvent micRecorder;
        public List<SoundModifier> audioModifiers = new List<SoundModifier>();
        public event EventHandler stopAllSound;
        public event EventHandler appClosed;
        public byte[] fourierBuffer;

        public string[] getCaptureDevices()
        {
            MMDeviceEnumerator enumerator = new MMDeviceEnumerator();
            string[] returnStrings = new string[WaveIn.DeviceCount];
            for (int i = 0; i < WaveIn.DeviceCount; i++)
            {
                returnStrings[i] = enumerator.EnumerateAudioEndPoints(DataFlow.Capture, DeviceState.Active)[i].DeviceFriendlyName;
            }
            enumerator.Dispose();
            return returnStrings;
        }
        public MMDevice getCaptureDevice(int id)
        {
            MMDeviceEnumerator enumerator = new MMDeviceEnumerator();
            MMDevice returnDevice = enumerator.EnumerateAudioEndPoints(DataFlow.Capture, DeviceState.Active)[id];
            enumerator.Dispose();
            return returnDevice;
        }
        public MMDevice getRenderDevice(int id)
        {
            MMDeviceEnumerator enumerator = new MMDeviceEnumerator();
            MMDevice returnDevice = enumerator.EnumerateAudioEndPoints(DataFlow.Render, DeviceState.Active)[id];
            enumerator.Dispose();
            return returnDevice;
        }
        public string[] getRenderDevices()
        {
            MMDeviceEnumerator enumerator = new MMDeviceEnumerator();
            string[] returnStrings = new string[WaveOut.DeviceCount];
            for (int i = 0; i < WaveOut.DeviceCount; i++)
            {
                returnStrings[i] = enumerator.EnumerateAudioEndPoints(DataFlow.Render, DeviceState.Active)[i].DeviceFriendlyName;
            }
            enumerator.Dispose();
            return returnStrings;
        }
        public void setOutputDevice(int deviceNum)
        {
            output.Stop();
            output.DeviceNumber = deviceNum;
            //output.Init(mixerProvider);
            //output.Init(new BufferSaver(mixerProvider.ToWaveProvider()));
            //output.Init(mixerProvider);
            applyModifiers();
        }
        public void addInputDevice(int deviceNum)
        {

        }
        public AudioHandler()
        {
            Process.GetCurrentProcess().PriorityClass = ProcessPriorityClass.RealTime;
        }

        public void onClose()
        {
            micRecorder.StopRecording();
            micRecorder.Dispose();
            appClosed?.Invoke(this, new EventArgs());
        }

        //public void dataInOnSpeaker(object sender, WaveInEventArgs args)
        //{
        //    buffer?.AddSamples(args.Buffer, 15, args.BytesRecorded);
        //}

        public void setUpMixer()
        {
            if(output.DeviceNumber == -1)
            {
                output.DeviceNumber = 0;
            }
            //WaveFormat tester = WaveFormat.CreateIeeeFloatWaveFormat(96000, 2);
            mixerProvider = new MixingSampleProvider(waveFormat)
            {
                ReadFully = true
            };
            //finalOutput = new BufferSaver(mixerProvider.ToWaveProvider());
            output.Stop();
            //output.Init(mixerProvider);
            applyModifiers();

            //output.Init(mixerProvider.ToWaveProvider());
            micRecorder = new WaveInEvent()
            {
                WaveFormat = waveFormat,
                BufferMilliseconds = 25
            };
            micRecorder.StartRecording();
            //mixerProvider.AddMixerInput(new WaveInProvider(speakerCapture));
            //mixerProvider.AddMixerInput(new WaveInProvider(micRecorder));
            ///Problems with the visualizer persist even without the mixer. Problem also goes away once it is saved to file. The only noticeable affect on audio the problem has is a ringing noise that only plays when something should be playing audio
            addInputToMixer(new WaveInProvider(micRecorder).ToSampleProvider());
            output.Play();

        }
        public void applyModifiers()
        {
            ISampleProvider modifiedSample = mixerProvider;
            foreach(SoundModifier modifier in audioModifiers)
            {
                modifiedSample = modifier.applyEffect(modifiedSample);
            }
            //modifiedSample = new CompressorEffect(this).applyEffect(modifiedSample);
            output.Stop();
            output.Init(modifiedSample);
            output.Play();
        }
        public void addInputToMixer(ISampleProvider input)
        {
            mixerProvider.AddMixerInput(input);
        }
        public void removeInputFromMixer(ISampleProvider input)
        {
            mixerProvider.RemoveMixerInput(input);
        }
        public void stopAllAudio()
        {
            mixerProvider.RemoveAllMixerInputs();
            micRecorder.StopRecording();
            micRecorder = new WaveInEvent()
            {
                WaveFormat = output.OutputWaveFormat
            };
            micRecorder.StartRecording();
            //mixerProvider.AddMixerInput(new WaveInProvider(micRecorder));
            addInputToMixer(new WaveInProvider(micRecorder).ToSampleProvider());

            applyModifiers();

            stopAllSound?.Invoke(this, new EventArgs());
        }

        public void playFromWaveProvider(IWaveProvider input)
        {
            
            //output.
        }
    }
}
