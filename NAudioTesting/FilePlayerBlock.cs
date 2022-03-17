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
        public partial class FilePlayerBlock : UserControl
        {
            FilePlayer filePlayer;

            public FilePlayerBlock(string path)
            {
                InitializeComponent();
                if(path.Contains(@"\"))
                    FileNameLabel.Text = path.Substring(path.LastIndexOf(@"\") + 1);
                filePlayer = new FilePlayer(Program.audioHandler);
            }
            string getNameFromFile(string filename)
            {
                if (filename.Contains(@"\"))
                    return FileNameLabel.Text = filename.Substring(filename.LastIndexOf(@"\") + 1);
                else
                    return "";
            }
            private void FilePlayerBlock_DragDrop(object sender, DragEventArgs e)
            {

            }

            private void PlayAudio_Click(object sender, EventArgs e)
            {
                filePlayer.playFile();
            }

            private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
            {
                filePlayer.setFile(ChooseFile.FileName);
                getNameFromFile(ChooseFile.FileName);
                FileVisualiser.WaveStream = filePlayer.getWaveStream();
            }

            private void FileNameLabel_DoubleClick(object sender, EventArgs e)
            {
                ChooseFile.ShowDialog();
            }

            private void StackCheckBox_Click(object sender, EventArgs e)
            {
                filePlayer.stackAudio = StackCheckBox.Checked;
            }

            private void LoopCheckBox_Click(object sender, EventArgs e)
            {
                filePlayer.loopAudio = LoopCheckBox.Checked;
            }
        }
    }
}
