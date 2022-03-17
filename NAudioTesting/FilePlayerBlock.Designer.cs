
namespace NAudioTesting
{
    namespace GridElements
    {
        partial class FilePlayerBlock
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
            this.ChooseFile = new System.Windows.Forms.OpenFileDialog();
            this.PlayAudio = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.FileVisualiser = new NAudio.Gui.WaveViewer();
            this.FileNameLabel = new System.Windows.Forms.Label();
            this.StackCheckBox = new System.Windows.Forms.CheckBox();
            this.LoopCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // ChooseFile
            // 
            this.ChooseFile.FileName = "ChooseFile";
            this.ChooseFile.Title = "Choose a file";
            this.ChooseFile.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // PlayAudio
            // 
            this.PlayAudio.Location = new System.Drawing.Point(19, 40);
            this.PlayAudio.Name = "PlayAudio";
            this.PlayAudio.Size = new System.Drawing.Size(93, 33);
            this.PlayAudio.TabIndex = 0;
            this.PlayAudio.Text = "Play file";
            this.PlayAudio.UseVisualStyleBackColor = true;
            this.PlayAudio.Click += new System.EventHandler(this.PlayAudio_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(118, 70);
            this.trackBar1.Maximum = 200;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(169, 69);
            this.trackBar1.TabIndex = 1;
            this.trackBar1.TickFrequency = 25;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBar1.Value = 100;
            // 
            // FileVisualiser
            // 
            this.FileVisualiser.BackColor = System.Drawing.SystemColors.Control;
            this.FileVisualiser.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FileVisualiser.Location = new System.Drawing.Point(19, 112);
            this.FileVisualiser.Name = "FileVisualiser";
            this.FileVisualiser.SamplesPerPixel = 128;
            this.FileVisualiser.Size = new System.Drawing.Size(268, 55);
            this.FileVisualiser.StartPosition = ((long)(0));
            this.FileVisualiser.TabIndex = 2;
            this.FileVisualiser.WaveStream = null;
            // 
            // FileNameLabel
            // 
            this.FileNameLabel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.FileNameLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.FileNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FileNameLabel.Location = new System.Drawing.Point(0, 0);
            this.FileNameLabel.Name = "FileNameLabel";
            this.FileNameLabel.Size = new System.Drawing.Size(305, 39);
            this.FileNameLabel.TabIndex = 3;
            this.FileNameLabel.Text = "File Name";
            this.FileNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FileNameLabel.DoubleClick += new System.EventHandler(this.FileNameLabel_DoubleClick);
            // 
            // StackCheckBox
            // 
            this.StackCheckBox.AutoSize = true;
            this.StackCheckBox.Location = new System.Drawing.Point(118, 45);
            this.StackCheckBox.Name = "StackCheckBox";
            this.StackCheckBox.Size = new System.Drawing.Size(76, 24);
            this.StackCheckBox.TabIndex = 4;
            this.StackCheckBox.Text = "Stack";
            this.StackCheckBox.UseVisualStyleBackColor = true;
            this.StackCheckBox.Click += new System.EventHandler(this.StackCheckBox_Click);
            // 
            // LoopCheckBox
            // 
            this.LoopCheckBox.AutoSize = true;
            this.LoopCheckBox.Location = new System.Drawing.Point(216, 45);
            this.LoopCheckBox.Name = "LoopCheckBox";
            this.LoopCheckBox.Size = new System.Drawing.Size(71, 24);
            this.LoopCheckBox.TabIndex = 5;
            this.LoopCheckBox.Text = "Loop";
            this.LoopCheckBox.UseVisualStyleBackColor = true;
            this.LoopCheckBox.Click += new System.EventHandler(this.LoopCheckBox_Click);
            // 
            // FilePlayerBlock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.LoopCheckBox);
            this.Controls.Add(this.StackCheckBox);
            this.Controls.Add(this.FileNameLabel);
            this.Controls.Add(this.FileVisualiser);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.PlayAudio);
            this.Name = "FilePlayerBlock";
            this.Size = new System.Drawing.Size(305, 181);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.FilePlayerBlock_DragDrop);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

            #endregion

            private System.Windows.Forms.OpenFileDialog ChooseFile;
            private System.Windows.Forms.Button PlayAudio;
            private System.Windows.Forms.TrackBar trackBar1;
            private NAudio.Gui.WaveViewer FileVisualiser;
            private System.Windows.Forms.Label FileNameLabel;
            private System.Windows.Forms.CheckBox StackCheckBox;
            private System.Windows.Forms.CheckBox LoopCheckBox;
        }
    }
}
