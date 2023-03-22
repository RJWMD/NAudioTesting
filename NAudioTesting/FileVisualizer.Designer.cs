
namespace NAudioTesting
{
    partial class FileVisualizer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // FileVisualizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Name = "FileVisualizer";
            this.Size = new System.Drawing.Size(173, 43);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FileVisualizer_MouseClick);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.FileVisualizer_MouseDoubleClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FileVisualizer_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FileVisualizer_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FileVisualizer_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion

        //sprivate NAudio.Gui.WaveViewer waveViewer1;
        //private System.Windows.Forms.Panel panel1;
    }
}
