using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace NAudioTesting
{
    namespace GridElements
    {
        public partial class ClipCapturerBlock : UserControl
        {
            public bool capturing
            {
                get
                {
                    return _capturing;
                }
                set
                {
                    capturer.recording = value;
                    _capturing = value;
                }
            }

            private bool _capturing;
            ClipCapturer capturer;

            public ClipCapturerBlock()
            {
                InitializeComponent();
                capturer = new ClipCapturer(Program.audioHandler);
                capturer.buffer.newDataChunk += feedVisualizer1.addNewData;
                //Program.audioHandler.finalOutput.newData += feedVisualizer1.newPartialData;
                feedVisualizer1.format = capturer.buffer.WaveFormat;
                Program.audioHandler.stopAllSound += setEvents;
            }
            public void setEvents(object sender, EventArgs args)
            {
                capturer.buffer.newDataChunk += feedVisualizer1.addNewData;
            }

            private void Capture_Click(object sender, EventArgs e)
            {
                if(capturing)
                {
                    Capture.Text = "Capture";
                    capturer.stopRecording();
                }
                else
                {
                    Capture.Text = "Capturing";
                    capturer.startRecording();
                }
                capturing = !capturing;
                
            }

            private void CaptureSave_Click(object sender, EventArgs e)
            {
                //Make instance of temporary file player block
                capturer.saveRecording();
                //MainForm.main.ToolsContainer.Controls.Add(new TempFilePlayerBlock());
            }

            private void ClipLength_ValueChanged(object sender, EventArgs e)
            {
                capturer.clipLength = (float)ClipLength.Value;
                feedVisualizer1.ClearDisplayMap();
                feedVisualizer1.bufferTime = (float)ClipLength.Value;
            }

            private void fileVisualizer1_Load(object sender, EventArgs e)
            {

            }

            private void Label_Paint(object sender, PaintEventArgs e)
            {

            }

            private void ClipCapturerBlock_Paint(object sender, PaintEventArgs e)
            {
                using (Bitmap bitMap = new Bitmap(BackgroundImage))
                {
                    ColorMap colorMap = new ColorMap();
                    colorMap.OldColor = Color.FromArgb(255, 223, 113, 38);
                    colorMap.NewColor = Color.FromArgb(255, 172, 50, 50);
                    ImageAttributes img = new ImageAttributes();
                    ColorMap[] mapArray = { colorMap };

                    img.SetRemapTable(mapArray);
                    e.Graphics.DrawImage(bitMap, new Rectangle(0, 0, Width, Height), 0, 0, bitMap.Width, bitMap.Height, GraphicsUnit.Pixel, img);

                }
            }
        }
    }
}
