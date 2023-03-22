using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Dsp;
using NAudio;
using NAudio.Wave;
using System.Drawing.Imaging;

namespace NAudioTesting
{
    namespace GridElements
    {
        public partial class SpeakerCapturerBlock : UserControl
        {
            SpeakerCapturer speakerCapturer;
            Complex[] fftResults;

            public SpeakerCapturerBlock()
            {
                InitializeComponent();
                speakerCapturer = new SpeakerCapturer(Program.audioHandler);
                speakerCapturer.fftFinished += fftFinished;
            }

            private void SpeakerInputDropdown_SelectedIndexChanged(object sender, EventArgs e)
            {
                if(SpeakerInputDropdown.SelectedIndex != speakerCapturer.deviceID)
                    speakerCapturer.setSpeakerCapture(SpeakerInputDropdown.SelectedIndex, true);
                speakerCapturer.speakerCapturer.DataAvailable += OnDataAvailable;
            }

            private void SpeakerInputDropdown_MouseEnter(object sender, EventArgs e)
            {
                int priorIndex = SpeakerInputDropdown.SelectedIndex;
                SpeakerInputDropdown.Items.Clear();
                SpeakerInputDropdown.Items.AddRange(Program.audioHandler.getRenderDevices());
                SpeakerInputDropdown.SelectedIndex = priorIndex;
            }
            public void fftFinished(object sender, FftEventArgs args)
            {
                fftResults = args.Result;
                panel1.Refresh();
            }
            public void OnDataAvailable(object sender, WaveInEventArgs args)
            {
                if (this.InvokeRequired)
                {
                    this.BeginInvoke(new EventHandler<WaveInEventArgs>(OnDataAvailable), sender, args);
                }
                else
                {
                    byte[] buffer = args.Buffer;
                    int bytesRecorded = args.BytesRecorded;
                    int bufferIncrement = speakerCapturer.speakerCapturer.WaveFormat.BlockAlign;

                    for (int index = 0; index < bytesRecorded; index += bufferIncrement)
                    {
                        float sample32 = BitConverter.ToSingle(buffer, index);
                        speakerCapturer.aggregator.Add(sample32);
                    }
                }
            }
            //Keep track of each height between updates and have them slowly fall
            private void panel1_Paint(object sender, PaintEventArgs e)
            {
                if (fftResults == null)
                    return;
                for(int i = 0; i < fftResults.Length; i++)
                {
                    float frequency = 1 / fftResults[i].X;
                    float amplitude; 
                    if(fftResults[i].Y != 0)
                        amplitude = 1 / fftResults[i].Y;
                    else
                        amplitude = 0;
                    int xPosition = (int)((frequency / 100000000) * Width);
                    int yPosition = (int)((amplitude / 1000000) * Height);
                    if(xPosition < Width * 100 && xPosition > -Width * 100 && yPosition < Height * 100 && -Height * 100 < yPosition)
                        e.Graphics.DrawLine(Pens.White, new Point(xPosition, yPosition), new Point(xPosition, 0));
                    
                }
            }

            private void SpeakerCapturerBlock_Paint(object sender, PaintEventArgs e)
            {
                using (Bitmap bitMap = new Bitmap(BackgroundImage))
                {
                    ColorMap colorMap = new ColorMap();
                    colorMap.OldColor = Color.FromArgb(255, 223, 113, 38);
                    colorMap.NewColor = Color.FromArgb(255, 118, 66, 138);
                    ImageAttributes img = new ImageAttributes();
                    ColorMap[] mapArray = { colorMap };

                    img.SetRemapTable(mapArray);
                    e.Graphics.DrawImage(bitMap, new Rectangle(0, 0, Width, Height), 0, 0, bitMap.Width, bitMap.Height, GraphicsUnit.Pixel, img);

                }
            }
        }
    }
}
