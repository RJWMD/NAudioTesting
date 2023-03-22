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
            protected FilePlayer filePlayer;
            public FilePlayer FilePlayer
            {
                get { return filePlayer; }
            }
            LoopRequest loop;

            protected FilePlayerBlock()
            {
                InitializeComponent();
                FileVisualizer.clicked += visualizerClicked;
                filePlayer = new FilePlayer(Program.audioHandler);
            }
            public FilePlayerBlock(string path)
            {
                InitializeComponent();
                if(path.Contains(@"\"))
                    FileNameLabel.Text = path.Substring(path.LastIndexOf(@"\") + 1);
                filePlayer = new FilePlayer(Program.audioHandler);
                if(path.Contains(@"."))
                {
                    try
                    {
                        filePlayer.setFile(path);
                        FileVisualizer.WaveStream = filePlayer.getWaveStream();
                    }
                    catch
                    {
                        //Unsupported file type given
                        FileNameLabel.Text = "Unsupported file";
                    }
                }
                FileVisualizer.clicked += visualizerClicked;
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
            public void visualizerClicked(MouseEventArgs args)
            {
                if (filePlayer.fileReader == null)
                    return;
                float trackProgress = (args.X * 1f / FileVisualizer.Width);    
                filePlayer.fileReader.Position = (long)(trackProgress * filePlayer.fileReader.Length);
                FileVisualizer.startTime = DateTime.Now - new TimeSpan(0,0,0,0, (int)(filePlayer.fileReader.TotalTime.TotalMilliseconds * trackProgress));
                playAudio();
            }
            public void playAudio()
            {
                if (loop != null)
                    Program.loops.Remove(loop);
                filePlayer.playFile();
                FileVisualizer.stream = filePlayer.fileReader;
                
                loop = new LoopRequest(FileVisualizer.updateTracker);
                Program.loops.Add(loop);
            }
            private void PlayAudio_Click(object sender, EventArgs e)
            {
                if (filePlayer?.fileReader == null)
                    return;
                filePlayer.fileReader.Position = (long)(filePlayer.fileReader.startPoint * filePlayer.fileReader.Length);
                FileVisualizer.startTime = DateTime.Now;
                playAudio();
            }

            private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
            {
                filePlayer.setFile(ChooseFile.FileName);
                getNameFromFile(ChooseFile.FileName);
                FileVisualizer.WaveStream = filePlayer.getWaveStream();
                FileVisualizer.stream = filePlayer.fileReader;
                FileVisualizer.generateMap();
                FileVisualizer.Refresh();
            }

            protected virtual void FileNameLabel_DoubleClick(object sender, EventArgs e)
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
                FileVisualizer.looping = LoopCheckBox.Checked;
            }
        }
    }
}
