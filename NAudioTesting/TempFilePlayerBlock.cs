using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NAudioTesting
{
    namespace GridElements
    {
        public partial class TempFilePlayerBlock : NAudioTesting.GridElements.FilePlayerBlock
        {
           //public TempFilePlayer filePlayer;

            public TempFilePlayerBlock()
            {
                InitializeComponent();
                FileNameLabel.Text = "Unsaved file";
                filePlayer = new TempFilePlayer(Program.audioHandler);
                FileVisualizer.clicked += visualizerClicked;
            }
            protected override void FileNameLabel_DoubleClick(object sender, EventArgs e)
            {
                saveDialog.ShowDialog();
            }
            public void saveFile(object sender, CancelEventArgs args)
            {
                ((TempFilePlayer)filePlayer).saveToFile(saveDialog.FileName);
            }

            private void FileNameLabel_Click(object sender, EventArgs e)
            {

            }

            public void DeleteBarItem()
            {
                MainForm.main.ToolsContainer.Controls.Remove(this);
                filePlayer.Dispose();
                Dispose();
                FileVisualizer.DeleteData();
                FileVisualizer.Dispose();
                
            }

            private void deleteToolStripMenuItem_Click_1(object sender, EventArgs e)
            {
                DeleteBarItem();
            }
        }
    }
}
