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
    public partial class MainForm : Form
    {
        public static MainForm main;
        public MainForm()
        {
            InitializeComponent();
            main = this;
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            //Program.audioHandler.playbackAudio();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(OpenFolder.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            loadPlayerButtons(OpenFolder.SelectedPath);
            
        }

        //private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        //{
        //    pitch = (int)WavePitchShift.Value;
        //}

        //private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    soundType = WaveType.SelectedIndex;
        //}

        private void flowLayoutPanel1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void flowLayoutPanel1_Resize(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void PanelRightClick_Opening(object sender, CancelEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void emptyToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ToolsContainer.Controls.Add(new GridElements.Empty());
            
        }

        private void wavePlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolsContainer.Controls.Add(new GridElements.WavePlayerBlock());
        }

        private void OutputDevice_SelectedIndexChanged(object sender, EventArgs e)
        {
            Program.audioHandler.setOutputDevice(OutputDevice.SelectedIndex);
        }

        private void InputDeviceMic_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void InputDeviceMic_MouseEnter(object sender, EventArgs e)
        {
            int priorIndex = InputDeviceMic.SelectedIndex;
            InputDeviceMic.Items.Clear();
            InputDeviceMic.Items.AddRange(Program.audioHandler.getCaptureDevices());
            InputDeviceMic.SelectedIndex = priorIndex;
        }

        private void OutputDevice_MouseEnter(object sender, EventArgs e)
        {
            int priorIndex = OutputDevice.SelectedIndex;
            OutputDevice.Items.Clear();
            OutputDevice.Items.AddRange(Program.audioHandler.getRenderDevices());
            OutputDevice.SelectedIndex = priorIndex;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.audioHandler.stopAllAudio();
            Program.audioHandler.onClose();
        }

        private void ToolsContainer_DragDrop(object sender, DragEventArgs e)//Allow drop causes memory leaks
        {
            e.Effect = DragDropEffects.Copy;
            string[] addedFiles = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in addedFiles)
            {
               ToolsContainer.Controls.Add(new GridElements.FilePlayerBlock(file));
            }
        }

        private void filePlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolsContainer.Controls.Add(new GridElements.FilePlayerBlock("NotSet"));
        }

        private void StopAllAudioButton_Click(object sender, EventArgs e)
        {
            Program.audioHandler.stopAllAudio();
        }

        private void pitchShifterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolsContainer.Controls.Add(new GridElements.PitchShifterBlock());
        }

        private void speakerCapturerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolsContainer.Controls.Add(new GridElements.SpeakerCapturerBlock());
        }

        public void loadPlayerButtons(string folderPath)
        {
            string[] files = System.IO.Directory.GetFiles(folderPath);
            foreach(string file in files)
            {
                ToolsContainer.Controls.Add(new GridElements.FilePlayerBlock(file));
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for(int i = Program.loops.Count - 1; i >= 0; i--)
            {
                if(Program.loops[i].run())
                {
                    Program.loops.RemoveAt(i);
                }
            }
        }

        private void clipCapturerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolsContainer.Controls.Add(new GridElements.ClipCapturerBlock());
        }
        //private void OpenFolder_FileOk(object sender, CancelEventArgs e)
        //{
        //    loadPlayerButtons(OpenFolder.SelectedPath);
        //}
    }
}
