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
    class PitchShifter : SoundModifier
    {
        public float amount;
        public SmbPitchShiftingSampleProvider pitchShifter;
        public AudioHandler audioHandler;
        SmbPitchShiftingSampleProvider shiftedPitch;

        public PitchShifter(AudioHandler audioHandler)
        {
            this.audioHandler = audioHandler;
        }
        public ISampleProvider applyEffect(ISampleProvider input)
        {
            shiftedPitch = new SmbPitchShiftingSampleProvider(input);
            shiftedPitch.PitchFactor = amount;
            return shiftedPitch;
        }
        public void applyPitchShift()
        {
            audioHandler.audioModifiers.Add(this);
            audioHandler.applyModifiers();
        }
        public void removePitchShift()
        {
            audioHandler.audioModifiers.Remove(this);
            audioHandler.applyModifiers();
            //Remove pitch shift from list of modifiers and reget sampleProviders
        }
        public void updatePitchShift()
        {
            if(shiftedPitch != null)
                shiftedPitch.PitchFactor = amount;
        }
        public void setPitchShift(float amount)
        {
            this.amount = amount;

        }
    }
}
