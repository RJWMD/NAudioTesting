
namespace NAudioTesting
{
    namespace GridElements
    {
        partial class TempFilePlayerBlock
        {
            /// <summary>
            /// Required designer variable.
            /// </summary>
            private System.ComponentModel.IContainer components = null;

            /// <summary>
            /// Clean up any resources being used.
            /// </summary>
            /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
            protected override void Dispose(bool disposing)
            {
                if (disposing && (components != null))
                {
                    components.Dispose();
                }
                base.Dispose(disposing);
            }

            #region Windows Form Designer generated code

            /// <summary>
            /// Required method for Designer support - do not modify
            /// the contents of this method with the code editor.
            /// </summary>
            private void InitializeComponent()
            {
            this.components = new System.ComponentModel.Container();
            this.saveDialog = new System.Windows.Forms.SaveFileDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FileNameLabel
            // 
            this.FileNameLabel.Dock = System.Windows.Forms.DockStyle.None;
            this.FileNameLabel.Location = new System.Drawing.Point(-3, 28);
            this.FileNameLabel.Size = new System.Drawing.Size(366, 32);
            this.FileNameLabel.Click += new System.EventHandler(this.FileNameLabel_Click);
            // 
            // saveDialog
            // 
            this.saveDialog.Filter = "wav files (*.wav)|*.wav";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(135, 36);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(134, 32);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click_1);
            // 
            // TempFilePlayerBlock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Name = "TempFilePlayerBlock";
            this.Controls.SetChildIndex(this.FileVisualizer, 0);
            this.Controls.SetChildIndex(this.FileNameLabel, 0);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

            }

            #endregion

            private System.Windows.Forms.SaveFileDialog saveDialog;
            private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
            private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        }
    }
}
