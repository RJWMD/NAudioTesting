using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NAudioTesting
{
    namespace GridElements
    {
        public partial class ClipCapturerBlock : UserControl
        {
            public bool capturing = false;
            ClipCapturer capturer;

            public ClipCapturerBlock()
            {
                InitializeComponent();
                capturer = new ClipCapturer(Program.audioHandler);
                Program.audioHandler.finalOutput.newDataChunk += feedVisualizer1.addNewData;
                //Program.audioHandler.finalOutput.newData += feedVisualizer1.newPartialData;
                feedVisualizer1.format = Program.audioHandler.finalOutput.WaveFormat;
                Program.audioHandler.stopAllSound += setEvents;
            }
            public void setEvents(object sender, EventArgs args)
            {
                Program.audioHandler.finalOutput.newDataChunk += feedVisualizer1.addNewData;
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
            }

            private void fileVisualizer1_Load(object sender, EventArgs e)
            {

            }
        }
    }
}
